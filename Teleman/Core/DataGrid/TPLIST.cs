using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teleman.Core.JsonHelper;

namespace Teleman.Core.DataGrid
{
    public class TPLIST
    {
        public static void search_update(SiticoneDataGridView DGV, string Cell, string searchText)
        {
            DGV.SuspendLayout();
            try
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if (row.Cells[Cell].Value != null)
                    {
                        string name = row.Cells[Cell].Value.ToString().ToLower();
                        row.Visible = name.Contains(searchText);
                    }
                }
            }
            finally
            {
                DGV.ResumeLayout();
            }
        }
        public static void Setup_Table(SiticoneDataGridView DGV)
        {
            // Set the width for each column except the first one (which is the "Select" column)
            foreach (DataGridViewColumn column in DGV.Columns)
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

            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Disable row headers' ability to resize
            DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV.AllowUserToResizeRows = false;
            DGV.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                DataGridViewCheckBoxCell checkbox = new DataGridViewCheckBoxCell();
                checkbox.Value = false; // или true, в зависимости от ваших требований
                row.Cells["Check"] = checkbox;
            }
            DGV.Update();
        }
        public static void remove_row(SiticoneDataGridView DGV)
        {
            // Create a list to store indices of rows to remove
            List<int> rowsToRemove = new List<int>();

            // Iterate through the rows of the DataGridView
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                // Check if the checkbox in the current row is checked
                if (DGV.Rows[i].Cells[0].Value != null && (bool)DGV.Rows[i].Cells[0].Value)
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
                DGV.Rows.RemoveAt(rowIndex);

                // Remove the corresponding teleport point from the JSON file
                var teleportPoints = JsonHelper.JH.LoadTeleportPoints();
                teleportPoints.RemoveAt(rowIndex);
                JsonHelper.JH.SaveTeleportPoints(teleportPoints);
            }
        }        
        public static void Load_Form(SiticoneDataGridView DGV)
        {
            var teleportPoints = JH.LoadTeleportPoints();

            // Fill the existing columns with the loaded teleport points
            foreach (var point in teleportPoints)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DGV);

                // Set values for each cell in the row
                row.Cells[1].Value = point.Name;
                row.Cells[2].Value = point.X;
                row.Cells[3].Value = point.Y;
                row.Cells[4].Value = point.Z;
                row.Cells[5].Value = point.Facing;

                DGV.Rows.Add(row);
            }
        }

    }


}
