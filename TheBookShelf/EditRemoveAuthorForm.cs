﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace TheBookShelf
{
    public partial class EditRemoveAuthorForm : Form
    {
        TheBookShelfContext db;
        public event EventHandler UpdateTreeView;

        public void UpdateAuthorsInformation()

        {
            var authors = db.Författares.ToList();

            foreach (var author in authors)
            {
                comboBoxEditRemoveAuthorSelectAuthor.Items.Add(author);
            }

            dataGridViewEditRemoveAuthor.Rows.Clear();

            foreach (var author in authors)
            {
                int rowIndex = dataGridViewEditRemoveAuthor.Rows.Add();
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["FirstName"].Value = author.Förnamn;
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["LastName"].Value = author.Efternamn;
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["DateOfBirth"].Value = author.Födelsedatum.ToString("yyyy-MM-dd");
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["Sex"].Value = author.Kön;
                dataGridViewEditRemoveAuthor.Rows[rowIndex].Cells["Nationality"].Value = author.Nationalitet;
            }
        }

        public EditRemoveAuthorForm(EventHandler updateTreeView)
        {
            InitializeComponent();
            UpdateTreeView = updateTreeView;
            db = new TheBookShelfContext();
            
            if (db.Database.CanConnect())
            {
                UpdateAuthorsInformation();
            }
        }

        private void ButtonEditRemoveAuthorRemove_Click(object sender, EventArgs e)
        {
            var authorToRemove = comboBoxEditRemoveAuthorSelectAuthor.SelectedItem as Författare;
           
            db.Remove(authorToRemove);

            comboBoxEditRemoveAuthorSelectAuthor.SelectedIndex = -1;
            db.SaveChanges();
            UpdateTreeView?.Invoke(this, null);

            comboBoxEditRemoveAuthorSelectAuthor.Items.Clear();
            dataGridViewEditRemoveAuthor.Rows.Clear();

            UpdateAuthorsInformation();
        }
    }
}