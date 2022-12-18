using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Xml;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Linq.Expressions;

namespace course
{
    public partial class Form1 : Form
    {
        private CrystalReport1 cr;
        private order orders;
        private delivery delvs;
        private SQLiteConnection db;
        private XmlDocument xmlDoc;
        public DataSet ds;
        public int colindex;

        public Form1()
        {
            InitializeComponent();

            this.cr = new CrystalReport1();
 
            this.orders = new order();
            this.delvs = new delivery();

            this.ds = new DataSet();
            ds.Tables.Add(this.orders.dt);//добавляем таблицы в DataSet
            ds.Tables.Add(this.delvs.dt);

            DataRelation delOrdRelation = ds.Relations.Add("DelOrd", ds.Tables["Order"].Columns["Order_number"],
                ds.Tables["Delivery"].Columns["Order_number"]);

            //заполнение таблиц
            orders.init_dt();
            delvs.init_dt();
            dataGridView1.DataSource = orders.dt;
        }

        private void ShowDiagram()
        {
            Dictionary<DateTime, int>  data = new Dictionary<DateTime, int>();
            Dictionary<DateTime, int> data2 = new Dictionary<DateTime, int>();

            //data.Add(DateTime.Now, 0);
            /*
                        for (int i = 0; i < orders.dt.Rows.Count; i++)
                        {
                            data.Add(Convert.ToDateTime(orders.dt.Rows[i].ItemArray[2]), orders.dt.Select().Where(row => row.Field<DateTime>("Order_date")
                                                                                                           .Equals(orders.dt.Rows[i].ItemArray[2])
                                                                                                           *//*Convert.ToInt32(orders.dt.Rows[i].ItemArray[3])*//*).Count());
                            data2.Add(Convert.ToDateTime(orders.dt.Rows[i].ItemArray[2]), delvs.dt.Select().Where(rows => rows.Field<string>("Status")
                                                                                                          .Equals("Доставлено"))
                                                                                                           *//*Convert.ToInt32(orders.dt.Rows[i].ItemArray[3])*//*.Count());
                        }

                        foreach (var item in data)
                        {
                            chart2.Series["Orders"].Points.AddXY(item.Key, item.Value);
                        }

                        foreach (var item in data2)
                        {
                            chart2.Series["Delivered"].Points.AddXY(item.Key, item.Value);
                        }*/
            DateTime dateFrom = DateTime.Today.AddDays(-7).Date;
            DateTime dateTo = DateTime.Today.Date;
            chart2.Series.Clear();

            var results1 = ds.Tables["Order"].AsEnumerable()
                        .Join(
                                ds.Tables["Delivery"].AsEnumerable(),
                                o_s => o_s.Field<String>("Order_number"),
                                d_s => d_s.Field<String>("Order_number"),
                                (o_s, d_s) => new
                                {
                                    Order_date = o_s.Field<DateTime>("Order_date").ToShortDateString(),
                                    Status = d_s.Field<string>("Status")
                                })
                        .GroupBy(em => em.Order_date)
                        .Select(g => new
                        {
                           Order_date = (string)(g.Key).ToString().Substring(0, 5),
                           Order_per_date = (int)g.Count(),
                           Order_delivered = (int)g.Where(y => y.Status == "Доставлено").Count()
                        }).ToArray();

            chart2.DataBindTable(results1, "Order_date");
            chart2.Invalidate();
        }

