using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace course
{
    /// <summary>
    /// Класс order, с помощью которого отображена информация о заказах: номер заказа,
    /// заказчик, дата заказа, количество вещей в заказе и полная цена в формате таблицы
    /// </summary>
   public class order : DataTable
    {
        public DataTable dt;
        public int SortingColumnIndex;
        public string search_string;
        public DataTable dt1;

        public order()
        {
            dt = new DataTable("Order");
            SortingColumnIndex = 0;
            search_string = "Delivery";

            DataColumn[] cols =
            {
                new DataColumn("Order_number", typeof(String)),
                new DataColumn("Customer", typeof(String)),
                new DataColumn("Order_date", typeof(DateTime)),
                new DataColumn("Amount_of_things", typeof(Int32)),
                new DataColumn("Order_price", typeof(String))
            };
            dt.Columns.AddRange(cols);

            DataColumn[] columns = new DataColumn[1];
            columns[0] = dt.Columns["Order_number"];

            dt.PrimaryKey = columns;
            //dt.Columns["Order_number"].Unique = true;

            dt1 = dt.Clone();

        }

        /// <summary>
        /// Метод init_dt осуществляет заполнение таблицы с заказами данными, хранящимися по умолчанию
        /// </summary>
        public void init_dt()
        {
            Object[][] rows =
            {
                new object[] {"178923", "Белякова А.С", DateTime.Today.ToShortDateString(), 4, "4572 рублей"},
                new object[] {"438820", "Рябушин В.Ю", DateTime.Today.AddDays(-2).ToShortDateString(), 1, "554 рубля"},
                new object[] {"985874", "Ступова Е.А", DateTime.Today.AddDays(-2).ToShortDateString(), 7, "6730 рублей"},
                new object[] {"765920", "Косов А.Р", DateTime.Today.AddDays(-1).ToShortDateString(), 3, "2130 рублей"},
                new object[] {"546810", "Брусова А.О", DateTime.Today.ToShortDateString(), 4, "2120 рублей"},
                new object[] {"327480", "Мокшина Ю.С", DateTime.Today.ToShortDateString(), 1, "2000 рублей"},
                new object[] {"182634", "Белякова А.С", DateTime.Today.ToShortDateString(), 5, "4781 рубль"}
            };

            foreach (var item in rows)
            {
                dt.Rows.Add(item);
            }
        }

        /// <summary>
        /// Метод add позволяет пользователю добавить заказ в систему.
        /// Доставку нужно назначить отдельно
        /// </summary>
        /// <param
        /// name="add_order" - строка с данными по заказу, 
        /// которые пользователь хочет добавить,
        /// заполненная через точку с запятой
        /// формат строки: номер заказа; заказчик; дата заказа; количество вещей в заказе; полная цена
        /// ></param>
        public void add(string add_order)
        {
            Object[] tmp = new object[] { };
            tmp = tmp.Concat(add_order.Split(';')).ToArray();
            if (tmp.Length == 5)
            {
                dt.Rows.Add(tmp);
            }
            else
            {
                MessageBox.Show("Неверный формат ввода");
            }

            dt.AcceptChanges();
        }

        /// <summary>
        /// Метод Select_by_Order_num позволяет пользователю найти интересующий заказ по его номеру
        /// </summary>
        /// <param 
        /// name="param" - строка с номером заказа
        /// ></param>
        /// <returns></returns>
        public DataRow[] Select_by_Order_num(string param)
        {
            dt1.Rows.Clear();
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["Order_number"];
            dt.PrimaryKey = key;
            DataRow[] tmp = dt.Select().Where(row => row.Field<string>("Order_number")
                .Equals(param)).ToArray();

            return tmp;
        }

        /// <summary>
        /// Метод Sort_by_amount позволяет отсортировать все имеющиеся заказы по количеству вещей в них,
        /// от меньшего к большему
        /// </summary>
        /// <returns></returns>
        public DataRow[] Sort_by_amount()
        {
            return dt.Select().OrderBy(row => row.Field<Int32>("Amount_of_things")).ToArray();
        }

        /// <summary>
        /// Метод Select_by_ord_date позволяет найти в системе заказ на определённую дату
        /// </summary>
        /// <param
        /// name="param" - строка, содержащая дату, на которую пользователь хочет найти заказ
        /// ></param>
        /// <returns></returns>
        public DataRow[] Select_by_ord_date(string param)
        {
            dt1.Rows.Clear();
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns["Order_number"];
            dt.PrimaryKey = key;


            DataRow[] tmp = dt.Select().Where(row => row.Field<DateTime>("Order_date")
            .Equals(Convert.ToDateTime(param))).ToArray();

            return tmp;            
        }
    }
}