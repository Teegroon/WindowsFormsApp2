using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{/// <summary>
/// Класс формы бегуна
/// </summary>
    public partial class Form1 : Form
    {/// <summary>
    /// Объявление класса List для выгрузки таблицы ,,,
    /// </summary>
        List<string[]> table = new List<string[]>();
        /// <summary>
        /// Объявление класса подключения к БД
        /// </summary>
        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;password=1234;port=3310;persistsecurityinfo=True;database=подготовка");
        /// <summary>
        /// Метод конструктора класса формы Бегуна
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ///
            MySqlCommand cmd = new MySqlCommand("select * from condom",connect);
            try
            {
                connect.Open();
                ///
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    table.Add(new string[data.FieldCount]);
                    for (int i = 0; i < data.FieldCount; i++)
                    {
                        table[table.Count - 1][i] = data[i].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
            dataGridView1.Rows.Clear();
            foreach(string[] item in table)
            {
                dataGridView1.Rows.Add(item);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "подготовкаDataSet.condom". При необходимости она может быть перемещена или удалена.
            this.condomTableAdapter.Fill(this.подготовкаDataSet.condom);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                switch (comboBox1.SelectedValue.ToString())
                {
                    case "м":
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            switch (dataGridView1.Rows[i].Cells[2].Value)
                            {
                                case "м":
                                    break;
                                case "дм":
                                    dataGridView1.Rows[i].Cells[3].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) / 10;
                                    dataGridView1.Rows[i].Cells[2].Value = "м";
                                    break;
                                case "см":
                                    dataGridView1.Rows[i].Cells[3].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) / 100;
                                    dataGridView1.Rows[i].Cells[2].Value = "м";
                                    break;

                            }
                        }
                        break;
                    case "дм":
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            switch (dataGridView1.Rows[i].Cells[2].Value)
                            {
                                case "м":
                                    dataGridView1.Rows[i].Cells[3].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * 10;
                                    dataGridView1.Rows[i].Cells[2].Value = "дм";
                                    break;
                                case "дм":
                                    break;
                                case "см":
                                    dataGridView1.Rows[i].Cells[3].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) / 10;
                                    dataGridView1.Rows[i].Cells[2].Value = "дм";
                                    break;

                            }
                        }
                        break;
                    case "см":
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            switch (dataGridView1.Rows[i].Cells[2].Value)
                            {
                                case "м":
                                    dataGridView1.Rows[i].Cells[3].Value = (Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * 100).ToString();
                                    dataGridView1.Rows[i].Cells[2].Value = "см";
                                    break;
                                case "дм":
                                    dataGridView1.Rows[i].Cells[3].Value = (Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * 10).ToString();
                                    dataGridView1.Rows[i].Cells[2].Value = "см";
                                    break;
                                case "см":
                                    break;
                            }
                        }
                        break;
                }
            }
            dataGridView1.Refresh();
        }
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
