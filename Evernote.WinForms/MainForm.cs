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
            this.Text +=" "+ this.user.FirstName + " " + this.user.LastName;
        }

        User user;
        IEnumerable<Note> notes;
        private ServiceClient _serviceClient;
        /// <summary>
        /// Обновить список отображаемых категорий
        /// </summary>
        void CategoryUpdate()
        {
            try
            {
                user.Categories = _serviceClient.GetUserCategories(user.Id);
                dataGcategories.DataSource = null;
                if (user.Categories != null)
                {
                    dataGcategories.DataSource = user.Categories;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /// <summary>
        /// Обновить список отображаемых заметок
        /// </summary>
        void NoteUpdate()
        {
            try
            {
                if (dataGcategories.SelectedRows.Count > 0)
                {
                    dataGcategories_CellMouseClick(this, new DataGridViewCellMouseEventArgs(0, 0, 0, 0, new MouseEventArgs(new MouseButtons(), 1, 1, 1, 1)));
                    return;
                }

                notes = _serviceClient.GetUserNotes(user.Id);
                dataGNotes.DataSource = null;
                if (notes != null)
                {
                    dataGNotes.DataSource = notes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /// <summary>
        /// Обновить данные о пользователе
        /// </summary>
        void UserUpdate()
        {
            try
            {

                this.user = _serviceClient.FindUser(user.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {

            NoteUpdate();
            CategoryUpdate();
            dataGcategories.ClearSelection();
            dataGNotes.ClearSelection();
            
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new NewCategoryForm())
                {
                    form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _serviceClient.CreateCategory(new Category
                        {
                            Name = form.NameCategory,


                        }, user.Id);
                        
                        MessageBox.Show($"Категория {form.NameCategory} успешно создана", "Категория", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CategoryUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            dataGcategories.ClearSelection();
            dataGNotes.ClearSelection();

        }
  
        private void btnaddNote_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new NewNoteForm())
                {
                    form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                    if (form.ShowDialog() == DialogResult.OK)
                    {   
                        _serviceClient.CreateNote(new Note
                        {
                            header = form.NameNote,
                            text = form.Contetnt,
                            Owner = user,
                            Changed = DateTime.Now,
                            Created = DateTime.Now,
                            rules=form.Rules


                        });
                        
                        MessageBox.Show($"Заметка {form.NameNote} успешно создана", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NoteUpdate();
                        dataGNotes.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            dataGNotes.ClearSelection();
        }

        private void btnShowallNote_Click(object sender, EventArgs e)
        {
            dataGcategories.ClearSelection();
            NoteUpdate();
            dataGcategories.ClearSelection();
        }

        private void btndellNote_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGNotes.SelectedRows.Count > 0)
                {
                    Guid noteid = ((Note)dataGNotes.Rows[dataGNotes.CurrentRow.Index].DataBoundItem).Id;
                    _serviceClient.DeleteNote(noteid);
                    MessageBox.Show($"Заметка успешно удалена", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NoteUpdate();
                }

            }
            catch { }


        }

        private void btnAddNoteMenu_Click(object sender, EventArgs e)
        {
            btnaddNote_Click(sender, e);
        }

        private void btnchangenote_Click(object sender, EventArgs e)
        {
           
        }

        private void btnaddintoCategory_Click(object sender, EventArgs e)
        {
            try
            {


                if (dataGNotes.SelectedRows.Count > 0)
                {
                    Guid selectednoteid = ((Note)dataGNotes.Rows[dataGNotes.CurrentRow.Index].DataBoundItem).Id;
                    Note selectedNote = _serviceClient.GetNote(selectednoteid);
                    using (var form = new AllCategoriesofUserForm(_serviceClient, selectedNote.Id, user.Id))
                    {
                        form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                        form.ShowDialog();
                       
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGNotes.SelectedRows.Count > 0)
                {
                    
                    Guid selectednoteid = ((Note)dataGNotes.Rows[dataGNotes.CurrentRow.Index].DataBoundItem).Id;
                    IEnumerable<User> users = _serviceClient.GetAllUsersexpectedMe(user.Id);
                    using (var form = new AllUsersForm(users, _serviceClient, selectednoteid, user.Id))
                    {
                        form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                        form.ShowDialog();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Ошибка при попытке подклиться заметками!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnshareNote_Click(object sender, EventArgs e)
        {
            btnShare_Click(sender, e);
        }

        private void btnNoteMe_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Note> notes = _serviceClient.GetShareMe(user.Id);
                using (var form = new SharesMeForm(notes, _serviceClient, user.Id))
                {
                    form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                    form.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось получить заметки от других пользователей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Owner.Visible = true;
                this.Close();
            }
            catch { MessageBox.Show("Не удалось выйти из аккаунта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
        }

        private void dataGcategories_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {


                if (dataGcategories.SelectedRows.Count > 0)
                {

                    notes = _serviceClient.GetNotesofCategory(((Category)dataGcategories.Rows[dataGcategories.CurrentRow.Index].DataBoundItem).Id);
                    dataGNotes.DataSource = notes;
                    dataGNotes.ClearSelection();


                }
            }
            catch { }
        }

        private void btnShowAllNotes_Click(object sender, EventArgs e)
        {
            try
            {

                dataGcategories.ClearSelection();
                NoteUpdate();
                dataGcategories.ClearSelection();
                dataGNotes.ClearSelection();
                dataGcategories.ClearSelection();
            }
            catch { }
          
        }

        private void btnaddnewCategory_Click(object sender, EventArgs e)
        {
            btnaddcategory_Click(sender, e);
        }

        private void btndellCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGcategories.SelectedRows.Count > 0)
                {    
                    Guid categoryid =((Category) dataGcategories.Rows[dataGcategories.CurrentRow.Index].DataBoundItem).Id;
                    _serviceClient.DellCategory(categoryid);
                    MessageBox.Show($"Категория удалена", "Категория", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CategoryUpdate();
                }
            }
            catch { }
        }

        private void brnRenameCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGcategories.SelectedRows.Count > 0)
                {
                    Guid categotyid = ((Category)dataGcategories.Rows[dataGcategories.CurrentRow.Index].DataBoundItem).Id;
                    Category category = _serviceClient.GetCategory(categotyid);
                    using (var form = new EditCategoryForm(category))
                    {
                        form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _serviceClient.CategoryUpdate(new Category
                            {
                                Id = category.Id,
                                Name = form.CategoryName
                            });
                            CategoryUpdate();
                            MessageBox.Show($"Изменения сохранены", "Изменения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (category.Name != form.CategoryName)
                            {
                                if (MessageBox.Show($"Имеются несохранёные изменения.Хотите их сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    _serviceClient.CategoryUpdate(new Category
                                    {
                                        Id = category.Id,
                                        Name = form.CategoryName
                                    });
                                    CategoryUpdate();
                                }
                            }

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка при переименовании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dataGNotes.SelectedRows.Count > 0)
                {
                    Guid noteid = ((Note)dataGNotes.Rows[dataGNotes.CurrentRow.Index].DataBoundItem).Id;
                    Note note = _serviceClient.GetNote(noteid);
                    using (var form = new ShowNoteForm(note, _serviceClient))
                    {
                        form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            NoteUpdate();
                        }

                    }
                }
            }
            catch { }
        }

        private void btnUserdataShow_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new InfoUserForm(user))
                {
                    form.Text += " " + this.user.FirstName + " " + this.user.LastName;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _serviceClient.UpdateUser(new User
                        { Id = user.Id,
                            FirstName = form.FirstName,
                            LastName = form.LastName,
                            Login = form.Login,
                            Password = form.Password
                        });
                        
                        MessageBox.Show($"Изменения сохранены", "Изменения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UserUpdate();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGcategories_SelectionChanged(object sender, EventArgs e)
        {
            //dataGcategories_CellMouseClick(sender, new DataGridViewCellMouseEventArgs(0, 0, 0, 0, new MouseEventArgs(new MouseButtons(), 1, 1, 1, 1)));
        }

        private void btnaddNoteContextMenu_Click(object sender, EventArgs e)
        {
            btnAddNoteMenu_Click( sender, e);
        }

        private void btndellfromcategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGcategories.SelectedRows.Count > 0 && dataGNotes.SelectedRows.Count > 0)
                {   
                    _serviceClient.dellNotefromCategory(((Note)dataGNotes.Rows[dataGNotes.CurrentRow.Index].DataBoundItem).Id, ((Category) dataGcategories.Rows[dataGcategories.CurrentRow.Index].DataBoundItem).Id);
                     dataGcategories_SelectionChanged(sender,e);
                    NoteUpdate();
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка при удалении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                string find = txtBfind.Text.Trim();
                if (find != "")
                {   if (checkBnote.Checked)
                    {
                        dataGNotes.DataSource = null;
                        notes = _serviceClient.GetUserNotes(user.Id);
                        notes = notes.Where(note => (note.header.Contains(find) || note.text.Contains(find) || note.Changed.ToString().Contains(find)));
                        dataGNotes.DataSource = notes.ToList();
                        dataGNotes.ClearSelection();
                    }
                    if (checkBcategory.Checked)
                    {
                        dataGcategories.DataSource = null;
                        List<Category> category = _serviceClient.GetUserCategories(user.Id).ToList();
                        category = category.Where(categories => categories.Name.Contains(find)).ToList();
                        dataGcategories.DataSource = category;
                        dataGcategories.ClearSelection();
                    }
                }
            }
            catch { }

        }

        private void btnshowallcategory_Click(object sender, EventArgs e)
        {
            CategoryUpdate();
            dataGcategories.ClearSelection();
        }

        private void btnshowallcatergory_Click(object sender, EventArgs e)
        {
            CategoryUpdate();
            dataGcategories.ClearSelection();
        }

        private void btndropselectedcategory_Click(object sender, EventArgs e)
        {
            dataGcategories.ClearSelection();
        }

        private void btnclearselection_Click(object sender, EventArgs e)
        {
            dataGcategories.ClearSelection();
        }

        private void dataGcategories_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            brnRenameCategory_Click(sender, e);
        }

        private void btnnewcategory_Click(object sender, EventArgs e)
        {
            btnaddcategory_Click(sender, e);
        }
    }
}
