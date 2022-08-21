namespace SortingAlgorithmVisualizer
{
    partial class Form1
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.filexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.AlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.PopulateNumbersButton = new System.Windows.Forms.Button();
            this.MainSortingPanel = new System.Windows.Forms.Panel();
            this.SortButton = new System.Windows.Forms.Button();
            this.PauseResumeButton = new System.Windows.Forms.Button();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Silver;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filexToolStripMenuItem,
            this.toolStripMenuItem4});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(734, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // filexToolStripMenuItem
            // 
            this.filexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton});
            this.filexToolStripMenuItem.Name = "filexToolStripMenuItem";
            this.filexToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filexToolStripMenuItem.Text = "File";
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem4.Text = "Help";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Algorithm:";
            // 
            // AlgorithmComboBox
            // 
            this.AlgorithmComboBox.FormattingEnabled = true;
            this.AlgorithmComboBox.Location = new System.Drawing.Point(100, 31);
            this.AlgorithmComboBox.Name = "AlgorithmComboBox";
            this.AlgorithmComboBox.Size = new System.Drawing.Size(191, 21);
            this.AlgorithmComboBox.TabIndex = 2;
            // 
            // PopulateNumbersButton
            // 
            this.PopulateNumbersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PopulateNumbersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PopulateNumbersButton.Location = new System.Drawing.Point(297, 30);
            this.PopulateNumbersButton.Name = "PopulateNumbersButton";
            this.PopulateNumbersButton.Size = new System.Drawing.Size(138, 22);
            this.PopulateNumbersButton.TabIndex = 3;
            this.PopulateNumbersButton.Text = "Populate Numbers";
            this.PopulateNumbersButton.UseVisualStyleBackColor = false;
            this.PopulateNumbersButton.Click += new System.EventHandler(this.PopulateNumbersButton_Click);
            // 
            // MainSortingPanel
            // 
            this.MainSortingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSortingPanel.BackColor = System.Drawing.Color.DimGray;
            this.MainSortingPanel.Location = new System.Drawing.Point(12, 57);
            this.MainSortingPanel.Name = "MainSortingPanel";
            this.MainSortingPanel.Size = new System.Drawing.Size(710, 611);
            this.MainSortingPanel.TabIndex = 4;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SortButton.Location = new System.Drawing.Point(441, 31);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(138, 20);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // PauseResumeButton
            // 
            this.PauseResumeButton.BackColor = System.Drawing.Color.Gold;
            this.PauseResumeButton.Location = new System.Drawing.Point(585, 31);
            this.PauseResumeButton.Name = "PauseResumeButton";
            this.PauseResumeButton.Size = new System.Drawing.Size(138, 20);
            this.PauseResumeButton.TabIndex = 6;
            this.PauseResumeButton.Text = "Pause / Resume";
            this.PauseResumeButton.UseVisualStyleBackColor = false;
            this.PauseResumeButton.Click += new System.EventHandler(this.PauseResumeButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(734, 680);
            this.Controls.Add(this.PauseResumeButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.MainSortingPanel);
            this.Controls.Add(this.PopulateNumbersButton);
            this.Controls.Add(this.AlgorithmComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "Form1";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem filexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AlgorithmComboBox;
        private System.Windows.Forms.Button PopulateNumbersButton;
        private System.Windows.Forms.Panel MainSortingPanel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button PauseResumeButton;
    }
}

