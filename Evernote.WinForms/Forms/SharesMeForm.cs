using Evernote.WinForms.ViewModel;
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
    public partial class SharesMeForm : Form
    {
        public SharesMeForm(IEnumerable<Note> notes, ServiceClient _serviceClient, Guid userid)
        {
            InitializeComponent();
            dataGshares.DataSource = notes.Select(note =>
            {
                return new SharetoMeView
                {
                    Id = note.Id,
                    Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                    header = note.header,
                    Created = note.Created,
                    Changed = note.Changed
                };
            }).ToList();
            this._serviceClient = _serviceClient;
            this.userid = userid;
            dataGshares.ClearSelection();
        }
        private ServiceClient _serviceClient;
        Guid userid;
        private void dataGshares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGshares.SelectedRows.Count > 0)
                {

                    Guid noteid = ((SharetoMeView)dataGshares.SelectedRows[0].DataBoundItem).Id;
                    Note note = _serviceClient.GetNote(noteid);
                    using (var form = new ShowShareNoteForm((note)))
                    {
                        form.ShowDialog();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось получить поную информацию о заметке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnupdateDGShare_Click(object sender, EventArgs e)
        {
            try
            {
                dataGshares.DataSource = _serviceClient.GetShareMe(userid).Select(note =>
                {


                    return new SharetoMeView
                    {
                        Id = note.Id,
                        Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                        header = note.header,
                        Created = note.Created,
                        Changed = note.Changed
                    };
                }).ToList();
                if (chboxnotoMe.Checked)
                {
                    dataGshares.Columns["OwnerofNote"].HeaderText = "От кого";
                }
                if (chboxnotefromMe.Checked)
                {
                    dataGshares.Columns["OwnerofNote"].HeaderText = "Кому";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void chboxnotefromMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxnotefromMe.Checked)
            {
                try
                {
                    dataGshares.Columns["OwnerofNote"].HeaderText = "Кому";
                    dataGshares.DataSource = _serviceClient.GetSharesfromMe(userid).Select(note =>
                    {
                        return new SharetoMeView
                        {
                            Id = note.Id,
                            Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                            header = note.header,
                            Created = note.Created,
                            Changed = note.Changed
                        };
                    }).ToList();
                    dataGshares.ClearSelection();
                }
                catch 
                {
                    MessageBox.Show("Ошибка при загрузке заметок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void chboxnotoMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxnotoMe.Checked)
            {
                try
                {
                    dataGshares.Columns["OwnerofNote"].HeaderText = "От кого";
                    dataGshares.DataSource = _serviceClient.GetSharestoMe(userid).Select(note =>
                    {
                        return new SharetoMeView
                        {
                            Id = note.Id,
                            Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                            header = note.header,
                            Created = note.Created,
                            Changed = note.Changed
                        };
                    }).ToList();
                    dataGshares.ClearSelection();
                }
                catch
                {
                    MessageBox.Show("Ошибка при загрузке заметок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void SharesMeForm_Load(object sender, EventArgs e)
        {
            dataGshares.ClearSelection();
        }
    }
}
