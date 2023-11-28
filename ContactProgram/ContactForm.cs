using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProgram
{
    public partial class ContactForm : Form
    {
        Contact c = null;
        public ContactForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            string company;
            string cellPhone;
            string tel;
            string mail;

            name = txtName.Text;
            age = int.Parse(txtAge.Text);
            company = txtCompany.Text;
            cellPhone = txtCellphone.Text;
            tel = txttel.Text;
            mail = txtMail.Text;

            c = new Contact(name, age, company, cellPhone, tel, mail);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrint.Text = c.ToString();
        }
    }
}