        private void BindReport1()
        {   //*****************
            //LINQ query syntax
            //*****************
            /*            var results = (from o_s in ds.Tables["Order"].AsEnumerable()
                                        join d_s in ds.Tables["Delivery"].AsEnumerable()
                                        on o_s.Field<int>("Order_number") equals
                                                d_s.Field<int>("Order_number")
                                        select new
                                        {
                                            Customer = o_s.Field<string>("Customer"),
                                            Order_date = o_s.Field<DateTime>("Order_date").ToShortDateString(),
                                            Status = d_s.Field<string>("Status")
                                        }
                                        );*/

            //******************
            //LINQ method syntax
            //******************
            var results1 = ds.Tables["Order"].AsEnumerable()
                        .Join(
                                ds.Tables["Delivery"].AsEnumerable(),
                                o_s => o_s.Field<String>("Order_number"),
                                d_s => d_s.Field<String>("Order_number"),
                                (o_s, d_s) => new
                            {
                                Customer = o_s.Field<string>("Customer"),
                                Order_date = o_s.Field<DateTime>("Order_date").ToShortDateString(),
                                Status = d_s.Field<string>("Status")
                            }
                        );

            cr.SetDataSource(results1);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindReport1();

            //var cr = new ReportDocument();
            //string reportPath = Application.StartupPath + "\\" + "CrystalReport1.rpt";
            //crystalReportViewer1.ReportSource = reportPath;
            //crystalReportViewer1.RefreshReport();

            //db = new SQLiteConnection("Data Source = dataBase.db_1;");
            //db.Open();

            ShowDiagram();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cr.Close(); 
        }


        private void add__button_Click(object sender, EventArgs e)
        {
            //ShowMyDialogBox(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Form2 testDialog = new Form2();
            testDialog.dateTimePicker1.MinDate = DateTime.Today;

            //Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK && order_button.Checked == true)
            {
                //Read the contents of testDialog's TextBox.
                //var tmp1 = testDialog.dialog_result[0].ToString();
                //var tmp2 = Convert.ToDateTime(testDialog.dialog_result[1]).ToShortDateString();

                delvs.dt.Rows.Add(new object[] { dataGridView2.CurrentRow.Cells[0].Value.ToString(),
                                                Convert.ToDateTime(testDialog.dialog_result[1]).ToShortDateString(),
                                                testDialog.dialog_result[0].ToString(),
                                                "В пути"}) ;
            }
            
            testDialog.Dispose();
        }

        private void order_button_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orders.dt;
            toolStripStatusLabel4.Text = "Заказы";
        }

        private void delivery_button_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = delvs.dt;
            toolStripStatusLabel4.Text = "Доставки";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string search_order = textBox1.Text;
            int search;
            if (search_order != "" && int.TryParse(search_order, out search))
            {
                dataGridView2.DataSource = orders.Select_by_Order_num(search_order).CopyToDataTable();                
            }
            else
            {
                MessageBox.Show("Некорректная информация для поиска");
            }

