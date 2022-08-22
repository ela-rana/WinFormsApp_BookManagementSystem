
namespace WinFormsApp_BookManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtgrdDisplayBook = new System.Windows.Forms.DataGridView();
            this.grpEditor = new System.Windows.Forms.GroupBox();
            this.tblFormFields = new System.Windows.Forms.TableLayoutPanel();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.tctISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmboWhatToDo = new System.Windows.Forms.ComboBox();
            this.lblWhatToDo = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDisplayBook)).BeginInit();
            this.grpEditor.SuspendLayout();
            this.tblFormFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdDisplayBook
            // 
            this.dtgrdDisplayBook.BackgroundColor = System.Drawing.Color.Orchid;
            this.dtgrdDisplayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdDisplayBook.Location = new System.Drawing.Point(223, 28);
            this.dtgrdDisplayBook.Name = "dtgrdDisplayBook";
            this.dtgrdDisplayBook.Size = new System.Drawing.Size(618, 497);
            this.dtgrdDisplayBook.TabIndex = 0;
            // 
            // grpEditor
            // 
            this.grpEditor.Controls.Add(this.btnDeleteBook);
            this.grpEditor.Controls.Add(this.btnEditBook);
            this.grpEditor.Controls.Add(this.lblWhatToDo);
            this.grpEditor.Controls.Add(this.tblFormFields);
            this.grpEditor.Controls.Add(this.cmboWhatToDo);
            this.grpEditor.Controls.Add(this.btnAddBook);
            this.grpEditor.Location = new System.Drawing.Point(12, 28);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(195, 497);
            this.grpEditor.TabIndex = 1;
            this.grpEditor.TabStop = false;
            // 
            // tblFormFields
            // 
            this.tblFormFields.ColumnCount = 1;
            this.tblFormFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormFields.Controls.Add(this.lblISBN, 0, 0);
            this.tblFormFields.Controls.Add(this.lblTitle, 0, 2);
            this.tblFormFields.Controls.Add(this.lblAuthor, 0, 4);
            this.tblFormFields.Controls.Add(this.lblReleaseDate, 0, 6);
            this.tblFormFields.Controls.Add(this.tctISBN, 0, 1);
            this.tblFormFields.Controls.Add(this.txtTitle, 0, 3);
            this.tblFormFields.Controls.Add(this.txtAuthor, 0, 5);
            this.tblFormFields.Controls.Add(this.dateTimePicker1, 0, 7);
            this.tblFormFields.Location = new System.Drawing.Point(18, 124);
            this.tblFormFields.Name = "tblFormFields";
            this.tblFormFields.RowCount = 9;
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFormFields.Size = new System.Drawing.Size(157, 179);
            this.tblFormFields.TabIndex = 0;
            this.tblFormFields.Visible = false;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(62, 6);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(51, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(59, 82);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(42, 120);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lblReleaseDate.TabIndex = 6;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // tctISBN
            // 
            this.tctISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tctISBN.Location = new System.Drawing.Point(3, 22);
            this.tctISBN.Name = "tctISBN";
            this.tctISBN.Size = new System.Drawing.Size(151, 20);
            this.tctISBN.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(3, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(151, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.Location = new System.Drawing.Point(3, 98);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(151, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cmboWhatToDo
            // 
            this.cmboWhatToDo.FormattingEnabled = true;
            this.cmboWhatToDo.Items.AddRange(new object[] {
            "Add a New Book",
            "Edit a Book",
            "Delete a Book"});
            this.cmboWhatToDo.Location = new System.Drawing.Point(19, 47);
            this.cmboWhatToDo.Name = "cmboWhatToDo";
            this.cmboWhatToDo.Size = new System.Drawing.Size(154, 21);
            this.cmboWhatToDo.TabIndex = 11;
            this.cmboWhatToDo.SelectedIndexChanged += new System.EventHandler(this.cmboWhatToDo_SelectedIndexChanged);
            // 
            // lblWhatToDo
            // 
            this.lblWhatToDo.AutoSize = true;
            this.lblWhatToDo.Location = new System.Drawing.Point(18, 31);
            this.lblWhatToDo.Name = "lblWhatToDo";
            this.lblWhatToDo.Size = new System.Drawing.Size(136, 13);
            this.lblWhatToDo.TabIndex = 12;
            this.lblWhatToDo.Text = "What would you like to do?";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(49, 321);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 21);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(49, 348);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(75, 21);
            this.btnEditBook.TabIndex = 13;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(49, 375);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 21);
            this.btnDeleteBook.TabIndex = 14;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(857, 599);
            this.Controls.Add(this.grpEditor);
            this.Controls.Add(this.dtgrdDisplayBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Book Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDisplayBook)).EndInit();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.tblFormFields.ResumeLayout(false);
            this.tblFormFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdDisplayBook;
        private System.Windows.Forms.GroupBox grpEditor;
        private System.Windows.Forms.TableLayoutPanel tblFormFields;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox tctISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblWhatToDo;
        private System.Windows.Forms.ComboBox cmboWhatToDo;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
    }
}

