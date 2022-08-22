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

        private void cmboWhatToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmboWhatToDo.Text)
            {
                case "Add a New Book":
                    lblSelectMessage.Visible = false;
                    lblISBNToSelect.Visible = false;
                    txtISBNToSelect.Visible = false;
                    btnSelectThisRecord.Visible = false;
                    lblUpdateMessage.Text = "Please enter the book info\nbelow and then click\nthe Add Book button";
                    tblFormFields.Visible = true;
                    btnAddBook.Visible = true;
                    btnEditBook.Visible = false;
                    btnDeleteBook.Visible = false;
                    break;
                case "Edit a Book":
                    lblSelectMessage.Visible = true;
                    lblSelectMessage.Text = "Enter the ISBN for the record you \nwish to update below or select it \nfrom the Records Display grid -->";
                    lblISBNToSelect.Visible = true;
                    txtISBNToSelect.Visible = true;
                    btnSelectThisRecord.Visible = true;
                    btnSelectThisRecord.Text = "Edit this Record";
                    //lblUpdateMessage.Text = "Below is the record you selected.\nEdit the fields that need to\nbe updated and the click the \nEdit Book button";
                    lblUpdateMessage.Visible = false;
                    tblFormFields.Visible = false;
                    btnAddBook.Visible = false;
                    btnEditBook.Visible = false;
                    btnDeleteBook.Visible = false;
                    break;
                case "Delete a Book":
                    lblSelectMessage.Visible = true;
                    lblSelectMessage.Text = "Enter the ISBN for the record you \nwish to delete below or select it \nfrom the Records Display grid -->";
                    lblISBNToSelect.Visible = true;
                    txtISBNToSelect.Visible = true;
                    btnSelectThisRecord.Visible = true;
                    btnSelectThisRecord.Text = "Delete this Record";
                    lblUpdateMessage.Visible = false;
                    tblFormFields.Visible = false;
                    btnAddBook.Visible = false;
                    btnEditBook.Visible = false;
                    btnDeleteBook.Visible = false;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookRepo = new BookRepo();
            dtgrdDisplayBook.DataSource = bookRepo.GetAllRecords();
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
            switch (cmboWhatToDo.Text)
            {
                case "Edit a Book":
                    lblUpdateMessage.Text = "Below is the record you selected.\nEdit the fields that need to\nbe updated and then click the \nEdit Book button";
                    lblUpdateMessage.Visible = true;
                    tblFormFields.Visible = true;
                    btnEditBook.Visible = true;
                    break;
                case "Delete a Book":
                    lblUpdateMessage.Text = "Below is the record you selected.\nIf you are sure you want to\ndelete this record, then click the \nDelete Book button";
                    lblUpdateMessage.Visible = true;
                    tblFormFields.Visible = true;
                    txtISBN.Enabled = false;
                    txtTitle.Enabled = false;
                    txtAuthor.Enabled = false;
                    dttmReleaseDate.Enabled = false;
                    btnDeleteBook.Visible = true;
                    break;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtISBN.Text) && !string.IsNullOrEmpty(txtTitle.Text) && 
                !string.IsNullOrEmpty(txtAuthor.Text))
            {
                Book bookToAdd = new Book();
                bookToAdd.ISBN = Int64.Parse(txtISBN.Text);
                bookToAdd.Title = txtTitle.Text;
                bookToAdd.Author = txtAuthor.Text;
                bookToAdd.ReleaseDate = (DateTime)dttmReleaseDate.Value;
                bookRepo.AddRecord(bookToAdd);
                RefreshAddRecord();
            }
            else
            {
                MessageBox.Show("VIN, Make and Model cannot be blank.");
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                MessageBox.Show("Nothing was selected or typed on the VIN to be deleted.");
            }
            else if (!bookRepo.ISBNInDatabase(Int64.Parse(txtISBN.Text)))
            {
                MessageBox.Show("A record with this ISBN does not exist. Cannot delete.");
            }
            else
            {
                bookRepo.DeleteRecord(bookRepo.FindRecord(Int64.Parse(txtISBN.Text)));
                MessageBox.Show("Record deleted");
                txtISBN.Enabled = false;
                txtTitle.Enabled = false;
                txtAuthor.Enabled = false;
                dttmReleaseDate.Enabled = false;
                btnDeleteBook.Visible = true;
                dtgrdDisplayBook.DataSource = null;
                dtgrdDisplayBook.DataSource = bookRepo.GetAllRecords();
            }
        }

        private void txtISBNToSelect_TextChanged(object sender, EventArgs e)
        {
            lblUpdateMessage.Visible = false;
            tblFormFields.Visible = false;
            btnAddBook.Visible = false;
            btnEditBook.Visible = false;
            btnDeleteBook.Visible = false;
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
