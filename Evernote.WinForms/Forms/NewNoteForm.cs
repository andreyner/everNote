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
    public partial class NewNoteForm : Form
    {
        public NewNoteForm()
        {
            InitializeComponent();
        }

        public string NameNote
        {
            get { return this.txtboxNotename.Text; }
        }
        public string Contetnt
        {
            get { return this.txtboxcontent.Text; }
        }

        public int Rules
        {
            get
            {
                if (radioButtonReadandWrite.Checked)
                {
                    return 1;
                }
                if (radioButtonReadonly.Checked)
                {
                    return 0;
                }
                return -1;
            }
        }
    }
}
