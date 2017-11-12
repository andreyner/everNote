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
    public partial class ExistUserForm : Form
    {
        public ExistUserForm()
        {
            InitializeComponent();
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
