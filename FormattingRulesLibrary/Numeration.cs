using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class Numeration
    {
        public Numeration()
        {}

        public Numeration(int loc)
        {
            location = loc;
        }

        public virtual int numeration_id    // возвращает id нумерации
        {
            get;
            set;
        }


        public virtual int num_font    // возвращает id шрифта нумерации
        {
            get;
            set;
        }

        public virtual int location    // возвращает id положения
        {
            get;
            set;
        }

        public virtual void AddNum()    // добавление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            if (num_font == 0)
            {
                com.CommandText = @"INSERT INTO [dbo].[Numeration]
                                           ([num_font],[location])
                                 VALUES (NULL, @Loc)";   // вставка значений, соответствующих заполненным полям
            }
            else
                com.CommandText = @"INSERT INTO [dbo].[Numeration]
                                           ([num_font],[location])
                                 VALUES (@Num_font, @Loc)";
            com.Parameters.Add("Num_font", SqlDbType.Int).Value = num_font;
            com.Parameters.Add("Loc", SqlDbType.Int).Value = location;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void UpdateNum()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            if (num_font == 0)
            {
                com.CommandText = @"UPDATE [dbo].[Numeration]
                                   SET [num_font] = NULL
                                      ,[location] = @Loc
                                 WHERE numeration_id = @numID";   // вставка значений, соответствующих заполненным полям
            }
            else
                com.CommandText = @"UPDATE [dbo].[Numeration]
                                   SET [num_font] = @Num_font
                                      ,[location] = @Loc
                                 WHERE numeration_id = @numID";
            com.Parameters.Add("Num_font", SqlDbType.Int).Value = num_font;
            com.Parameters.Add("Loc", SqlDbType.Int).Value = location;
            com.Parameters.Add("numID", SqlDbType.Int).Value = numeration_id;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
        public virtual void UpdateFontInNum()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"UPDATE [dbo].[Numeration]
                                   SET [num_font] = @Num_font
                                 WHERE numeration_id = @numID";   // вставка значений, соответствующих заполненным полям
           
            com.Parameters.Add("Num_font", SqlDbType.Int).Value = num_font;
            com.Parameters.Add("numID", SqlDbType.Int).Value = numeration_id;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void DeleteNum() // удаление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"delete from Numeration    
                                where numeration_id = @Num_id";   // запрос на удаление по id
            com.Parameters.Add("Num_id", SqlDbType.Int).Value = numeration_id;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void FillGaps()  // заполнение полей на форме для добавления и редактирования
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from Numeration
                            where numeration_id = @numID";
            com.Parameters.Add("numID", SqlDbType.Int).Value = numeration_id;  // запрос на выборку нумерация по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {           
                    if(reader[1].ToString()!="")
                        num_font = (int)reader[1];
                    location = (int)reader[2];
                }
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void FillLocationGaps(ref Location loc)  // заполнение полей на форме для добавления и редактирования
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from Location
                            where location_id = @LocationID";
            com.Parameters.Add("LocationID", SqlDbType.Int).Value = location;  // запрос на выборку местоположения по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    loc.location = reader[1].ToString();
                }
            }
            finally
            {
                con.Close();
            }
        }

    }
}
