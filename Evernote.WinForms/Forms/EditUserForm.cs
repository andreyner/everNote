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
    public partial class InfoUserForm : Form
    {
        public InfoUserForm(User user)
        {
            InitializeComponent();
            this.txtbfirstname.Text = user.FirstName;
            this.txtblastname.Text = user.LastName;
            this.txtblogin.Text = user.Login;
            this.txtbpassword.Text = user.Password;
        }
        public string FirstName
        {
            get { return this.txtbfirstname.Text; }
        }

        public string LastName
        {
            get { return this.txtblastname.Text; }
        }

        public string Login
        {
            get { return this.txtblogin.Text; }
        }

        public string Password
        {
            get { return this.txtbpassword.Text; }
        }
    }
}
