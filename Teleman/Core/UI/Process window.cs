using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teleman.Main;

namespace Teleman.Opener
{
    public partial class Process_window : Form
    {

        private readonly Button openButton;
        private readonly Button cancelButton;
        private readonly Button processButton;
        private readonly Button windowProcessButton;

        private readonly ListBox processListBox;

        public Process_window()
        {
            // TODO: make gui pretty

            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            processListBox = listBox1;

            // Buttons
            openButton = openButton1;
            cancelButton = cancelButton1;
            processButton = processButton1;
            windowProcessButton = windowProcessButton1;

            SuspendLayout();

            // processListBox

            listBox1.MultiColumn = false;
            listBox1.SelectionMode = SelectionMode.One;
            populateWithProcesses(processListBox);
            listBox1.SetSelected(0, true);
            listBox1.MouseDoubleClick += processListBox_MouseDoubleClick;

            // openButton
            openButton.TabIndex = 0;
            openButton.Text = "Open Process";
            openButton.Click += openButton_Click;

            // cancelButton
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.Click += cancelButton_Click;

            // processButton
            processButton.TabIndex = 2;
            processButton.Text = "Process List";
            processButton.Click += processButton_Click;

            // windowProcessButton
            windowProcessButton.TabIndex = 3;
            windowProcessButton.Text = "Window List";
            windowProcessButton.Click += windowProcessButton_Click;

            ResumeLayout();
        }

        // Gets the PID of selected process, sets the PID in Crystal.cs to selected and disposes of the ProcessWindow dialog
        private void openButton_Click(object sender, EventArgs e)
        {
            if (processListBox.SelectedItem is string)
            {
                var tempString = (string)processListBox.SelectedItem;
                var processString = tempString.Split('-');

                if (processString.Length > 0)
                {
                    int processID;
                    if (int.TryParse(processString[0], out processID))
                    {
                        Main.Form1.ProcessID = processID;
                        Hide();
                        Form1 newForm = new Form1();
                        newForm.StartPosition = FormStartPosition.CenterParent;
                        newForm.Show();
                    }
                    else
                    {
                        // Handle the case where process ID is not a valid integer
                        MessageBox.Show("Invalid process ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            populateWithProcesses(processListBox);
        }

        private void windowProcessButton_Click(object sender, EventArgs e)
        {
            populateWithWindowProcesses(processListBox);
        }

        private void processListBox_MouseDoubleClick(object sender, EventArgs e)
        {
            openButton_Click(sender, e);
        }

        private void ProcessWindow_Load(object sender, EventArgs e)
        {
        }

        public System.Diagnostics.Process[] getProcesses()
        {
            var processList = System.Diagnostics.Process.GetProcesses();
            return processList;
        }

        private void processButton1_Click(object sender, EventArgs e)
        {
        }

        // Populates the ListBox with the currently running processes
        private void populateWithProcesses(ListBox listBox)
        {
            var processList = getProcesses();
            listBox.Items.Clear();
            foreach (var process in processList) listBox.Items.Add(process.Id + "-" + process.ProcessName);
            listBox.SetSelected(0, true);
        }

        // Populates the ListBox with the currently opened windows
        private void populateWithWindowProcesses(ListBox listBox)
        {
            var windowProcessList = getProcesses();
            listBox.Items.Clear();
            listBox.Items.Add("Pick WoW process and hit open.");
            foreach (var windowProcess in windowProcessList)
                if (windowProcess.MainWindowTitle.Length > 8 && windowProcess.MainWindowTitle.Contains("World"))
                    listBox.Items.Add(windowProcess.Id + " - " + windowProcess.MainWindowTitle);
            listBox.SetSelected(0, true);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!e.Cancel)
                for (var op = 99; op >= 0; op -= 3)
                {
                    Opacity = op / 100f;
                    Thread.Sleep(15);
                }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void windowProcessButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
