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
    public partial class ShowNoteForm : Form
    {
        public ShowNoteForm(Note note, ServiceClient _serviceClient)
        {
            InitializeComponent();
            this.txtbNoteName.Text = note.header;
            this.txtbNotetext.Text = note.text;
            this._serviceClient = _serviceClient;
            this.note = note;
            if (note.rules == 0)
            {
                radioButtonReadonly.Checked = true;
            }
            if (note.rules == 1)
            {
                radioButtonReadandWrite.Checked = true;
            }
            this.dataGridViewCategory.DataSource = _serviceClient.GetCategoriesofNote(note.Id);

          
        }
        Note note;
        private ServiceClient _serviceClient;
        public string NameNote
        {
            get { return this.txtbNoteName.Text; }
        }
        public string Contetnt
        {
            get { return this.txtbNotetext.Text; }
        }

        public int Rules
        {
            get
            {
                if (radioButtonReadonly.Checked)
                {
                    return 0;
                }
                if (radioButtonReadandWrite.Checked)
                {
                    return 1;
                }
                return -1;

            }

        }
        private void btnsavechange_Click(object sender, EventArgs e)
        {
            int rule = -1;
            if (radioButtonReadonly.Checked)
            {
                rule = 0;
            }
            if (radioButtonReadandWrite.Checked)
            {
                rule = 1;
            }
            if (NameNote != note.header || (Contetnt != note.text)||(rule!=note.rules))
            {
                _serviceClient.UpdateNote(new Note
                {
                    Id = note.Id,
                    header = NameNote,
                    text = Contetnt,
                    Owner = note.Owner,
                    Changed = DateTime.Now,
                    Created = note.Created,
                    rules= rule
                });
            }
        }

        private void ShowNoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (NameNote != note.header || (Contetnt != note.text)||(Rules!=note.rules))
                {
                   
                    if (MessageBox.Show($"Хотите сохранить изменения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _serviceClient.UpdateNote(new Note
                        {
                            Id = note.Id,
                            header = NameNote,
                            text = Contetnt,
                            Owner = note.Owner,
                            Changed = DateTime.Now,
                            Created = note.Created,
                            rules = Rules


                        });
                        this.DialogResult = DialogResult.OK;
                    }
                    else { e.Cancel = false; }
                }
                else { this.DialogResult = DialogResult.OK; }
            }
            catch { e.Cancel = false; }
            
        }

        private void btndellfromcategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCategory.SelectedRows.Count > 0)
                {
                    Guid catid = ((Category)dataGridViewCategory.Rows[dataGridViewCategory.CurrentRow.Index].DataBoundItem).Id;
                    _serviceClient.dellNotefromCategory(note.Id, catid);
                    this.dataGridViewCategory.DataSource = _serviceClient.GetCategoriesofNote(note.Id);
                }
            }
            catch { }
        }

        private void btnaddInCategory_Click(object sender, EventArgs e)
        {
            try
            {
                AllCategoriesofUserForm categoryform = new AllCategoriesofUserForm(_serviceClient,note.Id, note.Owner.Id);
                categoryform.ShowDialog();
                this.dataGridViewCategory.DataSource = _serviceClient.GetCategoriesofNote(note.Id);
            }
            catch { }
        }
    }
}
