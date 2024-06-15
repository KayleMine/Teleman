namespace Teleman.Opener
{
    partial class Process_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Process_window));
            this.windowProcessButton1 = new System.Windows.Forms.Button();
            this.processButton1 = new System.Windows.Forms.Button();
            this.cancelButton1 = new System.Windows.Forms.Button();
            this.openButton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // windowProcessButton1
            // 
            this.windowProcessButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(185)))));
            this.windowProcessButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.windowProcessButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowProcessButton1.ForeColor = System.Drawing.Color.White;
            this.windowProcessButton1.Location = new System.Drawing.Point(162, 176);
            this.windowProcessButton1.Name = "windowProcessButton1";
            this.windowProcessButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windowProcessButton1.Size = new System.Drawing.Size(144, 34);
            this.windowProcessButton1.TabIndex = 4;
            this.windowProcessButton1.Text = "Window list";
            this.windowProcessButton1.UseVisualStyleBackColor = false;
            this.windowProcessButton1.Click += new System.EventHandler(this.windowProcessButton1_Click);
            // 
            // processButton1
            // 
            this.processButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(185)))));
            this.processButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.processButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processButton1.ForeColor = System.Drawing.Color.White;
            this.processButton1.Location = new System.Drawing.Point(12, 176);
            this.processButton1.Name = "processButton1";
            this.processButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.processButton1.Size = new System.Drawing.Size(144, 34);
            this.processButton1.TabIndex = 5;
            this.processButton1.Text = "Process list";
            this.processButton1.UseVisualStyleBackColor = false;
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.Red;
            this.cancelButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton1.ForeColor = System.Drawing.Color.White;
            this.cancelButton1.Location = new System.Drawing.Point(400, 176);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelButton1.Size = new System.Drawing.Size(77, 34);
            this.cancelButton1.TabIndex = 6;
            this.cancelButton1.Text = "Cancel";
            this.cancelButton1.UseVisualStyleBackColor = false;
            // 
            // openButton1
            // 
            this.openButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.openButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openButton1.Location = new System.Drawing.Point(317, 176);
            this.openButton1.Name = "openButton1";
            this.openButton1.Size = new System.Drawing.Size(77, 34);
            this.openButton1.TabIndex = 7;
            this.openButton1.Text = "Open";
            this.openButton1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(94)))), ((int)(((byte)(185)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(465, 132);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            // 
            // Process_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teleman.Properties.Resources._8JPDW4LGJ5BC1635798772652;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 221);
            this.Controls.Add(this.windowProcessButton1);
            this.Controls.Add(this.processButton1);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.openButton1);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Process_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yandex Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button windowProcessButton1;
        private System.Windows.Forms.Button processButton1;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button openButton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}