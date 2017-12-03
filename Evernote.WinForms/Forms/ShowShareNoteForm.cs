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
    public partial class ShowShareNoteForm : Form
    {
        public ShowShareNoteForm(Note note)
        {
            InitializeComponent();
            this.txtbNoteName.Text = note.header;
            this.txtbNotetext.Text = note.text;
            if (note.rules == 0)
            {
                radioButtonReadOnly.Checked = true;
            }
            if (note.rules == 1)
            {
                radioButtonReadandWrite.Checked = true;
            }
        }

        public string header
        {
            get
            {
                return txtbNoteName.Text.Trim();
            }
        }
        public string content
        {
            get
            {
                return txtbNotetext.Text.Trim();
            }
        }

        public int rules
        {
            get
            {
                if (radioButtonReadOnly.Checked == true)
                {
                    return 0;
                }
                if (radioButtonReadandWrite.Checked == true)
                {
                    return 1;
                }
                return -1;

            }

        }
    }
}
