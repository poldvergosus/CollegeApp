using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CollegeApp.Main;

namespace CollegeApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string logUser = loginField.Text;
            string passUser = passField.Text;

         
            Teacher teacher1 = new Teacher("Pasha", "Pasha", "123","Math");

            if (loginField.Text == "" || passField.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (logUser == teacher1.Login && passUser == teacher1.Password /* || logUser == teacher2.Login && passUser == teacher2.Password || logUser == teacher3.Login && passUser == teacher3.Password || logUser == teacher4.Login && passUser == teacher4.Password || logUser == teacher5.Login && passUser == teacher5.Password || logUser == teacher6.Login && passUser == teacher6.Password*/)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
