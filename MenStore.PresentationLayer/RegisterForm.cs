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
            //IUserRepository userRepository = new UserRepository();
            //userService=new UserService();
            userService = container.Resolve<UserService>();
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
                CreateUserDTO createUserDTO = new CreateUserDTO(UsernameTXT.Text, PasswordTXT.Text, NameTXT.Text, PhoneTXT.Text, AddressTXT.Text, false);
                var checkuser = userService.Register(createUserDTO);
                if (checkuser == null)
                {
                    MessageBox.Show("user already exisit");
                }
                else
                {
                    MessageBox.Show("create user succefully");
                }
            }
            LoginForm loginFormcs = new LoginForm();
            loginFormcs.Show();
        }
    }
}
