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
        public AllUsersForm(IEnumerable<User> users)
        {
            InitializeComponent();
            this.dGridUsers.DataSource = users;
            this.dGridUsers.ClearSelection();
        }

        private void btnSharedNote_Click(object sender, EventArgs e)
        {
            if (dGridUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show($"Выберите пользователя", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Guid UserId
        {
            get
            {
                return Guid.Parse(dGridUsers.SelectedRows[0].Cells["Id"].Value.ToString());
            }
        }
    }
}
