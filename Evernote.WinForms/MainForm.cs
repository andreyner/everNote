using Evernote.Model;
using Evernote.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evernote.WinForms
{
    public partial class MainWindows : Form
    {

        public MainWindows(User user, ServiceClient _serviceClient)
        {
            InitializeComponent();
            this.user = user;
            this._serviceClient = _serviceClient;
        }

        User user;
        IEnumerable<Note> notes;
        private ServiceClient _serviceClient;

        private void MainWindows_Load(object sender, EventArgs e)
        {

            LVNoteUpdate();
            LVCategoryUpdate();
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            using (var form = new NewCategoryForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _serviceClient.CreateCategory(new Category
                    {
                        Name = form.NameCategory,


                    }, user.Id);
                    LVCategoryUpdate();
                    MessageBox.Show($"Категория {form.NameCategory} успешно создана", "Категория", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void LVCategoryUpdate()
        {
            user.Categories = _serviceClient.GetUserCategories(user.Id);
            dataGcategories.DataSource = null;
            if (user.Categories != null)
            {
                dataGcategories.DataSource = user.Categories;
            }
        }
        void LVNoteUpdate()
        {

            notes = _serviceClient.GetUserNotes(user.Id);
            dataGNotes.DataSource = null;
            if (notes != null)
            {
                dataGNotes.DataSource = notes;
            }
        }

        private void btnaddNote_Click(object sender, EventArgs e)
        {
            using (var form = new NewNoteForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _serviceClient.CreateNote(new Note
                    {
                        header = form.NameNote,
                        text = form.Contetnt,
                        Owner = user,
                        Changed = DateTime.Now,
                        Created = DateTime.Now


                    });
                    LVNoteUpdate();
                    MessageBox.Show($"Заметка {form.NameNote} успешно создана", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnShowallNote_Click(object sender, EventArgs e)
        {
            LVNoteUpdate();
        }

        private void btndellNote_Click(object sender, EventArgs e)
        {
            if (dataGNotes.SelectedRows.Count > 0)
            {
                Guid noteid = Guid.Parse(dataGNotes.SelectedRows[0].Cells["idnote"].Value.ToString());
                _serviceClient.DeleteNote(noteid);
                MessageBox.Show($"Заметка успешно удалена", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LVNoteUpdate();
            }




        }

        private void btnAddNoteMenu_Click(object sender, EventArgs e)
        {
            btnaddNote_Click(sender, e);
        }

        private void btnchangenote_Click(object sender, EventArgs e)
        {
            if (dataGNotes.SelectedRows.Count > 0)
            {
                Guid noteid = Guid.Parse(dataGNotes.SelectedRows[0].Cells["idnote"].Value.ToString());
                Note note = _serviceClient.GetNote(noteid);
                using (var form = new EditNoteForm((note)))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _serviceClient.UpdateNote(new Note
                        {
                            Id = noteid,
                            header = form.NameNote,
                            text = form.Contetnt,
                            Owner = user,
                            Changed = DateTime.Now,
                            Created = note.Changed


                        });
                        LVNoteUpdate();
                    }
                }
            }
        }

        private void btnaddintoCategory_Click(object sender, EventArgs e)
        {
            if (dataGNotes.SelectedRows.Count > 0)
            {
                Guid selectednoteid = Guid.Parse(dataGNotes.SelectedRows[0].Cells["idnote"].Value.ToString());
                Note selectedNote = _serviceClient.GetNote(selectednoteid);
                //IEnumerable<Category> categoriesofuser = _serviceClient.GetUserCategories(user.Id);
                //IEnumerable<Category> categoriesofnote = _serviceClient.GetCategoriesofNote(selectedNote.Id);
                IEnumerable<Category> categoriesofnote = _serviceClient.GetfreeCategoriesofNote(selectedNote.Id);


                //using (var form = new AllCategoriesofUserForm(categoriesofuser.Except(categoriesofnote)))
                using (var form = new AllCategoriesofUserForm(categoriesofnote))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _serviceClient.GetNotesofCategory(form.CategoryId);
                        _serviceClient.AddNoteIntoCategory(form.CategoryId, selectedNote);
                        MessageBox.Show($"Заметка добавлена", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if (dataGNotes.SelectedRows.Count > 0)
            {
                Guid selectednoteid = Guid.Parse(dataGNotes.SelectedRows[0].Cells["idnote"].Value.ToString());
                IEnumerable<User> users = _serviceClient.GetAllUsersexpectedMe(user.Id);
                using (var form = new AllUsersForm(users))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (_serviceClient.GetSharesofUser(form.UserId).Select(note => note.Id).Contains(selectednoteid))
                        {
                            MessageBox.Show($"Заметка ранее уже была отаправлена данному пользователю", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        _serviceClient.CreatShare
                            (
                            new Share
                            {
                                DestinationUserId = form.UserId,
                                SharedNoteId = selectednoteid

                            }

                            );
                        MessageBox.Show($"Заметка отаправлена", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnshareNote_Click(object sender, EventArgs e)
        {
            btnShare_Click(sender, e);
        }

        private void btnNoteMe_Click(object sender, EventArgs e)
        {

            IEnumerable<Note> notes = _serviceClient.GetShareMe(user.Id);
            using (var form = new SharesMeForm(notes, _serviceClient))
            {
                form.ShowDialog();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.Close();

        }

        private void dataGcategories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGcategories.SelectedRows.Count > 0)
            {

                notes = _serviceClient.GetNotesofCategory(user.Categories.Select(category => category.Id).
                Where(categotyid => categotyid == Guid.Parse(dataGcategories.SelectedRows[0].Cells["Id"].Value.ToString())).Single());

                dataGNotes.DataSource = null;
                if (notes != null)
                {
                    dataGNotes.DataSource = notes;
                }
            }
        }

        private void btnShowAllNotes_Click(object sender, EventArgs e)
        {
            LVNoteUpdate();
        }

        private void btnaddnewCategory_Click(object sender, EventArgs e)
        {
            btnaddcategory_Click(sender, e);
        }

        private void btndellCategory_Click(object sender, EventArgs e)
        {
            if (dataGcategories.SelectedRows.Count > 0)
            {
                Guid categoryid = Guid.Parse(dataGcategories.SelectedRows[0].Cells["Id"].Value.ToString());
                _serviceClient.DellCategory(categoryid);
                MessageBox.Show($"Категория удалена", "Категория", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LVCategoryUpdate();
            }
        }

        private void brnRenameCategory_Click(object sender, EventArgs e)
        {
            if (dataGcategories.SelectedRows.Count > 0)
            {
                Guid categotyid = Guid.Parse(dataGcategories.SelectedRows[0].Cells["Id"].Value.ToString());
                Category category=_serviceClient.GetCategory(categotyid);
                using (var form = new EditCategoryForm(category))
                {
                   
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _serviceClient.CategoryUpdate(new Category
                        {
                            Id = category.Id,
                            Name = form.CategoryName
                        });
                        LVCategoryUpdate();
                        MessageBox.Show($"Изменения сохранены", "Изменения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dataGNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGNotes.SelectedRows.Count > 0)
            {
                Guid noteid = Guid.Parse(dataGNotes.SelectedRows[0].Cells["idnote"].Value.ToString());
                Note note = _serviceClient.GetNote(noteid);
                using (var form = new ShowNoteForm((note)))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _serviceClient.UpdateNote(new Note
                        {
                            Id = noteid,
                            header = form.NameNote,
                            text = form.Contetnt,
                            Owner = user,
                            Changed = DateTime.Now,
                            Created = note.Changed

                            
                    });
                        LVNoteUpdate();
                    }
                }
            }
        }

        private void btnUserdataShow_Click(object sender, EventArgs e)
        {
           
            using (var form = new InfoUserForm(user))
            {

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _serviceClient.UpdateUser(new User
                    {  Id=user.Id,
                       FirstName=form.FirstName,
                       LastName=form.LastName,
                       Login=form.Login,
                       Password=form.Password
                    });
                    LVCategoryUpdate();
                    MessageBox.Show($"Изменения сохранены", "Изменения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
