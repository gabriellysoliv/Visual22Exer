﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativo
{
    public partial class excluir : Form
    {
        dao exc;
        public excluir()
        {
            InitializeComponent();
            exc = new dao();    
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do botão codigo

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();

        }//fim do botão excluir

        private void button2_Click(object sender, EventArgs e)
        {
         
          
                Form1 vol = new Form1();
                vol.ShowDialog();
            }//fim do voltar

        
    }
}
