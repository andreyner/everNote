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
    public partial class AllUsersForm : Form
    {
        public AllUsersForm(IEnumerable<User> users, ServiceClient _serviceClient,Guid noteid,Guid Iam)
        {
            InitializeComponent();
            this.dGridUsers.DataSource = users;
            this.noteid = noteid;
            this._serviceClient = _serviceClient;
            this.Iam = Iam;
            this.dGridUsers.ClearSelection();
            this.users = users;
        }
        private ServiceClient _serviceClient;
        private Guid noteid;
        private IEnumerable<User> users;
        private Guid Iam;
        public Guid UserId
        {
            get
            {
                return ((User) dGridUsers.Rows[dGridUsers.CurrentRow.Index].DataBoundItem).Id;
            }
        }

        private void dGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7 && dGridUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (_serviceClient.GetSharestoMe(UserId).Select(note => note.Id).Contains(noteid))
                    {
                        MessageBox.Show($"Заметка отаправлена", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    _serviceClient.CreatShare
                        (
                        new Share
                        {
                            DestinationUserId = UserId,
                            SharedNoteId = noteid

                        }

                        );
                    MessageBox.Show($"Заметка отаправлена", "Заметка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось поделиться заметкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

      
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string firstname = txtBfirstName.Text.Trim();
            string surnname = txtBfirstSurname.Text.Trim();
            if (firstname != "" && surnname != "")
            {
                this.dGridUsers.DataSource = null;
                this.dGridUsers.DataSource = users.Where(user => (user.FirstName.Contains(firstname)&& user.LastName.Contains(surnname))).ToList();

            }
            else
            {
                if (firstname != "")
                {
                    this.dGridUsers.DataSource = null;
                    this.dGridUsers.DataSource = users.Where(user => (user.FirstName.Contains(firstname))).ToList();

                }
                if (surnname != "")
                {
                    this.dGridUsers.DataSource = null;
                    this.dGridUsers.DataSource = users.Where(user => (user.LastName.Contains(surnname))).ToList();

                }
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {

                this.dGridUsers.DataSource = null;
                this.dGridUsers.DataSource = _serviceClient.GetAllUsersexpectedMe(Iam);
            }
            catch
            {
                MessageBox.Show($"ЗОшибка при получении заметок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            this.dGridUsers.ClearSelection();
        }
    }
}
