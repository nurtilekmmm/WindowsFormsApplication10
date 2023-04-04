using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication10
{
    public partial class Form2 : Form
    {
        public static string connecString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source = avia.mdb";
        private OleDbConnection MyConnection;
        public Form2()
        {
            InitializeComponent();
            MyConnection = new OleDbConnection(connecString);
            MyConnection.Open();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aviaDataSet2.Пассажиры' table. You can move, or remove it, as needed.
            this.пассажирыTableAdapter1.Fill(this.aviaDataSet2.Пассажиры);


        }
        private void Form2_FormClosing(Object sernder, FormClosingEventArgs e)
        {
            MyConnection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int pass = Convert.ToInt32(textBox1.Text);
            int reis = Convert.ToInt32(textBox2.Text);
            int avia = Convert.ToInt32(textBox3.Text);
            string Fio = textBox6.Text;
            int document = Convert.ToInt32(textBox5.Text);
            string query = "INSERT INTO Пассажиры ([КодПассажира], [КодРейса],[КодСамолета],ФИО ,[Документ №]) VALUES (" + pass + ", " + reis + ", " + avia + ", '" + Fio + "', " + document + ")";
            OleDbCommand command = new OleDbCommand(query, MyConnection);
            command.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox7.Text);
            string query = "DELETE FROM Пассажиры WHERE [КодПассажира] = " + kod;
            OleDbCommand qwerty = new OleDbCommand(query, MyConnection);
            qwerty.ExecuteNonQuery();
            MessageBox.Show("Данные о клиенте удалены");
            this.пассажирыTableAdapter1.Fill(this.aviaDataSet2.Пассажиры);
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
            string FIO = textBox4.Text;
            string query = "Select * FROM Пассажиры WHERE ФИО = '" + FIO + "'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, MyConnection);
            DataTable dit = new DataTable();
            command.Fill(dit);
            dataGridView1.DataSource = dit;
            MyConnection.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.пассажирыTableAdapter1.Fill(this.aviaDataSet2.Пассажиры);
        }
    }
}
