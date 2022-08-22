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
        public Form1()
        {
            InitializeComponent();
        }

        private void cmboWhatToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmboWhatToDo.Text)
            {
                case "Add a New Book":
                    
                    break;
                case "Edit a Book":
                    break;
                case "Delete a Book":
                    break;
            }
        }
    }
}
