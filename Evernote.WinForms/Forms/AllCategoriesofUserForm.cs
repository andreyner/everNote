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
        public AllCategoriesofUserForm(ServiceClient _serviceClient,Guid  noteid,Guid userid)
        {
            InitializeComponent();
            this.noteid = noteid;
            this.Userid = userid;
            this._serviceClient = _serviceClient;
        }
        IEnumerable<Category> category;
        private ServiceClient _serviceClient;
        private Guid Userid;
        private Guid noteid;
        public Guid CategoryId
        {
            get
            {
                return ((Category)dataGCategories.Rows[dataGCategories.CurrentRow.Index].DataBoundItem).Id;
            }
        }

        private void dataGCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==3 && dataGCategories.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {

                try
                {


                    if (dataGCategories.SelectedRows.Count > 0)
                    {
                        if (_serviceClient.GetfreeCategoriesofNote(noteid, Userid).Select(Categories => Categories.Id).Contains(CategoryId))
                        {
                            Note selectedNote = _serviceClient.GetNote(noteid);
                            _serviceClient.AddNoteIntoCategory(CategoryId, selectedNote);
                            dataGCategories.DataSource = _serviceClient.GetUserCategories(Userid).ToList();
                            dataGCategories.ClearSelection();
                        }
                        MessageBox.Show($"Успешно добавлено", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show($"Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void AllCategoriesofUserForm_Load(object sender, EventArgs e)
        {
            btnShowAllcategory_Click( sender, e);
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                string find = txtBfind.Text.Trim();
                if (find != "")
                {
                    dataGCategories.DataSource = _serviceClient.GetUserCategories(Userid).Where(category => category.Name.Contains(find)).ToList();
                }
                dataGCategories.ClearSelection();
            }
            catch { }
        }

        private void btnShowAllcategory_Click(object sender, EventArgs e)
        {
            try
            {
                dataGCategories.DataSource = _serviceClient.GetUserCategories(Userid).ToList();
                dataGCategories.ClearSelection();
            }
            catch { }
        }
    }
}
