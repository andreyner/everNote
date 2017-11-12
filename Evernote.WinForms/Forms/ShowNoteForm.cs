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
    public partial class ShowNoteForm : Form
    {
        public ShowNoteForm(Note note)
        {
            InitializeComponent();
            this.txtbNoteName.Text = note.header;
            this.txtbNotetext.Text = note.text;
        }
        public string NameNote
        {
            get { return this.txtbNoteName.Text; }
        }
        public string Contetnt
        {
            get { return this.txtbNotetext.Text; }
        }
    }
}
