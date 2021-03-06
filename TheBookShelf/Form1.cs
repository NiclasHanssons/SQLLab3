﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
namespace TheBookShelf
{
    public partial class Form1 : Form
    {
        public int numberOfBook;
        public UserControlTreeView treeView;
        public event EventHandler UpdateTreeView;

        public Form1()
        {
            InitializeComponent();

            DataGridViewBooks dataGridViewBooks = new DataGridViewBooks();
            splitContainer2.Panel2.Controls.Add(dataGridViewBooks);
            dataGridViewBooks.Dock = DockStyle.Fill;

            treeView = new UserControlTreeView(dataGridViewBooks.dataGridViewBooksPanel2, textBoxAdress, textBoxStad, textBoxLand, textBoxButikID, comboBoxBookForLagersaldo, this);
            splitContainer1.Panel1.Controls.Add(treeView);
            treeView.Dock = DockStyle.Fill;

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxButikID.Text == "")
            {
                MessageBox.Show("Vänlig välj en butik.", "Ingen butik vald");
                return;
            }

            if (textBoxAmount.Text.Length == 0)
            {
                MessageBox.Show("Vänlig ange antal böcker.", "Felaktigt antal");
                return;
            }

            if (comboBoxBookForLagersaldo.SelectedItem == null)
            {
                MessageBox.Show("Vänlig välj en bok.", "Ingen bok vald");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxAmount.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Vänligen använd endast siffror", "Felaktig inmatning");
                return;
            }

            using var db = new TheBookShelfContext();
            if (db.Database.CanConnect())
            {
                var book = comboBoxBookForLagersaldo.SelectedItem as Böcker;

                foreach (var bookSaldo in db.LagerSaldos)
                {
                    if (bookSaldo.ButikId == int.Parse(textBoxButikID.Text) && book.Isbn == bookSaldo.Isbn && System.Text.RegularExpressions.Regex.IsMatch(textBoxAmount.Text, "^[0-9]*$"))
                    {
                        bookSaldo.Antal += int.Parse(textBoxAmount.Text);
                    }
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxAmount.Text, "^[0-9]*$"))
                {
                    MessageBox.Show("Vänligen använd endast siffror", "Felaktig inmatning");
                }

                db.SaveChanges();
                MessageBox.Show($"Du har laggt till {textBoxAmount.Text}st av {book.Titel}.", "Lagersaldo uppdaterat");
                textBoxAmount.Text = "";
                UpdateTreeView?.Invoke(this, null);
            }

            else
            {
                Debug.WriteLine("Connection failed!");
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (textBoxButikID.Text == "")
            {
                MessageBox.Show("Vänlig välj en butik.", "Ingen butik vald");
                return;
            }

            if (textBoxAmount.Text.Length == 0)
            {
                MessageBox.Show("Vänlig ange antal böcker.", "Felaktigt antal");
                return;
            }

            if (comboBoxBookForLagersaldo.SelectedItem == null)
            {
                MessageBox.Show("Vänlig välj en bok.", "Ingen bok vald");
                return;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxAmount.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Vänligen använd endast siffror", "Felaktig inmatning");
                return;
            }

            using var db = new TheBookShelfContext();
            if (db.Database.CanConnect())
            {
                var book = comboBoxBookForLagersaldo.SelectedItem as Böcker;

                foreach (var bookSaldo in db.LagerSaldos)
                {
                    if (bookSaldo.ButikId == int.Parse(textBoxButikID.Text) && book.Isbn == bookSaldo.Isbn)
                    {
                        if (Int32.Parse(textBoxAmount.Text) > bookSaldo.Antal)
                        {
                            MessageBox.Show("Du kan inte ta bort fler böcker än vad som finns i lager. Vänligen ändra antal.", "Felaktig inmatning");
                            return;
                        }
                    }

                    if (bookSaldo.ButikId == int.Parse(textBoxButikID.Text) && book.Isbn == bookSaldo.Isbn && System.Text.RegularExpressions.Regex.IsMatch(textBoxAmount.Text, "^[0-9]*$"))
                    {
                        if (bookSaldo.Antal == int.Parse(textBoxAmount.Text) || bookSaldo.Antal > int.Parse(textBoxAmount.Text))
                        {
                            bookSaldo.Antal -= int.Parse(textBoxAmount.Text);
                        }
                    }
                }

                db.SaveChanges();
                MessageBox.Show($"Du har tagit bort {textBoxAmount.Text}st av {book.Titel}.", "Lagersaldo uppdaterat");
                textBoxAmount.Text = "";
                UpdateTreeView?.Invoke(this, null);
            }

            else
            {
                Debug.WriteLine("Connection failed!");
            }
        }

        private void ButtonAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm authorFormAdd = new AddAuthorForm(UpdateTreeView);
            authorFormAdd.ShowDialog();
        }

        private void ButtonEditRemoveAuthor_Click(object sender, EventArgs e)
        {
            EditRemoveAuthorForm authorFormEditRemove = new EditRemoveAuthorForm(UpdateTreeView);
            authorFormEditRemove.ShowDialog();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewBookForm addNewBook = new AddNewBookForm(UpdateTreeView);
            addNewBook.ShowDialog();
        }

        private void buttonAddBookToDB_Click(object sender, EventArgs e)
        {
            AddNewBookDBForm addNewBookToDB = new AddNewBookDBForm(UpdateTreeView);
            addNewBookToDB.ShowDialog();
        }

        private void buttonEditRemoveBook_Click(object sender, EventArgs e)
        {
            EditRemoveBookForm bookFormEditRemove = new EditRemoveBookForm(UpdateTreeView);
            bookFormEditRemove.ShowDialog();
        }
    }
}

