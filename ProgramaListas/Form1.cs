﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaListas
{
    public partial class Form1 : Form
    {
       ConstructorEquipos teamBuilder = new ConstructorEquipos();

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string[] RichTextBoxLines = richTextBox1.Lines;

            foreach (string line in RichTextBoxLines)
            {
                
                nombre = line;
                MessageBox.Show(line);
                teamBuilder.leerTextBox(nombre);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = teamBuilder.Nombres;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;
            textBox3.Visible = true;
            button5.Visible = true;
            
            //int tamano = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tamano, numEquipos;

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                tamano = Convert.ToInt32(textBox2.Text);
                numEquipos = Convert.ToInt32(textBox3.Text);
            }
            else
            {
                tamano = 2;
                numEquipos = 2;
            }

            teamBuilder.formarEquipos(tamano, numEquipos);

            teamBuilder.mostrarEquipos(listBox1, numEquipos);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
