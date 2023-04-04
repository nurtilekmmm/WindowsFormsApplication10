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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aviaDataSet.Рейсы' table. You can move, or remove it, as needed.
            this.рейсыTableAdapter.Fill(this.aviaDataSet.Рейсы);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
