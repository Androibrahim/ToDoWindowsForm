namespace ToDo.Forms
{
    partial class NotesInCategoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            NotesInCategoryDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            noteId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            priority = new DataGridViewTextBoxColumn();
            createdAt = new DataGridViewTextBoxColumn();
            reminderDate = new DataGridViewTextBoxColumn();
            show = new DataGridViewButtonColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            CategoryName = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            sqliteConnection1 = new Microsoft.Data.Sqlite.SqliteConnection();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            LogOut = new Label();
            UserNameLabel = new Label();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)NotesInCategoryDataGrid).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NotesInCategoryDataGrid
            // 
            NotesInCategoryDataGrid.AllowUserToAddRows = false;
            NotesInCategoryDataGrid.AllowUserToDeleteRows = false;
            NotesInCategoryDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            NotesInCategoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            NotesInCategoryDataGrid.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            NotesInCategoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            NotesInCategoryDataGrid.ColumnHeadersHeight = 25;
            NotesInCategoryDataGrid.Columns.AddRange(new DataGridViewColumn[] { noteId, Column1, priority, createdAt, reminderDate, show, edit, delete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            NotesInCategoryDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            NotesInCategoryDataGrid.GridColor = Color.Gray;
            NotesInCategoryDataGrid.Location = new Point(52, 219);
            NotesInCategoryDataGrid.Name = "NotesInCategoryDataGrid";
            NotesInCategoryDataGrid.ReadOnly = true;
            NotesInCategoryDataGrid.RowHeadersVisible = false;
            NotesInCategoryDataGrid.RowHeadersWidth = 51;
            NotesInCategoryDataGrid.RowTemplate.Height = 30;
            NotesInCategoryDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            NotesInCategoryDataGrid.Size = new Size(1274, 361);
            NotesInCategoryDataGrid.TabIndex = 4;
            NotesInCategoryDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            NotesInCategoryDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            NotesInCategoryDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            NotesInCategoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            NotesInCategoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            NotesInCategoryDataGrid.ThemeStyle.BackColor = Color.White;
            NotesInCategoryDataGrid.ThemeStyle.GridColor = Color.Gray;
            NotesInCategoryDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            NotesInCategoryDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            NotesInCategoryDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            NotesInCategoryDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            NotesInCategoryDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            NotesInCategoryDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            NotesInCategoryDataGrid.ThemeStyle.ReadOnly = true;
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.Height = 30;
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            NotesInCategoryDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            NotesInCategoryDataGrid.CellContentClick += NotesInCategoryDataGrid_CellContentClick;
            // 
            // noteId
            // 
            noteId.HeaderText = "NoteId";
            noteId.MinimumWidth = 6;
            noteId.Name = "noteId";
            noteId.ReadOnly = true;
            noteId.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Title";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // priority
            // 
            priority.HeaderText = "Priority";
            priority.MinimumWidth = 6;
            priority.Name = "priority";
            priority.ReadOnly = true;
            // 
            // createdAt
            // 
            createdAt.HeaderText = "CreatedAt";
            createdAt.MinimumWidth = 6;
            createdAt.Name = "createdAt";
            createdAt.ReadOnly = true;
            // 
            // reminderDate
            // 
            reminderDate.HeaderText = "ReminderDate";
            reminderDate.MinimumWidth = 6;
            reminderDate.Name = "reminderDate";
            reminderDate.ReadOnly = true;
            // 
            // show
            // 
            show.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Teal;
            show.DefaultCellStyle = dataGridViewCellStyle3;
            show.FlatStyle = FlatStyle.Flat;
            show.HeaderText = "Detail";
            show.MinimumWidth = 6;
            show.Name = "show";
            show.ReadOnly = true;
            show.Resizable = DataGridViewTriState.True;
            show.SortMode = DataGridViewColumnSortMode.Automatic;
            show.Text = "👁️ Show";
            show.UseColumnTextForButtonValue = true;
            show.Width = 79;
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.RoyalBlue;
            edit.DefaultCellStyle = dataGridViewCellStyle4;
            edit.FlatStyle = FlatStyle.Flat;
            edit.HeaderText = "Edit";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Resizable = DataGridViewTriState.True;
            edit.SortMode = DataGridViewColumnSortMode.Automatic;
            edit.Text = "📝";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 63;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(192, 0, 0);
            delete.DefaultCellStyle = dataGridViewCellStyle5;
            delete.FlatStyle = FlatStyle.Flat;
            delete.HeaderText = "Delete";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "🗑️";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 83;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = NotesInCategoryDataGrid;
            // 
            // CategoryName
            // 
            CategoryName.Anchor = AnchorStyles.Top;
            CategoryName.AutoSize = true;
            CategoryName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryName.Location = new Point(580, 160);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(219, 37);
            CategoryName.TabIndex = 5;
            CategoryName.Text = "Category Name";
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top;
            guna2Button1.BorderRadius = 8;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(192, 64, 0);
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(52, 125);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(143, 45);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Add Note";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // sqliteConnection1
            // 
            sqliteConnection1.DefaultTimeout = 30;
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
            guna2Panel1.Controls.Add(guna2Button4);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.FillColor = Color.Gainsboro;
            guna2Panel1.Location = new Point(52, -17);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            guna2Button3.CustomizableEdges = customizableEdges3;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.DarkGreen;
            guna2Button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(386, 41);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.RoyalBlue;
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(228, 41);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(113, 45);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "Category";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.BorderColor = Color.FromArgb(64, 0, 0);
            guna2Button4.BorderRadius = 8;
            guna2Button4.BorderThickness = 2;
            guna2Button4.CustomizableEdges = customizableEdges7;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button4.ForeColor = Color.FromArgb(64, 0, 0);
            guna2Button4.Location = new Point(74, 41);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button4.Size = new Size(113, 45);
            guna2Button4.TabIndex = 0;
            guna2Button4.Text = "Home";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // NotesInCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 743);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Button1);
            Controls.Add(CategoryName);
            Controls.Add(NotesInCategoryDataGrid);
            Name = "NotesInCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)NotesInCategoryDataGrid).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView NotesInCategoryDataGrid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label CategoryName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Microsoft.Data.Sqlite.SqliteConnection sqliteConnection1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label LogOut;
        private Label UserNameLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private DataGridViewTextBoxColumn noteId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn priority;
        private DataGridViewTextBoxColumn createdAt;
        private DataGridViewTextBoxColumn reminderDate;
        private DataGridViewButtonColumn show;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}