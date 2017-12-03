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
            this._serviceClient = _serviceClient;
            InitializeComponent();
            dataGshares.DataSource = notes.Select(note =>
            {
                return new SharetoMeView
                {
                    Id = note.Id,
                    Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                    header = note.header,
                    content = note.text,
                    Created = note.Created,
                    Changed = note.Changed
                };
            }).ToList();
            

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

                    Guid noteid = ((SharetoMeView)dataGshares.Rows[dataGshares.CurrentRow.Index].DataBoundItem).Id;
                    Note note = _serviceClient.GetNote(noteid);
                    using (var form = new ShowShareNoteForm((note)))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            if ((form.rules != note.rules || form.header != note.header || form.content != note.text) && note.rules != 1 && note.Owner.Id != userid)
                            {
                                MessageBox.Show("У вас нет прав на изменнение этой заметки!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (((form.rules != note.rules || form.header != note.header || form.content != note.text) && note.rules == 1 && note.Owner.Id != userid))
                                {
                                    _serviceClient.UpdateNote
                                        (
                                        new Note
                                        {
                                            Id = note.Id,
                                            header = form.header,
                                            text = form.content,
                                            rules = note.rules,
                                            Changed = DateTime.Now

                                        }

                                        );
                                    btnupdateDGShare_Click(sender, e);
                                }
                                else
                                {
                                    if (((form.rules != note.rules || form.header != note.header || form.content != note.text) && note.Owner.Id == userid))
                                    {
                                        _serviceClient.UpdateNote
                                        (
                                        new Note
                                        {
                                            Id = note.Id,
                                            header = form.header,
                                            text = form.content,
                                            rules = form.rules,
                                            Changed = DateTime.Now

                                        }

                                        );
                                        btnupdateDGShare_Click(sender, e);
                                    }

                                }
                            }
                        }

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

                if (chboxnotoMe.Checked)
                {
                    dataGshares.Columns["OwnerofNote"].HeaderText = "От кого";
                    chboxnotoMe_CheckedChanged(sender, e);
                }
                if (chboxnotefromMe.Checked)
                {
                    dataGshares.Columns["OwnerofNote"].HeaderText = "Кому";
                    chboxnotefromMe_CheckedChanged(sender, e);
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
                            content = note.text,
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
                            content = note.text,
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
            btnupdateDGShare_Click(sender, e);
            dataGshares.ClearSelection();
        }

        private void shareMeViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btndeleteshare_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGshares.SelectedRows.Count > 0)
                {
                    Guid useridtenp = userid;

                    Guid noteid = ((SharetoMeView)dataGshares.Rows[dataGshares.CurrentRow.Index].DataBoundItem).Id;
                    if (chboxnotoMe.Checked)
                    {
                        useridtenp = userid;
                    }
                    if (chboxnotefromMe.Checked)
                    {
                        IEnumerable<Note> notes1 = _serviceClient.GetSharesfromMe(userid);
                        Note note = notes1.Where(guid => guid.Id == noteid).Single();
                        useridtenp = note.Owner.Id;
                    }
                    _serviceClient.DellShare(new Share
                    {
                        DestinationUserId = useridtenp,
                        SharedNoteId = noteid

                    });

                    btnupdateDGShare_Click(sender, e);

                }
            }
            catch
            {

            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {

            try
            {
                string find = txtbfind.Text.Trim();
                if (find != "")
                {
                    if (chboxnotefromMe.Checked)
                    {
                        dataGshares.DataSource = _serviceClient.GetSharesfromMe(userid).Where(note => ((note.header.Contains(find)) || (note.text.Contains(find) || (note.Changed.ToString().Contains(find) || (note.Owner.FirstName.Contains(find)) || (note.Owner.LastName.Contains(find)))))).Select(note =>
                                 {
                                     return new SharetoMeView
                                     {
                                         Id = note.Id,
                                         Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                                         header = note.header,
                                         content = note.text,
                                         Created = note.Created,
                                         Changed = note.Changed
                                     };
                                 }).ToList();
                    }
                    if (chboxnotoMe.Checked)
                    {
                        dataGshares.DataSource = _serviceClient.GetSharestoMe(userid).Where(note => ((note.header.Contains(find)) || (note.text.Contains(find) || (note.Changed.ToString().Contains(find) || (note.Owner.FirstName.Contains(find)) || (note.Owner.LastName.Contains(find)))))).Select(note =>
                        {
                            return new SharetoMeView
                            {
                                Id = note.Id,
                                Owner = note.Owner.FirstName + " " + note.Owner.LastName,
                                header = note.header,
                                content = note.text,
                                Created = note.Created,
                                Changed = note.Changed
                            };
                        }).ToList();
                    }
                }
            }
            catch { }
        }
    }
}
