namespace ToDo.Forms
{
    partial class NoteDetailsForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            titleNote = new Label();
            LastDate = new Label();
            remindBefore = new Label();
            content = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // guna2Button2
            // 
            guna2Button2.AutoRoundedCorners = true;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(224, 224, 224);
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.FromArgb(192, 0, 0);
            guna2Button2.Location = new Point(358, -164);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(34, 28);
            guna2Button2.TabIndex = 14;
            guna2Button2.Text = "X";
            // 
            // guna2Button3
            // 
            guna2Button3.AutoRoundedCorners = true;
            guna2Button3.CustomizableEdges = customizableEdges3;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(224, 224, 224);
            guna2Button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.FromArgb(192, 0, 0);
            guna2Button3.Location = new Point(655, 16);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button3.Size = new Size(34, 28);
            guna2Button3.TabIndex = 15;
            guna2Button3.Text = "X";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(312, 16);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(134, 30);
            label3.TabIndex = 18;
            label3.Text = "Note Details";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // titleNote
            // 
            titleNote.AutoSize = true;
            titleNote.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleNote.Location = new Point(193, 92);
            titleNote.Name = "titleNote";
            titleNote.Size = new Size(70, 17);
            titleNote.TabIndex = 19;
            titleNote.Text = "Title Note";
            // 
            // LastDate
            // 
            LastDate.AutoSize = true;
            LastDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastDate.Location = new Point(196, 133);
            LastDate.Name = "LastDate";
            LastDate.Size = new Size(67, 17);
            LastDate.TabIndex = 20;
            LastDate.Text = "Title Note";
            // 
            // remindBefore
            // 
            remindBefore.AutoSize = true;
            remindBefore.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remindBefore.Location = new Point(196, 177);
            remindBefore.Name = "remindBefore";
            remindBefore.Size = new Size(67, 17);
            remindBefore.TabIndex = 21;
            remindBefore.Text = "Title Note";
            // 
            // content
            // 
            content.Location = new Point(77, 286);
            content.Name = "content";
            content.ReadOnly = true;
            content.Size = new Size(566, 207);
            content.TabIndex = 22;
            content.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 92);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 23;
            label1.Text = "Title Note";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 133);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 24;
            label2.Text = "Last Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 177);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 25;
            label4.Text = "Reminder Date ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 266);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 26;
            label5.Text = "content";
            // 
            // NoteDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(725, 545);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(content);
            Controls.Add(remindBefore);
            Controls.Add(LastDate);
            Controls.Add(titleNote);
            Controls.Add(label3);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NoteDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Or Edit Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private RichTextBox content;
        private Label remindBefore;
        private Label LastDate;
        private Label titleNote;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}