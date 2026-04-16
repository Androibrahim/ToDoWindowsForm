namespace ToDo.Forms
{
    partial class MainHomeForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            HomeDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            LogOut = new Label();
            UserNameLabel = new Label();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)HomeDataGrid).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // HomeDataGrid
            // 
            HomeDataGrid.AllowUserToAddRows = false;
            HomeDataGrid.AllowUserToDeleteRows = false;
            HomeDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            HomeDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            HomeDataGrid.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            HomeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            HomeDataGrid.ColumnHeadersHeight = 25;
            HomeDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            HomeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            HomeDataGrid.GridColor = Color.Gray;
            HomeDataGrid.Location = new Point(90, 187);
            HomeDataGrid.Name = "HomeDataGrid";
            HomeDataGrid.ReadOnly = true;
            HomeDataGrid.RowHeadersVisible = false;
            HomeDataGrid.RowTemplate.Height = 30;
            HomeDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            HomeDataGrid.Size = new Size(1274, 428);
            HomeDataGrid.TabIndex = 4;
            HomeDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            HomeDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            HomeDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            HomeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            HomeDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            HomeDataGrid.ThemeStyle.BackColor = Color.White;
            HomeDataGrid.ThemeStyle.GridColor = Color.Gray;
            HomeDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            HomeDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            HomeDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            HomeDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            HomeDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            HomeDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            HomeDataGrid.ThemeStyle.ReadOnly = true;
            HomeDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            HomeDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            HomeDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            HomeDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            HomeDataGrid.ThemeStyle.RowsStyle.Height = 30;
            HomeDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            HomeDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "Title Note";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Category Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Reminder Date";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Last Date";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = HomeDataGrid;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 146);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 5;
            label1.Text = "Reminder";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.DimGray;
            guna2Panel1.BorderRadius = 25;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(LogOut);
            guna2Panel1.Controls.Add(UserNameLabel);
            guna2Panel1.Controls.Add(guna2Button3);
            guna2Panel1.Controls.Add(guna2Button2);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = Color.Gainsboro;
            guna2Panel1.Location = new Point(90, -20);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(1274, 100);
            guna2Panel1.TabIndex = 6;
            // 
            // LogOut
            // 
            LogOut.AutoSize = true;
            LogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.Location = new Point(1165, 50);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(65, 21);
            LogOut.TabIndex = 4;
            LogOut.Text = "LogOut";
            LogOut.Click += LogOut_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(1044, 50);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(86, 21);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "UserName";
            // 
            // guna2Button3
            // 
            guna2Button3.BorderColor = Color.Gray;
            guna2Button3.BorderRadius = 8;
            guna2Button3.BorderThickness = 2;
            guna2Button3.CustomizableEdges = customizableEdges1;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.DarkGreen;
            guna2Button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(386, 41);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button3.Size = new Size(113, 45);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "TODO";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = Color.Gray;
            guna2Button2.BorderRadius = 8;
            guna2Button2.BorderThickness = 2;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.RoyalBlue;
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(228, 41);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(113, 45);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Category";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(64, 0, 0);
            guna2Button1.BorderRadius = 8;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.FromArgb(64, 0, 0);
            guna2Button1.Location = new Point(74, 41);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(113, 45);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Home";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1436, 743);
            Controls.Add(guna2Panel1);
            Controls.Add(label1);
            Controls.Add(HomeDataGrid);
            Name = "MainHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)HomeDataGrid).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView HomeDataGrid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label LogOut;
        private Label UserNameLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private FileSystemWatcher fileSystemWatcher1;
    }
}