﻿using Evernote.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evernote.WinForms.Forms
{
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm(Category category)
        {
            InitializeComponent();
            txtBCategoryName.Text = category.Name;
        }

        public string CategoryName
        {

            get
            {
                return txtBCategoryName.Text;
            }
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
