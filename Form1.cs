using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_BookManagementSystem
{
    public partial class Form1 : Form
    {
        BookRepo bookRepo;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bookRepo = new BookRepo();
            dtgrdDisplayBook.DataSource = bookRepo.GetAllRecords();
        }

        private void cmboWhatToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmboWhatToDo.Text)
            {
                case "Add a New Book":
                    grpSelect.Visible = false;
                    lblUpdateMessage.Text = "Please enter the book info\nbelow and then click\nthe Add Book button";
                    tblFormFields.Enabled = true;
                    tblFormFields.Visible = true;
                    btnAddBook.Visible = true;
                    btnEditBook.Visible = false;
                    btnDeleteBook.Visible = false;
                    break;
                case "Edit a Book":
                    grpSelect.Visible = true;
                    lblSelectMessage.Text = "Select the ISBN for the record you \nwish to update from the \nRecords Display grid -->";
                    btnSelectThisRecord.Text = "Edit this Record";
                    MakeBottomInvisible();
                    break;
                case "Delete a Book":
                    grpSelect.Visible = true;
                    lblSelectMessage.Text = "Select the ISBN for the record you \nwish to delete from the \nRecords Display grid -->";
                    btnSelectThisRecord.Text = "Delete this Record";
                    MakeBottomInvisible();
                    break;
            }
        }

        void MakeBottomInvisible()
        {
            lblUpdateMessage.Visible = false;
            tblFormFields.Visible = false;
            btnAddBook.Visible = false;
            btnEditBook.Visible = false;
            btnDeleteBook.Visible = false;
        }

        private void dtgrdDisplayBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtISBNToSelect.Text = dtgrdDisplayBook.CurrentRow.Cells[0].Value.ToString();
            txtISBN.Text = dtgrdDisplayBook.CurrentRow.Cells[0].Value.ToString();
            txtTitle.Text = dtgrdDisplayBook.CurrentRow.Cells[1].Value.ToString();
            txtAuthor.Text = dtgrdDisplayBook.CurrentRow.Cells[2].Value.ToString();
            dttmReleaseDate.Value = (DateTime)dtgrdDisplayBook.CurrentRow.Cells[3].Value;
        }

        private void btnSelectThisRecord_Click(object sender, EventArgs e)
        {
            if (!bookRepo.ISBNInDatabase(Int64.Parse(txtISBNToSelect.Text)))
            {
                MessageBox.Show("This ISBN is not in your records. Please select again from grid");
                txtISBNToSelect.Clear();
            }
            else 
            {
                switch (cmboWhatToDo.Text)
                {
                    case "Edit a Book":
                        lblUpdateMessage.Text = "Below is the record you selected.\nEdit the fields that need to\nbe updated and then click the \nEdit Book button";
                        lblUpdateMessage.Visible = true;
                        tblFormFields.Enabled = true;
                        tblFormFields.Visible = true;
                        btnEditBook.Visible = true;
                        break;
                    case "Delete a Book":
                        lblUpdateMessage.Text = "Below is the record you selected.\nIf you are sure you want to\ndelete this record, then click the \nDelete Book button";
                        lblUpdateMessage.Visible = true;
                        tblFormFields.Enabled = false;
                        tblFormFields.Visible = true;
                        btnDeleteBook.Visible = true;
                        break;
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text) && !string.IsNullOrEmpty(txtTitle.Text) && 
                !string.IsNullOrEmpty(txtAuthor.Text))
            {
                if (bookRepo.ISBNInDatabase(Int64.Parse(txtISBN.Text)))
                {
                    MessageBox.Show("Cannot add this record. A record with this ISBN already exists.");
                    txtISBN.Clear();
                }
                else
                {
                    Book bookToAdd = new Book();
                    bookToAdd.ISBN = Int64.Parse(txtISBN.Text);
                    bookToAdd.Title = txtTitle.Text;
                    bookToAdd.Author = txtAuthor.Text;
                    bookToAdd.ReleaseDate = (DateTime)dttmReleaseDate.Value.Date;
                    bookRepo.AddRecord(bookToAdd);
                    MessageBox.Show("Record Added");
                    dtgrdDisplayBook.DataSource = null;
                    dtgrdDisplayBook.DataSource = bookRepo.GetAllRecords();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled");
            }
        }

        void ClearFields()
        {
            txtISBN.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            dttmReleaseDate.Value = DateTime.Today;
        }
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text) && !string.IsNullOrEmpty(txtTitle.Text) &&
                            !string.IsNullOrEmpty(txtAuthor.Text))
            {
                Book bookToEdit = bookRepo.FindRecord(Int64.Parse(txtISBNToSelect.Text));
                bookToEdit.ISBN = Int64.Parse(txtISBN.Text);
                bookToEdit.Title = txtTitle.Text;
                bookToEdit.Author = txtAuthor.Text;
                bookToEdit.ReleaseDate = (DateTime)dttmReleaseDate.Value;
                bookRepo.UpdateRecord(Int64.Parse(txtISBNToSelect.Text), bookToEdit);
                dtgrdDisplayBook.DataSource = null;
                dtgrdDisplayBook.DataSource = bookRepo.GetAllRecords();
            }
            else
            {
                MessageBox.Show("All fields must be filled");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("Nothing was selected or typed on the VIN to be deleted.");
            }
            else if (!bookRepo.ISBNInDatabase(Int64.Parse(txtISBN.Text)))
            {
                MessageBox.Show("A record with this ISBN does not exist. It may have already been deleted.");
            }
            else
            {
                bookRepo.DeleteRecord(bookRepo.FindRecord(Int64.Parse(txtISBN.Text)));
                MessageBox.Show("Record deleted");
                btnDeleteBook.Visible = false;
                lblUpdateMessage.Visible = false;
                tblFormFields.Visible = false;
                dtgrdDisplayBook.DataSource = null;
                dtgrdDisplayBook.DataSource = bookRepo.GetAllRecords();
            }
        }


        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text))
            {
                long temp;
                bool parsed = Int64.TryParse(txtISBN.Text, out temp);
                if (parsed == false)
                {
                    MessageBox.Show("ISBN must be a whole number. Please try again.");
                    txtISBN.Clear();
                }
                else if (temp <= 0)
                {
                    MessageBox.Show("ISBN cannot be negative or zero. Please enter a positive whole number");
                    txtISBN.Clear();
                }
            }
        }
    }
}
