using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            button3.Enabled = false;
        }

        List<string> id = new List<string>();
        List<string> name = new List<string>();
        List<string> phone = new List<string>();
        List<int> age = new List<int>();
        List<string> adress = new List<string>();
        List<double> gpa = new List<double>();
        int i = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            idtextBox.MaxLength = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            for (int j = 0; j < i; j++)
            {
                richTextBox1.AppendText(" \n");
                richTextBox1.AppendText("       student info" + (j + 1) + "      ");
                richTextBox1.AppendText("\n===============================");
                richTextBox1.AppendText("\n     student id:      " + id[j]);
                richTextBox1.AppendText("\n     student name:      " + name[j]);
                richTextBox1.AppendText("\n     student Mobile:      " + phone[j]);
                richTextBox1.AppendText("\n     student age:      " + age[j]);
                richTextBox1.AppendText("\n     student addr.:      " + adress[j]);
                richTextBox1.AppendText("\n     student GPA:      " + gpa[j]);
                richTextBox1.AppendText(" \n");
            }

            richTextBox2.AppendText(Convert.ToString(gpa.Max()));
            var ind = gpa.IndexOf(gpa.Max());
            richTextBox3.AppendText(name[ind]);
            richTextBox4.AppendText(Convert.ToString(gpa.Min()));
            var ind_min = gpa.IndexOf(gpa.Min());
            richTextBox5.AppendText(name[ind_min]);
            richTextBox7.AppendText(Convert.ToString(gpa.Sum()));
            richTextBox6.AppendText(Convert.ToString(gpa.Average()));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(idtextBox.Text) || String.IsNullOrWhiteSpace(idtextBox.Text))
            {
                MessageBox.Show("Please enter ID");
                idtextBox.Focus();
                return;

            }

            if (id.Contains(idtextBox.Text))
            {
                MessageBox.Show("ID already exists!");
                idtextBox.Focus();
                return;

            }

            if (idtextBox.Text.Length < 4)
            {
                MessageBox.Show("Invalid ID: Too short");
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter Name");
                textBox2.Focus();
                return;

            }

            if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter Mobile No.");
                textBox3.Focus();
                return;

            }

            if (textBox3.Text.Length < 11)
            {
                MessageBox.Show("Invalid number: Too short");
                return;
            }


            if (phone.Contains(textBox3.Text))
            {
                MessageBox.Show("phone number already exists!");
                textBox2.Focus();
                return;

            }

            if (String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please enter GPA ");
                textBox3.Focus();
                return;

            }

            try
            {
                age.Add(Convert.ToInt32(textBox4.Text));
            }
            catch (System.FormatException)
            {
                age.Add(0);
            }


            try
            {

                if (Convert.ToDouble(textBox6.Text) >= 0 && Convert.ToDouble(textBox6.Text) <= 4)
                {
                    try
                    {
                        gpa.Add(Convert.ToDouble(textBox6.Text));
                    }
                    catch (System.FormatException)
                    {

                        MessageBox.Show("GPA is invalid");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("GPA is invalid");
                    return;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("GPA is invalid");
                return;
            }

            id.Add(idtextBox.Text);
            name.Add(textBox2.Text);
            phone.Add(textBox3.Text);
            adress.Add(textBox5.Text);


            i++;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            button3.Enabled = true;
            idtextBox.Clear();
            idtextBox.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 30;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (radioButton1.Checked)
            {
                if (id.Contains(idtextBox.Text))
                {
                    var j = id.IndexOf(idtextBox.Text);
                    richTextBox1.AppendText(" \n");
                    richTextBox1.AppendText("       student info      ");
                    richTextBox1.AppendText("\n===============================");
                    richTextBox1.AppendText("\n     student id:      " + id[j]);
                    richTextBox1.AppendText("\n     student name:      " + name[j]);
                    richTextBox1.AppendText("\n     student Mobile:      " + phone[j]);
                    richTextBox1.AppendText("\n     student age:      " + age[j]);
                    richTextBox1.AppendText("\n     student addr.:      " + adress[j]);
                    richTextBox1.AppendText("\n     student GPA:      " + gpa[j]);
                    richTextBox1.AppendText(" \n");

                }

                else
                {
                    richTextBox1.AppendText("       not found     ");
                }
            }

            if (radioButton2.Checked)
            {
                if (name.Contains(textBox2.Text))
                {
                    var j = name.IndexOf(textBox2.Text);
                    richTextBox1.AppendText(" \n");
                    richTextBox1.AppendText("       student info      ");
                    richTextBox1.AppendText("\n===============================");
                    richTextBox1.AppendText("\n     student id:      " + id[j]);
                    richTextBox1.AppendText("\n     student name:      " + name[j]);
                    richTextBox1.AppendText("\n     student Mobile:      " + phone[j]);
                    richTextBox1.AppendText("\n     student age:      " + age[j]);
                    richTextBox1.AppendText("\n     student addr.:      " + adress[j]);
                    richTextBox1.AppendText("\n     student GPA:      " + gpa[j]);
                    richTextBox1.AppendText(" \n");

                }

                else
                {
                    richTextBox1.AppendText("       not found     ");
                }

                


            }



            if (radioButton3.Checked)
            {
                if (phone.Contains(textBox3.Text))
                {
                    var j = phone.IndexOf(textBox3.Text);
                    richTextBox1.AppendText(" \n");
                    richTextBox1.AppendText("       student info      ");
                    richTextBox1.AppendText("\n===============================");
                    richTextBox1.AppendText("\n     student id:      " + id[j]);
                    richTextBox1.AppendText("\n     student name:      " + name[j]);
                    richTextBox1.AppendText("\n     student Mobile:      " + phone[j]);
                    richTextBox1.AppendText("\n     student age:      " + age[j]);
                    richTextBox1.AppendText("\n     student addr.:      " + adress[j]);
                    richTextBox1.AppendText("\n     student GPA:      " + gpa[j]);
                    richTextBox1.AppendText(" \n");

                }

                else
                {
                    richTextBox1.AppendText("       not found     ");
                }



            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
