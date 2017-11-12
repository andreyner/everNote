using Evernote.Model;
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
    public partial class AllCategoriesofUserForm : Form
    {
        public AllCategoriesofUserForm(IEnumerable<Category>category)
        {
            InitializeComponent();
            this.category = category.ToList<Category>();
            dataGCategories.DataSource = this.category;
        }
        IEnumerable<Category> category;
        public Guid CategoryId
        {
            get
            {
                return Guid.Parse(dataGCategories.SelectedRows[0].Cells["Id"].Value.ToString());
            }
        }
    }
}
