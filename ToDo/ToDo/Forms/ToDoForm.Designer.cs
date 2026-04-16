namespace ToDo.Forms
{
    partial class ToDoForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            UnCompleteNoteDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            noteId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            complete = new DataGridViewButtonColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            CompleteNoteDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            label2 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            LogOut = new Label();
            UserNameLabel = new Label();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)UnCompleteNoteDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompleteNoteDataGrid).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UnCompleteNoteDataGrid
            // 
            UnCompleteNoteDataGrid.AllowUserToAddRows = false;
            UnCompleteNoteDataGrid.AllowUserToDeleteRows = false;
            UnCompleteNoteDataGrid.AllowUserToResizeColumns = false;
            UnCompleteNoteDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            UnCompleteNoteDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UnCompleteNoteDataGrid.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Maroon;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UnCompleteNoteDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UnCompleteNoteDataGrid.ColumnHeadersHeight = 25;
            UnCompleteNoteDataGrid.Columns.AddRange(new DataGridViewColumn[] { noteId, Column1, Column2, Column3, complete });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            UnCompleteNoteDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            UnCompleteNoteDataGrid.GridColor = Color.Gray;
            UnCompleteNoteDataGrid.Location = new Point(52, 204);
            UnCompleteNoteDataGrid.Name = "UnCompleteNoteDataGrid";
            UnCompleteNoteDataGrid.ReadOnly = true;
            UnCompleteNoteDataGrid.RowHeadersVisible = false;
            UnCompleteNoteDataGrid.RowTemplate.Height = 30;
            UnCompleteNoteDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            UnCompleteNoteDataGrid.Size = new Size(1274, 374);
            UnCompleteNoteDataGrid.TabIndex = 4;
            UnCompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UnCompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            UnCompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UnCompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UnCompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UnCompleteNoteDataGrid.ThemeStyle.BackColor = Color.White;
            UnCompleteNoteDataGrid.ThemeStyle.GridColor = Color.Gray;
            UnCompleteNoteDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            UnCompleteNoteDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UnCompleteNoteDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            UnCompleteNoteDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UnCompleteNoteDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            UnCompleteNoteDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            UnCompleteNoteDataGrid.ThemeStyle.ReadOnly = true;
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.Height = 30;
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UnCompleteNoteDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UnCompleteNoteDataGrid.CellContentClick += UnCompleteNoteDataGrid_CellContentClick;
            // 
            // noteId
            // 
            noteId.HeaderText = "NoteId";
            noteId.Name = "noteId";
            noteId.ReadOnly = true;
            noteId.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Title";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Category";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "proirity";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // complete
            // 
            complete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Green;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Green;
            complete.DefaultCellStyle = dataGridViewCellStyle3;
            complete.FlatStyle = FlatStyle.Flat;
            complete.HeaderText = "Complete";
            complete.Name = "complete";
            complete.ReadOnly = true;
            complete.Resizable = DataGridViewTriState.True;
            complete.SortMode = DataGridViewColumnSortMode.Automatic;
            complete.Text = "✔️";
            complete.UseColumnTextForButtonValue = true;
            complete.Width = 107;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = UnCompleteNoteDataGrid;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 180);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 5;
            label1.Text = "Un Completed Note";
            // 
            // CompleteNoteDataGrid
            // 
            CompleteNoteDataGrid.AllowUserToAddRows = false;
            CompleteNoteDataGrid.AllowUserToDeleteRows = false;
            CompleteNoteDataGrid.AllowUserToResizeColumns = false;
            CompleteNoteDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            CompleteNoteDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            CompleteNoteDataGrid.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Green;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CompleteNoteDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CompleteNoteDataGrid.ColumnHeadersHeight = 25;
            CompleteNoteDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column5 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            CompleteNoteDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            CompleteNoteDataGrid.GridColor = Color.Gray;
            CompleteNoteDataGrid.Location = new Point(46, 664);
            CompleteNoteDataGrid.Name = "CompleteNoteDataGrid";
            CompleteNoteDataGrid.ReadOnly = true;
            CompleteNoteDataGrid.RowHeadersVisible = false;
            CompleteNoteDataGrid.RowTemplate.Height = 30;
            CompleteNoteDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            CompleteNoteDataGrid.Size = new Size(1274, 331);
            CompleteNoteDataGrid.TabIndex = 6;
            CompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            CompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CompleteNoteDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CompleteNoteDataGrid.ThemeStyle.BackColor = Color.White;
            CompleteNoteDataGrid.ThemeStyle.GridColor = Color.Gray;
            CompleteNoteDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            CompleteNoteDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CompleteNoteDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            CompleteNoteDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CompleteNoteDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CompleteNoteDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            CompleteNoteDataGrid.ThemeStyle.ReadOnly = true;
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.Height = 30;
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CompleteNoteDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Title";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Category";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Complete Date";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 640);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 7;
            label2.Text = "Completed Note";
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
            guna2Panel1.Location = new Point(46, -19);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(1274, 100);
            guna2Panel1.TabIndex = 8;
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
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 930);
            Controls.Add(guna2Panel1);
            Controls.Add(label2);
            Controls.Add(CompleteNoteDataGrid);
            Controls.Add(label1);
            Controls.Add(UnCompleteNoteDataGrid);
            Name = "ToDoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)UnCompleteNoteDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompleteNoteDataGrid).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView UnCompleteNoteDataGrid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView CompleteNoteDataGrid;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label LogOut;
        private Label UserNameLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridViewTextBoxColumn noteId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn complete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
    }
}