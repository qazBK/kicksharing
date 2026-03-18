using kicksharing.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace kicksharing
{
    public partial class FormLogin : Form
    {
        //public User CurentUser;
        public bool IsGauste = false;

        public Models.User CurentUser;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLogin.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Введите логи и пароль", "Ощибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
     
            using (var db = new KicksharingDbContext())
            {
                var user = db.Users.Where(w => w.Email == textBoxLogin.Text && w.Pass == tbPassword.Text).FirstOrDefault();

                if (user != null)
                {
                    CurentUser = user;

                    IsGauste = false;

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Пользователь ненайден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            CurentUser = null;

            IsGauste = true;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
