using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sqlite
{
    public partial class Form1 : Form
    {
        List<PersonModel> persons = new List<PersonModel>();
        public Form1()
        {
            InitializeComponent();
            LoadPersonList();
        }

        private void LoadPersonList()
        {
            persons = SqLiteDataAccess.LoadPersons();
            WireUpPersonList();
        }

        private void WireUpPersonList()
        {
            dataGridView1.Rows.Clear();
            foreach (PersonModel element in persons)
            {
                dataGridView1.Rows.Add(element.FirstName, element.FirstName);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPersonList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            p.FirstName = textBox1.Text;
            p.SecondName = textBox2.Text;

            SqLiteDataAccess.SavePerson(p);

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
