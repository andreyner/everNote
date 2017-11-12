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
    public partial class EntranceForm : Form
    {
      
        
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            progressBarIn.MarqueeAnimationSpeed = 50;
            using (var form = new NewUserForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    progressBarIn.MarqueeAnimationSpeed = 50;
                    var user = _serviceClient.CreateUser(new User
                    {
                        FirstName = form.FirstName,
                        LastName=form.LastName,
                        Login=form.Login,
                        Password=form.Password

                    });
                    MessageBox.Show($"Пользователь успешно создан", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            progressBarIn.MarqueeAnimationSpeed = 0;
        }
    
        public User user { get; set; }
        public ServiceClient _serviceClient { get; set; }
        MainWindows MainForm;
        private void btnIn_Click(object sender, EventArgs e)
        {
           
            using (var form = new ExistUserForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    progressBarIn.MarqueeAnimationSpeed = 50;
                    var user = _serviceClient.FindUser(form.Login,form.Password);
                    if (user == null)
                    {
                        MessageBox.Show($"Пользователь с такими данными не существует", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.DialogResult= DialogResult.None;
                        this.user = null;
                    }
                    else
                    {
                        progressBarIn.MarqueeAnimationSpeed = 50;
                        this.DialogResult = DialogResult.OK;
                        this.user = user;
                        MainForm = new MainWindows(user,_serviceClient);
                        MainForm.Owner = this;
                        this.Visible = false;
                        MainForm.Show();
                        
                    }
                }

            }
            progressBarIn.MarqueeAnimationSpeed = 0;
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            _serviceClient = new ServiceClient("http://localhost:55951/api/");
        }
    }
}