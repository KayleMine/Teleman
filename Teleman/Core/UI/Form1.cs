using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teleman.Core;
using Teleman.Core.JsonHelper;


namespace Teleman.Main
{

    public partial class Form1 : Form
    {
        public static int ProcessID;
        private IntPtr OMBase;
        private IntPtr PlayerBase;
        private IntPtr MovementBase;

        public Form1()
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Load_Offsets();
            //search
            SearchBox.TextChanged += SearchBox_TextChanged;
        }

        private async void Load_Offsets()
        {
            await T_Offsets();
        }

        private async Task T_Offsets()
        {
            MemoryHelper.open(ProcessID);

            OMBase = MemoryHelper.RL($"base+{Offsets.ObjectManager.ToString("X")}");
            await Console.Out.WriteLineAsync(OMBase.ToString("X"));

            PlayerBase = MemoryHelper.RL($"{OMBase.ToString("X")}+{Offsets.PlayerBase.ToString("X")}");
            await Console.Out.WriteLineAsync(PlayerBase.ToString("X"));

            MovementBase = MemoryHelper.RL($"{PlayerBase.ToString("X")}+{Offsets.MoveBase.ToString("X")}");
            await Console.Out.WriteLineAsync(MovementBase.ToString("X"));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            float? x = MemoryHelper.RF($"{MovementBase.ToString("X")}+{Offsets.Coords.x.ToString("X")}");
            float? y = MemoryHelper.RF($"{MovementBase.ToString("X")}+{Offsets.Coords.y.ToString("X")}");
            float? z = MemoryHelper.RF($"{MovementBase.ToString("X")}+{Offsets.Coords.z.ToString("X")}");
            Double facing = (Double)MemoryHelper.RF($"{MovementBase.ToString("X")}+{Offsets.Coords.facing.ToString("X")}");

            var newPoint = new TeleportPoint
            {
                Name = Save_Name.Text,
                X = (float)x,
                Y = (float)y,
                Z = (float)z,
                Facing = facing
            };

            var teleportPoints = JsonHelper.LoadTeleportPoints();
            teleportPoints.Add(newPoint);
            JsonHelper.SaveTeleportPoints(teleportPoints);

            // Add the new row to the DataGridView
            DataGrid_TPLIST.Rows.Add(false, newPoint.Name, newPoint.X, newPoint.Y, newPoint.Z, newPoint.Facing);

            // Update the table layout
            SetTable();
        }

        private void teleport_Click(object sender, EventArgs e)
        {
            // Check if there is a current row selected in the DataGridView
            if (DataGrid_TPLIST.CurrentRow != null)
            {
                // Get the index of the current row
                int rowIndex = DataGrid_TPLIST.CurrentRow.Index;

                // Get the values of the cells in the selected 
                float x = Convert.ToSingle(DataGrid_TPLIST.Rows[rowIndex].Cells["X"].Value);
                float y = Convert.ToSingle(DataGrid_TPLIST.Rows[rowIndex].Cells["Y"].Value);
                float z = Convert.ToSingle(DataGrid_TPLIST.Rows[rowIndex].Cells["Z"].Value);
                double facing = Convert.ToDouble(DataGrid_TPLIST.Rows[rowIndex].Cells["Facing"].Value);

                MemoryHelper.WR($"{MovementBase.ToString("X")}+{Offsets.Coords.x.ToString("X")}", "float", x.ToString(CultureInfo.InvariantCulture));
                MemoryHelper.WR($"{MovementBase.ToString("X")}+{Offsets.Coords.y.ToString("X")}", "float", y.ToString(CultureInfo.InvariantCulture));
                MemoryHelper.WR($"{MovementBase.ToString("X")}+{Offsets.Coords.z.ToString("X")}", "float", z.ToString(CultureInfo.InvariantCulture));
                MemoryHelper.WR($"{MovementBase.ToString("X")}+{Offsets.Coords.facing.ToString("X")}", "float", facing.ToString(CultureInfo.InvariantCulture));
            }
            else
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var teleportPoints = JsonHelper.LoadTeleportPoints();

            // Fill the existing columns with the loaded teleport points
            foreach (var point in teleportPoints)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGrid_TPLIST);

