namespace ToDo.Forms
{
    partial class CategoryForm
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
            CategoryDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            categoryId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            show = new DataGridViewButtonColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            AddCategory = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            LogOut = new Label();
            UserNameLabel = new Label();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGrid).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CategoryDataGrid
            // 
            CategoryDataGrid.AllowUserToAddRows = false;
            CategoryDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            CategoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CategoryDataGrid.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CategoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CategoryDataGrid.ColumnHeadersHeight = 25;
            CategoryDataGrid.Columns.AddRange(new DataGridViewColumn[] { categoryId, Column1, Column2, show, edit, delete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            CategoryDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            CategoryDataGrid.GridColor = Color.Gray;
            CategoryDataGrid.Location = new Point(89, 283);
            CategoryDataGrid.Name = "CategoryDataGrid";
            CategoryDataGrid.ReadOnly = true;
            CategoryDataGrid.RowHeadersVisible = false;
            CategoryDataGrid.RowTemplate.Height = 30;
            CategoryDataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
            CategoryDataGrid.Size = new Size(1274, 367);
            CategoryDataGrid.TabIndex = 4;
            CategoryDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CategoryDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            CategoryDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CategoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CategoryDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CategoryDataGrid.ThemeStyle.BackColor = Color.White;
            CategoryDataGrid.ThemeStyle.GridColor = Color.Gray;
            CategoryDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 128, 0);
            CategoryDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CategoryDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            CategoryDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CategoryDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoryDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            CategoryDataGrid.ThemeStyle.ReadOnly = true;
            CategoryDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            CategoryDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CategoryDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CategoryDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CategoryDataGrid.ThemeStyle.RowsStyle.Height = 30;
            CategoryDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CategoryDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CategoryDataGrid.CellContentClick += CategoryDataGrid_CellContentClick;
            // 
            // categoryId
            // 
            categoryId.HeaderText = "categoryId";
            categoryId.Name = "categoryId";
            categoryId.ReadOnly = true;
            categoryId.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Category";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Number Notes";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
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
            show.HeaderText = "Show";
            show.Name = "show";
            show.ReadOnly = true;
            show.Text = "👁️ Show";
            show.UseColumnTextForButtonValue = true;
            show.Width = 56;
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
            guna2Elipse1.TargetControl = CategoryDataGrid;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 240);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 5;
            label1.Text = "Category";
            // 
            // AddCategory
            // 
            AddCategory.Anchor = AnchorStyles.Top;
            AddCategory.BorderRadius = 8;
            AddCategory.CustomizableEdges = customizableEdges1;
            AddCategory.DisabledState.BorderColor = Color.DarkGray;
            AddCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            AddCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddCategory.FillColor = Color.FromArgb(192, 64, 0);
            AddCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCategory.ForeColor = Color.White;
            AddCategory.Location = new Point(89, 154);
            AddCategory.Name = "AddCategory";
            AddCategory.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddCategory.Size = new Size(143, 45);
            AddCategory.TabIndex = 6;
            AddCategory.Text = "Add Category";
            AddCategory.Click += AddCategory_Click;
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
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.FillColor = Color.Gainsboro;
            guna2Panel1.Location = new Point(89, -18);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(1274, 100);
            guna2Panel1.TabIndex = 7;
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
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(64, 0, 0);
            guna2Button1.BorderRadius = 8;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.FromArgb(64, 0, 0);
            guna2Button1.Location = new Point(74, 41);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(113, 45);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Home";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1436, 743);
            Controls.Add(guna2Panel1);
            Controls.Add(AddCategory);
            Controls.Add(label1);
            Controls.Add(CategoryDataGrid);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)CategoryDataGrid).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView CategoryDataGrid;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button AddCategory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label LogOut;
        private Label UserNameLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn show;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}