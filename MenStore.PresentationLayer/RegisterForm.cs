using Autofac;
using MenStore.Application.Contracts;
using MenStore.Application.Services.UserServices;
using MenStore.DTO.User;
using MenStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenStore.PresentationLayer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            container = AutoFac.Inject();
            userService = container.Resolve<IUserService>();
        }
        IContainer container;
        IUserService userService;
        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTXT.Text) || string.IsNullOrWhiteSpace(PhoneTXT.Text)
                || string.IsNullOrWhiteSpace(AddressTXT.Text) || string.IsNullOrWhiteSpace(UsernameTXT.Text)
                || string.IsNullOrWhiteSpace(PasswordTXT.Text))
                MessageBox.Show("Please fill in all fields.");
            else
            {
                string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
                bool testet = Regex.IsMatch(PasswordTXT.Text, passwordPattern);
                if (!Regex.IsMatch(PasswordTXT.Text, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.");
                }
                else
                {
                    CreateUserDTO createUserDTO = new CreateUserDTO(UsernameTXT.Text, PasswordTXT.Text, NameTXT.Text, PhoneTXT.Text, AddressTXT.Text, false);
                    var checkuser = userService.Register(createUserDTO);
                    if (checkuser == null)
                    {
                        MessageBox.Show("user already exisit");
                    }
                    else
                    {
                        MessageBox.Show("User Created Successfully");
                        LoginForm loginFormcs = new LoginForm(UsernameTXT.Text, PasswordTXT.Text);
                        loginFormcs.Show();
                    }
                }
            }

        }

        private void RegisterNow_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Visible = false;
        }
    }
}
