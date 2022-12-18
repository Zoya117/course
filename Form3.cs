using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace course
{
    public partial class Form3 : Form
    {
        private CrystalReport1 cr;
        private order orders;
        private delivery delvs;
        private SQLiteConnection db;
        public DataSet ds;
        public int colindex;

        public Form3()
        {
            InitializeComponent();

            //создание экземпляров классов

            this.cr = new CrystalReport1();
 
            this.orders = new order();
            this.delvs = new delivery();

            this.ds = new DataSet();

            //добавляем таблицы в DataSet
            ds.Tables.Add(this.orders.dt);
            ds.Tables.Add(this.delvs.dt);

            DataRelation delOrdRelation = ds.Relations.Add("DelOrd", ds.Tables["Order"].Columns["Order_number"],
                ds.Tables["Delivery"].Columns["Order_number"]);

            //заполнение таблиц
            orders.init_dt();
            delvs.init_dt();

            //отображение таблиц в datagridview
            dataGridView1.DataSource = orders.dt;
        }


        /// <summary>
        /// Метод GetNewOrders позволяет получить информацию о заказах, 
        /// не имеющих назначенных доставок, либо имеющих статус "Аннулировано".
        /// Если таких заказов нет, то отображение будет пустым
        /// </summary>
        public void GetNewOrders()
        {
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
        }

        /// <summary>
        /// Метод ShowDiagram осуществляет построение столбчатой диаграммы 
        /// по количеству доставленных и сделанных заказов на определённую дату
        /// </summary>
        public void ShowDiagram()
        {
            Dictionary<DateTime, int>  data = new Dictionary<DateTime, int>();
            Dictionary<DateTime, int> data2 = new Dictionary<DateTime, int>();

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
                        }).OrderBy(x => x.Order_date).ToArray();

            chart2.DataBindTable(results1, "Order_date");
            
            chart2.Invalidate();
        }

        /// <summary>
        /// Метод BindReport1 осуществляет построение отчеста в CrystalReport
        /// </summary>
        public void BindReport1()
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

            (cr.ReportDefinition.ReportObjects["Text6"] as TextObject).Text = " ";


            cr.SetDataSource(results1);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }


        /// <summary>
        /// Метод BindReport2 осуществляет построение отчета по конкретному курьеру
        /// и его доставкам на определённую дату, которую выбрал пользователь
        /// </summary>
        /// <param
        /// name="del_date" - дата в календаре, которую выбрал пользователь
        /// ></param>
        /// <param
        /// name="courier" - фамилия и инициалы курьера, которого выбрал пользователь
        /// ></param>
        public void BindReport2(DateTime del_date, string courier)
        { 
            var results1 = ds.Tables["Order"].AsEnumerable()
                        .Join(
                                ds.Tables["Delivery"].AsEnumerable().Where(d_s => ((d_s.Field<string>("Courier") == courier)
                                &&
                               (d_s.Field<DateTime>("Delivery_date") == del_date))),
                                o_s => o_s.Field<String>("Order_number"),
                                d_s => d_s.Field<String>("Order_number"),
                                (o_s, d_s) => new
                                {
                                    Customer = o_s.Field<string>("Customer"),
                                    Order_date = o_s.Field<DateTime>("Order_date").ToShortDateString(),
                                    Status = d_s.Field<string>("Status")
                                }
                        );
            (cr.ReportDefinition.ReportObjects["Text6"] as TextObject).Text = courier +" за "+ del_date.ToShortDateString();
            

            cr.SetDataSource(results1);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.RefreshReport();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;

            GetNewOrders();
            ShowDiagram();
            BindReport1();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            cr.Close(); 
        }

        /// <summary>
        /// Назначение курьера и даты доставки, выбранных пользователем, определённому заказу
        /// </summary>
        public void add__button_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();
            testDialog.dateTimePicker1.MinDate = DateTime.Today;
            testDialog.comboBox1.SelectedItem = 0;

            if (dataGridView2.RowCount > 0)
            {
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    //Read the contents of testDialog's TextBox.
                    //var tmp1 = testDialog.dialog_result[0].ToString();
                    //var tmp2 = Convert.ToDateTime(testDialog.dialog_result[1]).ToShortDateString();

                    delvs.dt.Rows.Add(new object[] { dataGridView2.CurrentRow.Cells[0].Value.ToString(),
                                                    Convert.ToDateTime(testDialog.dialog_result[1]).ToShortDateString(),
                                                    testDialog.dialog_result[0].ToString(),
                                                    "В пути"}) ;
                    chart2.ChartAreas[0].AxisY.Maximum += 1;

                }
                GetNewOrders();
                ShowDiagram();
                BindReport1();
            }
            testDialog.Dispose();
        }

        /// <summary>
        /// Поиск заказа по его номеру
        /// </summary>
        public void search_button_Click(object sender, EventArgs e)
        {
            string search_order = toolStripTextBox1.Text;
            int search;
            if (search_order != "" && int.TryParse(search_order, out search))
            {
                dataGridView2.DataSource = orders.Select_by_Order_num(search_order).CopyToDataTable();                
            }
            else
            {
                MessageBox.Show("Некорректная информация для поиска");
            }
        }

        /// <summary>
        /// Поиск заказа по определённой дате заказа
        /// </summary>
        public void search_date_button_Click(object sender, EventArgs e)
        {
            string search_date = toolStripTextBox1.Text;
            DateTime order_date;

            if (search_date != "" && DateTime.TryParse(search_date, out order_date))
            {
                dataGridView2.DataSource = orders.Select_by_ord_date(search_date).CopyToDataTable();
            }         
            else
            {
                MessageBox.Show("Некорректная информация для поиска");
            }
        }

        /// <summary>
        /// Фильтрация записей в таблице по количеству вещей в заказе
        /// </summary>
        public void filter_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orders.Sort_by_amount().CopyToDataTable();
        }

        /// <summary>
        /// Пользовательский выбор конкретной доставку и её отмена
        /// </summary>
        public void del_button_Click(object sender, EventArgs e)
        {
            //пременная, благодаря которой мы получаем индекс строки,
            //которую выбрал пользователь
            var tmp = dataGridView1.CurrentRow.Cells[0].Value;

            delvs.Canceled_delivery(Convert.ToInt32(tmp));

            dataGridView1.DataSource = delvs.dt;

            GetNewOrders();
            BindReport1();
            ShowDiagram();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            GetNewOrders();
            ShowDiagram();
            BindReport1();
        }
        
        /// <summary>
        /// Отображение информацию о программе
        /// </summary>
        private void About_program_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Система учёта работы курьерской службы");
        }

        /// <summary>
        /// Экспорт хранимых данных в БД
        /// </summary>
        public void Export_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Импорт хранимых данных о заказах из БД
        /// </summary>

        public void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.ShowDialog();
            string tmps = openFileDialog.FileName.ToString();
            if (tmps == "")
                return;
            db = new SQLiteConnection("Data Source = " + tmps + ";");
            db.Open();


            SQLiteCommand command;  // Новый объект класса SQLiteCommand создается вызовом метода CreateCommand() 
            SQLiteDataReader reader;// Предоставляет способ чтения потока строк из базы данных SQL Server
                                    // ранее созданного объекта класса SQLiteConnection
            command = new SQLiteCommand("SELECT * FROM Orders", db);// используется sql-выражение SELECT мы выбираем все столбцы всех строк таблицы

            try                                                 //обработка исключения
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

        /// <summary>
        ///  Отображание таблицы заказов или доставок в зависимости от выбранного в ComboBox1 значения
        /// </summary>
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0: dataGridView1.DataSource = orders.dt;
                    break;
                case 1: dataGridView1.DataSource = delvs.dt;
                    break;
            }
                
        }

        /// <summary>
        /// Вывод диалогового окна, в котором пользователь выбирает курьера и дату,
        /// по которой хочет посмотреть отчёт для конкретного курьера
        /// </summary>
        private void CourierReport_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();
            testDialog.dateTimePicker1.Value = DateTime.Today;
            testDialog.comboBox1.SelectedItem = 0;

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                BindReport2(Convert.ToDateTime(testDialog.dialog_result[1]), 
                                              testDialog.dialog_result[0].ToString());
            }             
            testDialog.Dispose();
        }

        private void GeneralReport_Click(object sender, EventArgs e)
        {
            BindReport1();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string ord = toolStripTextBox1.Text.ToString();
            orders.add(ord);

        }
    }
}