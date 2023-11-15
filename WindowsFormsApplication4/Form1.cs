using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        double rso_price = 0;
        String org = "NULL", student_type = "NULL", location;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    org = "L.I.T.S";
                    rso_price = 19.99 + 80.50;
                    location = "D:\\Lex\\Documents\\Visual Studio 2022\\Programs\\RSO Registration\\lits.jpg";
                    pictureBox1.ImageLocation = location;
                    courseItems.Items.RemoveAt(6);
                    courseItems.Items.Add("Multimedia Arts");
                    break;
                case 1:
                    org = "A.C.S.S";
                    rso_price = 25 + 99.99;
                    location = "D:\\Lex\\Documents\\Visual Studio 2022\\Programs\\RSO Registration\\acss.jpg";
                    pictureBox1.ImageLocation = location;
                    courseItems.Items.RemoveAt(6);
                    courseItems.Items.Add("Information System");
                    break;
                case 2:
                    org = "C.O.E.S.S";
                    rso_price = 39.50 + 75.50;
                    location = "D:\\Lex\\Documents\\Visual Studio 2022\\Programs\\RSO Registration\\coess.jpg";
                    pictureBox1.ImageLocation = location;

                    courseItems.Items.RemoveAt(6);
                    courseItems.Items.Add("Computer Infrastructure");
                    break;
                case 3:
                    org = "J.P.I.A";
                    rso_price = 24.99 + 49.90;
                    location = location = "D:\\Lex\\Documents\\Visual Studio 2022\\Programs\\RSO Registration\\jpia.jpg";
                    pictureBox1.ImageLocation = location;
                    courseItems.Items.RemoveAt(6);
                    courseItems.Items.Add("Management Accounting");
                    break;
                case 4:
                    org = "G.D.S.C";
                    rso_price = 19.99 + 59.90;
                    location = location = "D:\\Lex\\Documents\\Visual Studio 2022\\Programs\\RSO Registration\\gdsc.jpg";
                    pictureBox1.ImageLocation = location;
                    courseItems.Items.RemoveAt(6);
                    courseItems.Items.Add("Software Engineering");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String sn = textBox2.Text;
            String year = "NULL";
            double year_price = 0, student_type_price = 0, course_price = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    year = "1st Year";
                    year_price = 50;
                    break;
                case 1:
                    year = "2nd Year";
                    year_price = 100;
                    break;
                case 2:
                    year = "3rd Year";
                    year_price = 150;
                    break;
                case 3:
                    year = "4th Year";
                    year_price = 170;
                    break;
            }

            double total = year_price + rso_price + course_price + 205;

            if (radioButton1.Checked == true)
            {
                student_type = "Regular";
                total = total + 15;
            }
            else if (radioButton2.Checked == true)
            {
                student_type = "Scholar";
                total = total + 10;
            }
            else if (radioButton3.Checked == true)
            {
                student_type = "Student Assistant";
                total = total * 0.10;
            }

            Form2 next = new Form2();
            next.nameLabel.Text = name;
            next.SNLabel.Text = sn;
            next.YearLabel.Text = year;
            next.StudentOrgLabel.Text = org;
            next.StudentTypeLabel.Text = student_type;
            next.totalLabel.Text = total.ToString() + " php";
            next.pictureBox1.ImageLocation = location;

            String interest = "";
            if (checkBox1.Checked == true)
            {
                interest += "Programming\n";
                next.interest.Text = "" + interest;
            }
            if (checkBox2.Checked == true)
            {
                interest += "Designing\n";
                next.interest.Text = "" + interest;
            }
            if (checkBox3.Checked == true)
            {
                interest += "Networking\n";
                next.interest.Text = "" + interest;
            }
            if (checkBox4.Checked == true)
            {
                interest += "Business\n";
                next.interest.Text = "" + interest;
            }
            if (checkBox5.Checked == true)
            {
                interest += "Electronics\n";
                next.interest.Text = "" + interest;
            }


            next.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
