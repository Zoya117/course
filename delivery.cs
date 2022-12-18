using System;
using System.Data;
using System.Linq;


namespace course
{
    /// <summary>
    /// Класс delivery, с помощью которого отображена информация по доставкам:
    /// номер заказа, дата доставки, фамилия и инициалы курьера, доставляющего заказ,
    /// а также статус доставки в виде таблицы
    /// </summary>
    class delivery : DataTable
    {
        public DataTable dt;
        public DataTable dt1;
        public string search_string;

        public delivery()
        {
            dt = new DataTable("Delivery");

            DataColumn[] cols =
            {
                new DataColumn("Order_number", typeof(String)),
                new DataColumn("Delivery_date", typeof(DateTime)),
                new DataColumn("Courier", typeof(String)),
                new DataColumn("Status", typeof(String))

            };
            dt.Columns.AddRange(cols);

            dt1 = dt.Clone();
        }

        /// <summary>
        /// Метод init_dt осуществляет заполнение таблицы с доставками данными, хранящимися по умолчанию
        /// </summary>
        public void init_dt()
        {
            Object[][] rows =
            {
                //new object[]{"178923", "2021-09-08", "Фрозин С.В.", "Доставлено"},
                new object[]{"438820", DateTime.Today.AddDays(-2).ToShortDateString(), "Липов А.Ю.", "Доставлено"},
                new object[]{"985874", DateTime.Today.AddDays(-1).ToShortDateString(), "Иванов И.А.", "Доставлено"},
                new object[]{"765920", DateTime.Today.AddDays(-1).ToShortDateString(), "Пресняков П.Т.", "Доставлено"},
                new object[]{"546810", DateTime.Today.ToShortDateString(), "Бездарев М.Ю.", "В пути"},
                new object[]{"327480", DateTime.Today.ToShortDateString(), "Маков Р.В.", "В пути"},
                new object[]{"182634", DateTime.Today.ToShortDateString(), "Бездарев М.Ю.", "Доставлено"}
            };

            foreach (var item in rows)
            {
                dt.Rows.Add(item);
            }
        }

        /// <summary>
        /// Метод Canceled_delivery позволяет отменить доставку выбранного заказа,
        /// при условии, что он не доставлен или не аннулирован
        /// </summary>
        /// <param
        /// name="param2" - индекс строки, которую пользователь выбрал в таблице
        /// ></param>
        public void Canceled_delivery(int param2)
        {

            /*dt.Select(string.Format("[Order_number] = {0}", param2)).ToList<DataRow>()
                .ForEach(x => x["Status"] = "Аннулирован");*/

            dt.Select(string.Format("[Order_number] = {0}", param2))
                .Where(row => row.Field<string>("Status") != "Доставлено").ToList<DataRow>()
                .ForEach(x => x["Status"] = "Аннулировано");
            dt.AcceptChanges();
            var r = dt;

        }

        /// <summary>
        /// Метод Select_by_del_date позволяет найти определённый заказ по дате его доставки
        /// </summary>
        /// <param
        /// name="param" - строка, содержащая дату доставки
        /// ></param>
        /// <returns></returns>
        public DataRow[] Select_by_del_date(string param)
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