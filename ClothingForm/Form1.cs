using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingForm
{
    public partial class Form1 : Form
    {
        string loged_user = null;
        User[] users = new User[]{new User("123456789", "user1@example.com",
"Pass123", "John",
"Doe", "Johnny", "123-456-7890", new DateTime(1990, 5, 12)),
new User("987654321", "user2@example.com", "Secure456", "Jane",
"Smith", "Janie", "987-654-3210", new DateTime(1985, 8, 25)),
new User("951753852", "user3@example.com", "Strong789", "Alex",
"Brown", "Al", "555-666-7777", new DateTime(1998, 12, 3))};
        private string User_Check(User[] users)
        {
            string password, email;
            email = txt_email.Text;
            password = txt_pwd.Text;
            for (int i = 0; i < users.Length; i++) {
                if (password == users[i].Password && email == users[i].Email) {
                    btn_submit.Enabled = false;
                    MessageBox.Show("Welcome to your closet!");
                    return users[i].UserId;

                }
            }
            MessageBox.Show("Please enter valid email and password");
            txt_email.Text = "";
            txt_pwd.Text = "";
            return null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (btn_submit.Enabled) {
                loged_user = User_Check(users);
            }
        }
    }
}
