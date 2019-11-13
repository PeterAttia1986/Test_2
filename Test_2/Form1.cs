using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void Clear_Form_Click(object sender, EventArgs e)
        {
            First_Name_Box.Text = String.Empty;
            Last_Name_Box.Text = String.Empty;
            Telephone_Number_Box.Text = String.Empty;
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (First_Name_Box.Text.Trim().Equals("") || Last_Name_Box.Text.Trim().Equals("") || Telephone_Number_Box.Text.Trim().Equals(""))
            {
                String message = "Please fill out all the filds";
                MessageBox.Show(message, "Required", MessageBoxButtons.OKCancel);

            }
            String fname = First_Name_Box.Text;
            String lname = Last_Name_Box.Text;
            String tel = Telephone_Number_Box.Text;
            user user = new user(fname, lname, tel);


            using (StreamWriter writeTo = new StreamWriter("users.txt", true))
            {
                writeTo.WriteLine("First Name:  {0}\n\rLast Name:  {1}\n\rTelephone Number:  {2}\n\r", fname, lname, tel);

            }

        }

        private void Count_of_users_Click(object sender, EventArgs e)
        {

            int sum = user.sum;
            String message = "The number of users is " + sum;
            MessageBox.Show(message, "Counter", MessageBoxButtons.OK);

        }

        private void Delete_users_Click(object sender, EventArgs e)
        {

            string path = "users.txt";

            try
            {

                if (File.Exists(Path.Combine(path)))
                {  
                    File.Delete(Path.Combine(path));
                }
                else Console.WriteLine("File doesn't exist");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

        }
    }
}
