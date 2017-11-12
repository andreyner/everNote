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
    public partial class NewCategoryForm : Form
    {
        public NewCategoryForm()
        {
            InitializeComponent();
        }

        public string NameCategory
        {
            get { return this.txtbheader.Text; }
        }

        private void btncreatecategory_Click(object sender, EventArgs e)
        {

        }
    }
}
