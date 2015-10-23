using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class Colontitul
    {
        public virtual int colont_id    // возвращает id колонтитула
        {
            get;
            set;
        }

        public virtual double bot_size   // возвращает размер нижнего колонтитула
        {
            get;
            set;
        }

        public virtual double up_size   // возвращает размер верхнего колонтитула
        {
            get;
            set;
        }

        public virtual void FillColontGaps()  // заполнение полей на форме для добавления и редактирования
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from Colont
                            where colont_id = @ColontID";
            com.Parameters.Add("ColontID", SqlDbType.Int).Value = colont_id;  // запрос на выборку колонтитулов по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    bot_size = double.Parse(reader[1].ToString());               //присваивание 
                    up_size = double.Parse(reader[2].ToString());
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
