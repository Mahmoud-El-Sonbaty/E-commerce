using MenStore.Application.Services.UserServices;
using MenStore.DTO.User;
using Autofac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenStore.PresentationLayer
{
    public partial class LoginForm : Form
    {
        public LoginForm(string? comingUsername = null, string? comingPassword = null)
        {
            container = AutoFac.Inject();
            InitializeComponent();
            userService = container.Resolve<IUserService>();// UserService object that saved in userService
            //usernameToShow = comingUsername;
            //passwordToShow = comingPassword;
            UsernameTXT.Text = comingUsername ?? string.Empty;
            PasswordTXT.Text = comingPassword ?? string.Empty;

        }
        IContainer container;
        IUserService userService;
        //string? usernameToShow;
        //string? passwordToShow;
        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTXT.Text) || string.IsNullOrWhiteSpace(PasswordTXT.Text))
                MessageBox.Show("Please fill in all fields.");
            else
            {
                CheckUserDTO createUserDTO = new CheckUserDTO(UsernameTXT.Text, PasswordTXT.Text);
                var checkuser = userService.Login(createUserDTO);
                if (checkuser == null)
                {
                    MessageBox.Show("Invalid Credentials");
                }
                else
                {
                    MessageBox.Show("Welcome\n مع تحيات مستر سنباطي و أبناءه ");
                    if (checkuser.IsAdmin)
                    {
                        //dashboard form
                        var productAdmin = new ProductForAdmin(checkuser.Id);
                        productAdmin.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        //main form
                        var productAdmin = new ProductsForUser(checkuser.Id);
                        productAdmin.Show();
                        this.Visible = false;
                    }
                }

            }
        }

        private void RegisterNow_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

    }
}