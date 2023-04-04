using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 child = new Form4();
            child.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 child = new Form3();
            child.Show();
        }
            
        }
    }

