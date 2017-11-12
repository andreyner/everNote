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
        public SharesMeForm(IEnumerable<Note> notes, ServiceClient _serviceClient)
        {
            InitializeComponent();
            dataGshares.DataSource = notes;
            this._serviceClient = _serviceClient;
        }
        private ServiceClient _serviceClient;
        private void dataGshares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGshares.SelectedRows.Count > 0)
            {
                Guid noteid = Guid.Parse(dataGshares.SelectedRows[0].Cells["Id"].Value.ToString());
                Note note = _serviceClient.GetNote(noteid);
                using (var form = new ShowShareNoteForm((note)))
                {
                    form.ShowDialog();
                   
                }
            }
        }
    }
}
