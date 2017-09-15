using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public void Inizalization()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\User\Desktop\net\Task3\database.txt");
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                dataGridView1.Rows.Add(words[0], words[1], words[2], words[3], words[4]);

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender="";
            string text;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                string message = "Check all your spaces";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;


                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {


                   

                }
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text, gender);
                text = textBox1.Text + " " + textBox2.Text + " " + comboBox1.Text + " " + textBox3.Text + " " + gender;
                using (System.IO.StreamWriter file =

                    new System.IO.StreamWriter(@"C:\Users\User\Desktop\net\Task3\database.txt", true))
                {
                    file.WriteLine(text);
                }
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void rdBtn(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
            }
            else radioButton1.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inizalization();
        }
    }
}