            toolStripStatusLabel1.Text = "Отслеживание";
        }

        private void search_date_button_Click(object sender, EventArgs e)
        {
            string search_date = textBox1.Text;
            DateTime order_date;
            

            if (search_date != "" && DateTime.TryParse(search_date, out order_date))
            {
                dataGridView2.DataSource = orders.Select_by_ord_date(search_date).CopyToDataTable();
            }         
            else
            {
                MessageBox.Show("Некорректная информация для поиска");
            }

            toolStripStatusLabel1.Text = "Поиск по дате";

        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orders.Sort_by_amount().CopyToDataTable();

            toolStripStatusLabel4.Text = "Фильтр по количеству";

        }

        private void del_button_Click(object sender, EventArgs e)
        {
            var tmp = dataGridView1.CurrentRow.Cells[0].Value;

            delvs.Canceled_delivery(Convert.ToInt32(tmp));

            dataGridView1.DataSource = delvs.dt;
            BindReport1();

            toolStripStatusLabel1.Text = "Доставки";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*dataGridView2.DataSource = orders.dt.AsEnumerable()
                .Where(row => !delvs.dt.Rows.Contains(row.Field<string>("Order_number")))
                .CopyToDataTable();*/

            var results = ds.Tables["Order"].AsEnumerable()
                            .Where(o_s => (ds.Tables["Delivery"].AsEnumerable()
                            .All(d_s => (d_s.Field<string>("Order_number") != o_s.Field<string>("Order_number"))
                            ||
                            (d_s.Field<string>("Order_number") == o_s.Field<string>("Order_number") &&
                            d_s.Field<string>("Status") == "Аннулировано"))));

            if (results.Count() > 0)
            {
                dataGridView2.DataSource = results.CopyToDataTable();
            }
            else
            {
                dataGridView2.DataSource = null;
            }


            toolStripStatusLabel1.Text = "Новые заказы";
        }

        private void About_program_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Система учёта работы курьерской службы");
        }


        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();
            string tmps = saveFileDialog.FileName.ToString();
            if (tmps == "")
                return;

            if (!File.Exists(tmps))
                SQLiteConnection.CreateFile(tmps);

            db = new SQLiteConnection("Data Source = "+ tmps + ";");
            db.Open();

            SQLiteCommand command;
            command = new SQLiteCommand("PRAGMA synchronous = 1;" + 
                                         //"PRAGMA foreigh_keys = OFF;" +
                                         "DROP TABLE Delivery;" +
                                         "DROP TABLE Orders;" +
                                         //"PRAGMA foreigh_keys = ON;" +
                                         "CREATE TABLE Orders (Order_number TEXT PRIMARY KEY, " +
                                         "Customer, Order_date, Amount_of_things INTEGER, Order_price); " +
                                         "CREATE TABLE Delivery (Order_number, " +
                                         "Delivery_date, Courier, Status, " +
                                         "FOREIGN KEY (Order_number) REFERENCES Orders(Order_number)" +
                                         ");"
                                         , db);
            command.ExecuteNonQuery(); // метод для выполнение SQL-команды, не предполагающей возвращения данных

            var tmp = orders.dt.AsEnumerable().Select(x => x);
            foreach (var row in tmp)
            {
                command = new SQLiteCommand("INSERT INTO Orders(Order_number, Customer, Order_date, Amount_of_things, Order_price) " +
                                            "VALUES(" + row.Field<string>("Order_number") + ",'" +
                                            row.Field<string>("Customer") + "','" +
                                            row.Field<DateTime>("Order_date").ToShortDateString() + "'," +
                                            row.Field<Int32>("Amount_of_things") + ",'" +
                                            row.Field<string>("Order_price") + "')"
                                            , db);
                command.ExecuteNonQuery();// метод для выполнение SQL-команды, не предполагающей возвращения данных
            }

            tmp = delvs.dt.AsEnumerable().Select(x => x);
            foreach (var row in tmp)
            {
                command = new SQLiteCommand("INSERT INTO Delivery(Order_number, Delivery_date, Courier, Status) " +
                                            "VALUES("+row.Field<string>("Order_number")+",'" +
                                            row.Field<DateTime>("Delivery_date").ToShortDateString() + "','" +
                                            row.Field<string>("Courier") + "','" +
                                            row.Field<string>("Status") + "')" 
                                            , db);
                command.ExecuteNonQuery();// метод для выполнение SQL-команды, не предполагающей возвращения данных
            }

            command.Dispose();
            db.Close();

            MessageBox.Show("Экспорт БД завершён");
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.ShowDialog();
            string tmps = openFileDialog.FileName.ToString();
            if (tmps == "")
                return;
            db = new SQLiteConnection("Data Source = " + tmps + ";");
            db.Open();



            SQLiteCommand command;
            SQLiteDataReader reader;// Предоставляет способ чтения потока строк из базы данных SQL Server
            // новый объект класса SQLiteCommand создается вызовом метода CreateCommand() 
            // ранее созданного объекта класса SQLiteConnection
            command = new SQLiteCommand("SELECT * FROM Orders", db);// используется sql-выражение SELECT мы выбираем все столбцы всех строк таблицы


            try
            {
                reader = command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с БД");
                return;
            }

            delvs.dt.Clear();
            orders.dt.Clear();
            orders.dt.Load(reader);

            command.Dispose();

            db.Close();

            MessageBox.Show("Импорт заказов из БД завершен");

            dataGridView1.DataSource = orders.dt;
        }
    }
}