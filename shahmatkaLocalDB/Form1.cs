using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shahmatkaLocalDB
{
    public partial class Form1 : Form
    {
        

      
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //пробуем подключится
                conn.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Ошибка подключения:{0}", se.Message);
                return;
            }
            MessageBox.Show("podklu4eno");
           // SqlCommand cmd = new SqlCommand("Insert into baza" +
             //  "(plavka,nom, storona, fio) Values (@plavka,@nom,@storona,@fio)", conn);



            SqlCommand CmdSql = new SqlCommand("Insert into baza" +
               "(plavka,nom, storona, fio) Values (@plavka,@nom,@storona,@fio)", conn);
            //conn.Open();
            //CmdSql.Parameters.AddWithValue("@ID", textBoxPlavka.Text);
            CmdSql.Parameters.AddWithValue("@plavka", textBoxPlavka.Text);
            CmdSql.Parameters.AddWithValue("@nom", textBoxNomer.Text);
            CmdSql.Parameters.AddWithValue("@storona", comboBoxStorona.Text);
            CmdSql.Parameters.AddWithValue("@fio", comboBoxFio.Text);

            CmdSql.ExecuteNonQuery();


            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet2.baza". При необходимости она может быть перемещена или удалена.
            this.bazaTableAdapter1.Fill(this.database1DataSet2.baza);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.baza". При необходимости она может быть перемещена или удалена.
            this.bazaTableAdapter.Fill(this.database1DataSet1.baza);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.spisok". При необходимости она может быть перемещена или удалена.
            this.spisokTableAdapter.Fill(this.database1DataSet.spisok);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