                // Set values for each cell in the row
                row.Cells[1].Value = point.Name;
                row.Cells[2].Value = point.X;
                row.Cells[3].Value = point.Y;
                row.Cells[4].Value = point.Z;
                row.Cells[5].Value = point.Facing;

                DataGrid_TPLIST.Rows.Add(row);
            }

            SetTable();
        }


        #region necesarry stuff
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text.Trim().ToLower();

            DataGrid_TPLIST.SuspendLayout();

            try
            {
                foreach (DataGridViewRow row in DataGrid_TPLIST.Rows)
                {
                    if (row.Cells["Names"].Value != null)
                    {
                        string name = row.Cells["Names"].Value.ToString().ToLower();
                        row.Visible = name.Contains(searchText);
                    }
                }
            }
            finally
            {
                DataGrid_TPLIST.ResumeLayout();
            }
        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            SearchBox.Text = string.Empty;
        }
        private void SetTable()
        {
            // Set the width for each column except the first one (which is the "Select" column)
            foreach (DataGridViewColumn column in DataGrid_TPLIST.Columns)
            {
                if (column.Index == 1)
                {
                    column.Width = 560;
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else if (column.Index == 0)
                {
                    column.Width = 10;
                }
                else
                {
                    column.Width = 10;
                }
                column.Resizable = DataGridViewTriState.False;
            }

            DataGrid_TPLIST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Disable row headers' ability to resize
            DataGrid_TPLIST.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGrid_TPLIST.AllowUserToResizeRows = false;
            DataGrid_TPLIST.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in DataGrid_TPLIST.Rows)
            {
                DataGridViewCheckBoxCell checkbox = new DataGridViewCheckBoxCell();
                checkbox.Value = false; // или true, в зависимости от ваших требований
                row.Cells["Check"] = checkbox;
            }
            DataGrid_TPLIST.Update();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            // Create a list to store indices of rows to remove
            List<int> rowsToRemove = new List<int>();

            // Iterate through the rows of the DataGridView
            for (int i = 0; i < DataGrid_TPLIST.Rows.Count; i++)
            {
                // Check if the checkbox in the current row is checked
                if (DataGrid_TPLIST.Rows[i].Cells[0].Value != null && (bool)DataGrid_TPLIST.Rows[i].Cells[0].Value)
                {
                    // If checkbox is checked, add the index of the row to remove list
                    rowsToRemove.Add(i);
                }
            }

            // Iterate through the rows to remove in reverse order to avoid index issues
            for (int i = rowsToRemove.Count - 1; i >= 0; i--)
            {
                int rowIndex = rowsToRemove[i];

                // Remove the row from the DataGridView
                DataGrid_TPLIST.Rows.RemoveAt(rowIndex);

                // Remove the corresponding teleport point from the JSON file
                var teleportPoints = JsonHelper.LoadTeleportPoints();
                teleportPoints.RemoveAt(rowIndex);
                JsonHelper.SaveTeleportPoints(teleportPoints);
            }

            // Update the table layout
            SetTable();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Make sure to terminate the application when the main form is closed
            Application.Exit();
        }
        #endregion
        #region ovverides

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = RoundedRectangle(new Rectangle(0, 0, this.Width, this.Height), 20))
            {
                this.Region = new Region(path);
                using (Pen pen = new Pen(Color.Gray, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // Method to create a rounded rectangle path
        private GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top left arc
            path.AddArc(arc, 180, 90);

            // Top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private Point lastPoint;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            lastPoint = new Point(e.X, e.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        #endregion
        #region region for region what you will do to me? Huh?
        private void Refrasher_Tick(object sender, EventArgs e)
        {
            Load_Offsets();
        }
        #endregion
    }
}
