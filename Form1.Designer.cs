
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
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.lblISBNToSelect = new System.Windows.Forms.Label();
            this.btnSelectThisRecord = new System.Windows.Forms.Button();
            this.lblSelectMessage = new System.Windows.Forms.Label();
            this.txtISBNToSelect = new System.Windows.Forms.TextBox();
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.lblWhatToDo = new System.Windows.Forms.Label();
            this.tblFormFields = new System.Windows.Forms.TableLayoutPanel();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.dttmReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmboWhatToDo = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblRecordsDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDisplayBook)).BeginInit();
            this.grpEditor.SuspendLayout();
            this.grpSelect.SuspendLayout();
            this.tblFormFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdDisplayBook
            // 
            this.dtgrdDisplayBook.BackgroundColor = System.Drawing.Color.Orchid;
            this.dtgrdDisplayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdDisplayBook.Location = new System.Drawing.Point(260, 68);
            this.dtgrdDisplayBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgrdDisplayBook.Name = "dtgrdDisplayBook";
            this.dtgrdDisplayBook.Size = new System.Drawing.Size(721, 537);
            this.dtgrdDisplayBook.TabIndex = 0;
            this.dtgrdDisplayBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdDisplayBook_CellClick);
            // 
            // grpEditor
            // 
            this.grpEditor.Controls.Add(this.grpSelect);
            this.grpEditor.Controls.Add(this.lblUpdateMessage);
            this.grpEditor.Controls.Add(this.btnDeleteBook);
            this.grpEditor.Controls.Add(this.btnEditBook);
            this.grpEditor.Controls.Add(this.lblWhatToDo);
            this.grpEditor.Controls.Add(this.tblFormFields);
            this.grpEditor.Controls.Add(this.cmboWhatToDo);
            this.grpEditor.Controls.Add(this.btnAddBook);
            this.grpEditor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditor.Location = new System.Drawing.Point(14, 32);
            this.grpEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEditor.Size = new System.Drawing.Size(228, 573);
            this.grpEditor.TabIndex = 1;
            this.grpEditor.TabStop = false;
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.lblISBNToSelect);
            this.grpSelect.Controls.Add(this.btnSelectThisRecord);
            this.grpSelect.Controls.Add(this.lblSelectMessage);
            this.grpSelect.Controls.Add(this.txtISBNToSelect);
            this.grpSelect.Location = new System.Drawing.Point(15, 94);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(203, 126);
            this.grpSelect.TabIndex = 19;
            this.grpSelect.TabStop = false;
            this.grpSelect.Visible = false;
            // 
            // lblISBNToSelect
            // 
            this.lblISBNToSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblISBNToSelect.AutoSize = true;
            this.lblISBNToSelect.Location = new System.Drawing.Point(5, 62);
            this.lblISBNToSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBNToSelect.Name = "lblISBNToSelect";
            this.lblISBNToSelect.Size = new System.Drawing.Size(32, 13);
            this.lblISBNToSelect.TabIndex = 11;
            this.lblISBNToSelect.Text = "ISBN";
            // 
            // btnSelectThisRecord
            // 
            this.btnSelectThisRecord.Location = new System.Drawing.Point(55, 87);
            this.btnSelectThisRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectThisRecord.Name = "btnSelectThisRecord";
            this.btnSelectThisRecord.Size = new System.Drawing.Size(129, 24);
            this.btnSelectThisRecord.TabIndex = 16;
            this.btnSelectThisRecord.Text = "Select this Record";
            this.btnSelectThisRecord.UseVisualStyleBackColor = true;
            this.btnSelectThisRecord.Click += new System.EventHandler(this.btnSelectThisRecord_Click);
            // 
            // lblSelectMessage
            // 
            this.lblSelectMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSelectMessage.AutoSize = true;
            this.lblSelectMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSelectMessage.Location = new System.Drawing.Point(2, 8);
            this.lblSelectMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectMessage.Name = "lblSelectMessage";
            this.lblSelectMessage.Size = new System.Drawing.Size(182, 39);
            this.lblSelectMessage.TabIndex = 15;
            this.lblSelectMessage.Text = "Enter the ISBN for the record you \r\nwish to update below or select it\r\nfrom the R" +
    "ecords display grid -->";
            // 
            // txtISBNToSelect
            // 
            this.txtISBNToSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtISBNToSelect.Location = new System.Drawing.Point(45, 59);
            this.txtISBNToSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtISBNToSelect.Name = "txtISBNToSelect";
            this.txtISBNToSelect.ReadOnly = true;
            this.txtISBNToSelect.Size = new System.Drawing.Size(153, 22);
            this.txtISBNToSelect.TabIndex = 17;
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUpdateMessage.AutoSize = true;
            this.lblUpdateMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUpdateMessage.Location = new System.Drawing.Point(16, 223);
            this.lblUpdateMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Size = new System.Drawing.Size(94, 13);
            this.lblUpdateMessage.TabIndex = 18;
            this.lblUpdateMessage.Text = "Update Message";
            this.lblUpdateMessage.Visible = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(70, 520);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(88, 24);
            this.btnDeleteBook.TabIndex = 14;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Visible = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(70, 498);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(88, 24);
            this.btnEditBook.TabIndex = 13;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Visible = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // lblWhatToDo
            // 
            this.lblWhatToDo.AutoSize = true;
            this.lblWhatToDo.Location = new System.Drawing.Point(21, 36);
            this.lblWhatToDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhatToDo.Name = "lblWhatToDo";
            this.lblWhatToDo.Size = new System.Drawing.Size(151, 13);
            this.lblWhatToDo.TabIndex = 12;
            this.lblWhatToDo.Text = "What would you like to do?";
            // 
            // tblFormFields
            // 
            this.tblFormFields.ColumnCount = 1;
            this.tblFormFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormFields.Controls.Add(this.lblISBN, 0, 0);
            this.tblFormFields.Controls.Add(this.lblTitle, 0, 2);
            this.tblFormFields.Controls.Add(this.lblAuthor, 0, 4);
            this.tblFormFields.Controls.Add(this.lblReleaseDate, 0, 6);
            this.tblFormFields.Controls.Add(this.txtISBN, 0, 1);
            this.tblFormFields.Controls.Add(this.txtTitle, 0, 3);
            this.tblFormFields.Controls.Add(this.txtAuthor, 0, 5);
            this.tblFormFields.Controls.Add(this.dttmReleaseDate, 0, 7);
            this.tblFormFields.Location = new System.Drawing.Point(15, 288);
            this.tblFormFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblFormFields.Name = "tblFormFields";
            this.tblFormFields.RowCount = 8;
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblFormFields.Size = new System.Drawing.Size(199, 182);
            this.tblFormFields.TabIndex = 0;
            this.tblFormFields.Visible = false;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(83, 9);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(70, 53);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(77, 97);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(63, 141);
            this.lblReleaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(73, 13);
            this.lblReleaseDate.TabIndex = 6;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtISBN
            // 
            this.txtISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtISBN.Location = new System.Drawing.Point(4, 25);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(191, 22);
            this.txtISBN.TabIndex = 7;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(4, 69);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(191, 22);
            this.txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.Location = new System.Drawing.Point(4, 113);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(191, 22);
            this.txtAuthor.TabIndex = 9;
            // 
            // dttmReleaseDate
            // 
            this.dttmReleaseDate.CustomFormat = "dd MMMMM yyyy";
            this.dttmReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmReleaseDate.Location = new System.Drawing.Point(4, 157);
            this.dttmReleaseDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dttmReleaseDate.Name = "dttmReleaseDate";
            this.dttmReleaseDate.Size = new System.Drawing.Size(191, 22);
            this.dttmReleaseDate.TabIndex = 10;
            // 
            // cmboWhatToDo
            // 
            this.cmboWhatToDo.FormattingEnabled = true;
            this.cmboWhatToDo.Items.AddRange(new object[] {
            "Add a New Book",
            "Edit a Book",
            "Delete a Book"});
            this.cmboWhatToDo.Location = new System.Drawing.Point(22, 54);
            this.cmboWhatToDo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboWhatToDo.Name = "cmboWhatToDo";
            this.cmboWhatToDo.Size = new System.Drawing.Size(179, 21);
            this.cmboWhatToDo.TabIndex = 11;
            this.cmboWhatToDo.SelectedIndexChanged += new System.EventHandler(this.cmboWhatToDo_SelectedIndexChanged);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(70, 476);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(88, 24);
            this.btnAddBook.TabIndex = 11;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblRecordsDisplay
            // 
            this.lblRecordsDisplay.AutoSize = true;
            this.lblRecordsDisplay.Location = new System.Drawing.Point(276, 47);
            this.lblRecordsDisplay.Name = "lblRecordsDisplay";
            this.lblRecordsDisplay.Size = new System.Drawing.Size(96, 15);
            this.lblRecordsDisplay.TabIndex = 16;
            this.lblRecordsDisplay.Text = "Records Display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1000, 691);
            this.Controls.Add(this.lblRecordsDisplay);
            this.Controls.Add(this.grpEditor);
            this.Controls.Add(this.dtgrdDisplayBook);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Book Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDisplayBook)).EndInit();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.tblFormFields.ResumeLayout(false);
            this.tblFormFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdDisplayBook;
        private System.Windows.Forms.GroupBox grpEditor;
        private System.Windows.Forms.TableLayoutPanel tblFormFields;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DateTimePicker dttmReleaseDate;
        private System.Windows.Forms.Label lblWhatToDo;
        private System.Windows.Forms.ComboBox cmboWhatToDo;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblRecordsDisplay;
        private System.Windows.Forms.Label lblISBNToSelect;
        private System.Windows.Forms.Button btnSelectThisRecord;
        private System.Windows.Forms.Label lblSelectMessage;
        private System.Windows.Forms.TextBox txtISBNToSelect;
        private System.Windows.Forms.Label lblUpdateMessage;
        private System.Windows.Forms.GroupBox grpSelect;
    }
}

