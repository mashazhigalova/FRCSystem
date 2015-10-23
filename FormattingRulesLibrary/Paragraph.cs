using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class Paragraph
    {
        public Paragraph()
        { }

        public Paragraph(int _align, double lindent, double rindent, double istring, double ibefore, double iafter, double ibtween)
        {
            align = _align;
            left_indent = lindent;
            right_indent = rindent;
            indent_1st_string = istring;
            interval_before = ibefore;
            interval_after = iafter;
            interval_between = ibtween;
        }

        public virtual int paragraph_id    // возвращает id абзаца
        {
            get;
            set;
        }

        public virtual int align   // возвращает id выравнивания
        {
            get;
            set;
        }

        public virtual double left_indent    // возвращает отступ слева
        {
            get;
            set;
        }

        public virtual double right_indent    // возвращает отстпуп справа
        {
            get;
            set;
        }

        public virtual double indent_1st_string    // возвращает отступ первой строки
        {
            get;
            set;
        }

        public virtual double interval_before    // возвращает интервал до абзаца
        {
            get;
            set;
        }

        public virtual double interval_after    // возвращает интервл после абзаца
        {
            get;
            set;
        }

        public virtual double interval_between    // возвращает междустрочный интервал
        {
            get;
            set;
        }

        public virtual void FillPar()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from Paragraph
                            where paragraph_id = @ParID";
            com.Parameters.Add("ParID", SqlDbType.Int).Value = paragraph_id;  // запрос на выборку шрифта по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    align = (int)reader[1];
                    left_indent = double.Parse(reader[2].ToString());
                    right_indent = double.Parse(reader[3].ToString());
                    indent_1st_string = double.Parse(reader[4].ToString());
                    interval_before = double.Parse(reader[5].ToString());
                    interval_after = double.Parse(reader[6].ToString());
                    interval_between = double.Parse(reader[7].ToString());
                }
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void CheckPar()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"SELECT [paragraph_id]
                                  FROM [dbo].[Paragraph]
                                  WHERE alignment = @Alignment AND [left_indent] = @Lindent AND [right_indent] = @Rindent
                                  AND [indent_1st_string] = @Istring  
                                  AND [interval_before] = @Ibefore AND [interval_after] = @Iafter AND [interval_between] = @Ibetw";
            com.Parameters.Add("Alignment", SqlDbType.Int).Value = align;
            com.Parameters.Add("Lindent", SqlDbType.Real).Value = left_indent;
            com.Parameters.Add("Rindent", SqlDbType.Real).Value = right_indent;
            com.Parameters.Add("Istring", SqlDbType.Real).Value = indent_1st_string;
            com.Parameters.Add("Ibefore", SqlDbType.Real).Value = interval_before;
            com.Parameters.Add("Iafter", SqlDbType.Real).Value = interval_after;
            com.Parameters.Add("Ibetw", SqlDbType.Real).Value = interval_between;
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows == false)
                    paragraph_id = 0;
                while (reader.Read())
                {
                    if (reader[0].ToString() != "")
                        paragraph_id = (int)reader[0];
                }
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void InsertPar()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"INSERT INTO [dbo].[Paragraph]
                                           ([alignment]
                                           ,[left_indent]
                                           ,[right_indent]
                                           ,[indent_1st_string]
                                           ,[interval_before]
                                           ,[interval_after]
                                           ,[interval_between])
                                     VALUES
                                           (@Align
                                           ,@Lindent
                                           ,@Rindent
                                           ,@Istring
                                           ,@Ibefore
                                           ,@Iafter
                                           ,@Ibetw)";
            com.Parameters.Add("Align", SqlDbType.Int).Value = align;
            com.Parameters.Add("Lindent", SqlDbType.Real).Value = left_indent;
            com.Parameters.Add("Rindent", SqlDbType.Real).Value = right_indent;
            com.Parameters.Add("Istring", SqlDbType.Real).Value = indent_1st_string;
            com.Parameters.Add("Ibefore", SqlDbType.Real).Value = interval_before;
            com.Parameters.Add("Iafter", SqlDbType.Real).Value = interval_after;
            com.Parameters.Add("Ibetw", SqlDbType.Real).Value = interval_between;
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
    }
}
