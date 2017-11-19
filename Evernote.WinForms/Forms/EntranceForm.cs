using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            try
            {
                using (var form = new NewUserForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        User newuser = new User
                        {
                            FirstName = form.FirstName.Trim(),
                            LastName = form.LastName.Trim(),
                            Login = form.Login.Trim(),
                            Password = form.Password.Trim()

                        };
                        var results = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(newuser, new ValidationContext(newuser), results, true))
                        {
                            string errorlist = "";
                            foreach (var error in results)
                            {
                                errorlist += error;
                            }
                            throw new Exception(errorlist);
                        }

                        var user = _serviceClient.CreateUser(newuser);
                        MessageBox.Show($"Пользователь успешно создан", "Пользователь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    
        public User user { get; set; }
        public ServiceClient _serviceClient { get; set; }
        MainWindows MainForm;
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ExistUserForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                        var user = _serviceClient.FindUser(form.Login, form.Password);
                        this.DialogResult = DialogResult.OK;
                        this.user = user;
                        MainForm = new MainWindows(user, _serviceClient);
                        MainForm.Owner = this;
                        this.Visible = false;
                        MainForm.Show();


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.DialogResult = DialogResult.None;
                this.user = null;
            }
           
           
        }
        private void EntranceForm_Load(object sender, EventArgs e)
        {
            _serviceClient = new ServiceClient("http://localhost:55951/api/");
        }

       
    }
}