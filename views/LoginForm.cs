using Produccion808xHz.presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Produccion808xHz.views
{
    public partial class LoginForm : Form, ILoginView
    {
        private readonly LoginPresenter _presenter;
        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);
        }

        public string User => (txtUserName.Text ?? string.Empty).Trim() == "Ingresa tu usuario" ? string.Empty : (txtUserName.Text ?? string.Empty).Trim();

        public string Password
        {
            get
            {
                var p = (txtPassword.Text ?? string.Empty);
                if (p == "Introduce tu contraseña")
                    return string.Empty;
                return p.Trim();
            }
        }

        public event EventHandler LoginClicked;

    
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public new void Close()
        {
            base.Close();
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Ingresa tu usuario")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = "Ingresa tu usuario";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Introduce tu contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '●';
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Introduce tu contraseña";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
