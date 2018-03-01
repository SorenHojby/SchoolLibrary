using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Teacher t = new Teacher();
            Student student1 = new Student();
            student1.DegreeProgram = Student.DegreePrograms.MultimediaDesign;

            ExchangeStudent ext = new ExchangeStudent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            School mySchool = new School();
            mySchool.Name = tbName.Text;
            mySchool.Address = tbAdress.Text;
            mySchool.ZipCode = int.Parse(tbZip.Text);
            mySchool.City = tbCity.Text;
            mySchool.Country = tbCountry.Text;
            mySchool.PhoneNumber = int.Parse(tbPhone.Text);
            mySchool.Website = tbWebsite.Text;
            mySchool.TwitterHandle = tbTwitter.Text;

            MessageBox.Show( mySchool.ToString() );
        }
    }
}
