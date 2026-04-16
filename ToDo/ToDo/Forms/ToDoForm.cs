using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.global;
using ToDo.Model;

namespace ToDo.Forms
{
    public partial class ToDoForm : Form
    {
        private readonly AppDbContext _context;
        public ToDoForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            UserNameLabel.Text = CurrentUser.userName;


            LoadDataUnCompele();
            LoadDataCompele();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainHomeForm mainHomeForm = new MainHomeForm();
            mainHomeForm.Show();

            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();

            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ToDoForm toDoForm = new ToDoForm();
            toDoForm.Show();

            this.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }


        private void LoadDataUnCompele()
        {
            UnCompleteNoteDataGrid.Rows.Clear();

            var Notes = _context.Notes.Include(c => c.Category).Where(n => n.userId == CurrentUser.UserId && n.IsCompleted == false )
                .Select(n => new { noteId = n.NoteId, title = n.Title, category = n.Category.Name , priority = n.priority }).ToList();
            foreach (var note in Notes)
            {
                 UnCompleteNoteDataGrid.Rows.Add(note.noteId, note.title, note.category , note.priority);

            }
        }


        private void LoadDataCompele()
        {
            CompleteNoteDataGrid.Rows.Clear();

            var Notes = _context.Notes.Include(c => c.Category).Where(n => n.userId == CurrentUser.UserId && n.IsCompleted == true)
                .Select(n => new { title = n.Title, category = n.Category.Name, completeDate = n.CompleteDate.ToString() }).ToList();
            foreach (var note in Notes)
            {
                CompleteNoteDataGrid.Rows.Add(note.title, note.category, note.completeDate);
            }

        }

        private void UnCompleteNoteDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // تأكد إن الضغط مش على الهيدر
            if (e.RowIndex < 0) return;


            if (UnCompleteNoteDataGrid.Columns[e.ColumnIndex].Name == "complete")
            {
                int id = Convert.ToInt32(UnCompleteNoteDataGrid.Rows[e.RowIndex].Cells["noteId"].Value);
                Note? note = _context.Notes.SingleOrDefault(c => c.NoteId == id);

                if (note == null) return;
                note.IsCompleted = true;    
                note.CompleteDate = DateTime.Now;   

                _context.Notes.Update(note);    
                _context.SaveChanges();
                LoadDataUnCompele(); 
                LoadDataCompele();
            }
        }
    }
}
