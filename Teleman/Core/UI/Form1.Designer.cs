namespace Teleman.Main
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Save = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.Save_Name = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.teleport = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.remove = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.Exit = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.DataGrid_TPLIST = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimize = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneRoundedGradientButton1 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.Refrasher = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TPLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.CheckedState.Parent = this.Save;
            this.Save.CustomImages.Parent = this.Save;
            this.Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.HoveredState.Parent = this.Save;
            this.Save.Location = new System.Drawing.Point(225, 290);
            this.Save.Name = "Save";
            this.Save.ShadowDecoration.Parent = this.Save;
            this.Save.Size = new System.Drawing.Size(105, 36);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Save_Name
            // 
            this.Save_Name.BackColor = System.Drawing.Color.Transparent;
            this.Save_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Save_Name.DefaultText = "";
            this.Save_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Save_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Save_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Save_Name.DisabledState.Parent = this.Save_Name;
            this.Save_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Save_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_Name.FocusedState.Parent = this.Save_Name;
            this.Save_Name.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_Name.HoveredState.Parent = this.Save_Name;
            this.Save_Name.Location = new System.Drawing.Point(12, 290);
            this.Save_Name.Name = "Save_Name";
            this.Save_Name.PasswordChar = '\0';
            this.Save_Name.PlaceholderText = "Name";
            this.Save_Name.SelectedText = "";
            this.Save_Name.ShadowDecoration.Parent = this.Save_Name;
            this.Save_Name.Size = new System.Drawing.Size(207, 36);
            this.Save_Name.TabIndex = 5;
            // 
            // teleport
            // 
            this.teleport.BackColor = System.Drawing.Color.Transparent;
            this.teleport.CheckedState.Parent = this.teleport;
            this.teleport.CustomImages.Parent = this.teleport;
            this.teleport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.teleport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.teleport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.teleport.ForeColor = System.Drawing.Color.White;
            this.teleport.HoveredState.Parent = this.teleport;
            this.teleport.Location = new System.Drawing.Point(447, 290);
            this.teleport.Name = "teleport";
            this.teleport.ShadowDecoration.Parent = this.teleport;
            this.teleport.Size = new System.Drawing.Size(198, 36);
            this.teleport.TabIndex = 6;
            this.teleport.Text = "teleport";
            this.teleport.Click += new System.EventHandler(this.teleport_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Transparent;
            this.remove.CheckedState.Parent = this.remove;
            this.remove.CustomImages.Parent = this.remove;
            this.remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.remove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.HoveredState.Parent = this.remove;
            this.remove.Location = new System.Drawing.Point(336, 290);
            this.remove.Name = "remove";
            this.remove.ShadowDecoration.Parent = this.remove;
            this.remove.Size = new System.Drawing.Size(105, 36);
            this.remove.TabIndex = 7;
            this.remove.Text = "Remove selected";
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.CheckedState.Parent = this.Exit;
            this.Exit.CustomImages.Parent = this.Exit;
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.Exit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.HoveredState.Parent = this.Exit;
            this.Exit.Location = new System.Drawing.Point(588, 12);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(57, 26);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DataGrid_TPLIST
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid_TPLIST.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_TPLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_TPLIST.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGrid_TPLIST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_TPLIST.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_TPLIST.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_TPLIST.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_TPLIST.ColumnHeadersHeight = 21;
            this.DataGrid_TPLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Names,
            this.X,
            this.Y,
            this.Z,
            this.Facing});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_TPLIST.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_TPLIST.EnableHeadersVisualStyles = false;
            this.DataGrid_TPLIST.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_TPLIST.Location = new System.Drawing.Point(12, 41);
            this.DataGrid_TPLIST.Name = "DataGrid_TPLIST";
            this.DataGrid_TPLIST.RowHeadersVisible = false;
            this.DataGrid_TPLIST.RowHeadersWidth = 15;
            this.DataGrid_TPLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_TPLIST.Size = new System.Drawing.Size(633, 243);
            this.DataGrid_TPLIST.TabIndex = 9;
            this.DataGrid_TPLIST.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid_TPLIST.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_TPLIST.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid_TPLIST.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid_TPLIST.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid_TPLIST.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid_TPLIST.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.DataGrid_TPLIST.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_TPLIST.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid_TPLIST.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid_TPLIST.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGrid_TPLIST.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid_TPLIST.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid_TPLIST.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGrid_TPLIST.ThemeStyle.ReadOnly = false;
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.Height = 22;
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid_TPLIST.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Check.Width = 69;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Names.Width = 555;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Visible = false;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y.Visible = false;
            // 
            // Z
            // 
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            this.Z.ReadOnly = true;
            this.Z.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Z.Visible = false;
            // 
            // Facing
            // 
            this.Facing.HeaderText = "Facing";
            this.Facing.Name = "Facing";
            this.Facing.ReadOnly = true;
            this.Facing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Facing.Visible = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.CheckedState.Parent = this.Minimize;
            this.Minimize.CustomImages.Parent = this.Minimize;
            this.Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.Minimize.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.HoveredState.Parent = this.Minimize;
            this.Minimize.Location = new System.Drawing.Point(525, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Parent = this.Minimize;
            this.Minimize.Size = new System.Drawing.Size(57, 26);
            this.Minimize.TabIndex = 10;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Drunk Mate: Teleporter";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.Parent = this.SearchBox;
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.FocusedState.Parent = this.SearchBox;
            this.SearchBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.HoveredState.Parent = this.SearchBox;
            this.SearchBox.Location = new System.Drawing.Point(321, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "Search!";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.Parent = this.SearchBox;
            this.SearchBox.Size = new System.Drawing.Size(198, 26);
            this.SearchBox.TabIndex = 13;
            // 
            // siticoneRoundedGradientButton1
            // 
            this.siticoneRoundedGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton1.CheckedState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.CustomImages.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(118)))), ((int)(((byte)(155)))));
            this.siticoneRoundedGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.siticoneRoundedGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedGradientButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedGradientButton1.HoveredState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Location = new System.Drawing.Point(272, 12);
            this.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
            this.siticoneRoundedGradientButton1.ShadowDecoration.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Size = new System.Drawing.Size(43, 26);
            this.siticoneRoundedGradientButton1.TabIndex = 14;
            this.siticoneRoundedGradientButton1.Text = "Reset";
            this.siticoneRoundedGradientButton1.Click += new System.EventHandler(this.siticoneRoundedGradientButton1_Click);
            // 
            // Refrasher
            // 
            this.Refrasher.Enabled = true;
            this.Refrasher.Interval = 5000;
            this.Refrasher.Tick += new System.EventHandler(this.Refrasher_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.BackgroundImage = global::Teleman.Properties.Resources._8JPDW4LGJ5BC1635798772652;
            this.ClientSize = new System.Drawing.Size(659, 338);
            this.Controls.Add(this.siticoneRoundedGradientButton1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.teleport);
            this.Controls.Add(this.Save_Name);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DataGrid_TPLIST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yandex Browser";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TPLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton Save;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox Save_Name;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton teleport;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton remove;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton Exit;
        private Siticone.UI.WinForms.SiticoneDataGridView DataGrid_TPLIST;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton Minimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facing;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox SearchBox;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton1;
        private System.Windows.Forms.Timer Refrasher;
    }
}

