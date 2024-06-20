using Siticone.UI.WinForms;
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
using Teleman.Core.DataGrid;
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
            OMBase = MemoryHelper.RL($"base+{Offsets.ObjectManager}");
                await Console.Out.WriteLineAsync(OMBase.ToString("X"));
            PlayerBase = MemoryHelper.RL($"{OMBase.ToString("X")}+{Offsets.PlayerBase}");
                await Console.Out.WriteLineAsync(PlayerBase.ToString("X"));
            MovementBase = MemoryHelper.RL($"{PlayerBase.ToString("X")}+{Offsets.MoveBase}");
                await Console.Out.WriteLineAsync(MovementBase.ToString("X"));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string MovementBaseHex = MovementBase.ToString("X");
            float? x = MemoryHelper.RF($"{MovementBaseHex}+{Offsets.Coords.x}");
            float? y = MemoryHelper.RF($"{MovementBaseHex}+{Offsets.Coords.y}");
            float? z = MemoryHelper.RF($"{MovementBaseHex}+{Offsets.Coords.z}");
            Double facing = (Double)MemoryHelper.RF($"{MovementBaseHex}+{Offsets.Coords.facing}");

            var newPoint = new TeleportPoint
            {
                Name = Save_Name.Text,
                X = (float)x,
                Y = (float)y,
                Z = (float)z,
                Facing = facing
            };

            var teleportPoints = JH.LoadTeleportPoints();
            teleportPoints.Add(newPoint);
            JH.SaveTeleportPoints(teleportPoints);

            // Add the new row to the DataGridView
            DataGrid_TPLIST.Rows.Add(false, newPoint.Name, newPoint.X, newPoint.Y, newPoint.Z, newPoint.Facing);

            // Update the table layout
            SetTable();
        }


        private void teleport_Click(object sender, EventArgs e)
        {
            if (DataGrid_TPLIST.CurrentRow != null)
            {
                int rowIndex = DataGrid_TPLIST.CurrentRow.Index;
                float x = Convert.ToSingle(DataGrid_TPLIST.Rows[rowIndex].Cells["X"].Value);
                float y = Convert.ToSingle(DataGrid_TPLIST.Rows[rowIndex].Cells["Y"].Value);
                float z = Convert.ToSingle(DataGrid_TPLIST.Rows[rowIndex].Cells["Z"].Value);
                double facing = Convert.ToDouble(DataGrid_TPLIST.Rows[rowIndex].Cells["Facing"].Value);

                string MovementBaseHex = MovementBase.ToString("X");
                MemoryHelper.WR($"{MovementBaseHex}+{Offsets.Coords.x}", "float", x.ToString(CultureInfo.InvariantCulture));
                MemoryHelper.WR($"{MovementBaseHex}+{Offsets.Coords.y}", "float", y.ToString(CultureInfo.InvariantCulture));
                MemoryHelper.WR($"{MovementBaseHex}+{Offsets.Coords.z}", "float", z.ToString(CultureInfo.InvariantCulture));
                MemoryHelper.WR($"{MovementBaseHex}+{Offsets.Coords.facing}", "float", facing.ToString(CultureInfo.InvariantCulture));
            }
        }




        #region necesarry stuff
        private void SetTable()
        {
            TPLIST.Setup_Table(DataGrid_TPLIST);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TPLIST.Load_Form(DataGrid_TPLIST);
            SetTable();
        }

        private void Refrasher_Tick(object sender, EventArgs e) // update every X, to make sure they are not null, like after relog on other character...
        {
            Load_Offsets();
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text.Trim().ToLower();
            TPLIST.search_update(DataGrid_TPLIST, "Names", searchText);
        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e) // clean search bar
        {
            SearchBox.Text = string.Empty;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            TPLIST.remove_row(DataGrid_TPLIST);
            SetTable(); // Update the table layout
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
    }
}
