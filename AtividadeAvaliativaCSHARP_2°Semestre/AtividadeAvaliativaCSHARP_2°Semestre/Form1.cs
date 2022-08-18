using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AtividadeAvaliativaCSHARP_2_Semestre
{
    public partial class Form1 : Form
    {
        String caminho = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string nome_arq = Directory.GetCurrentDirectory();
            StreamWriter arquivo;

            if (System.IO.File.Exists("E:\\" + nome_arq + ".txt"))
                File.Delete("E:\\" + nome_arq + ".txt");


            arquivo = new StreamWriter(caminho + "\\professores.txt");

            foreach (object item in listBox2.Items)
            {
                arquivo.WriteLine(item.ToString());
            }
            arquivo.Close();

            MessageBox.Show("Arquivo Gravado com Sucesso!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

            textBox1.Clear();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

           
           
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tokyo");

        }
    }
}



