using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class Font
    {
        public Font() { }

        public Font(int ftitle, double fsize, bool ital, bool undrl, bool fbold, int fcolor)
        {
            font_title = ftitle;
            size = fsize;
            italic = ital;
            underlined = undrl;
            bold = fbold;
            color = fcolor;
        }

        public virtual int font_id    // возвращает id шрифта
        {
            get;
            set;
        }

        public virtual int font_title   // возвращает название шрифта
        {
            get;
            set;
        }

        public virtual double size  // возвращает размер
        {
            get;
            set;
        }

        public virtual bool italic  // возвращает курсив
        {
            get;
            set;
        }

        public virtual bool underlined  // возвращает подчеркнутый
        {
            get;
            set;
        }

        public virtual bool bold  // возвращает жирный
        {
            get;
            set;
        }

        public virtual int color    // возвращает id цвета
        {
            get;
            set;
        }

        public void LoadFont(ref DataTable fontDT)    // загрузка шрифта
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");

            SqlCommand comNum = con.CreateCommand();
            comNum.CommandText = @"SELECT        Font.font_id, Font.italic, Font.underlined, Font.bold, Font.size, Color.color_id, Color.color, FontTitle.font_title_id, FontTitle.font_title
                                    FROM            Color INNER JOIN
                         Font ON Color.color_id = Font.color INNER JOIN
                         FontTitle ON Font.font_title = FontTitle.font_title_id";
            SqlDataAdapter adaptFNum = new SqlDataAdapter(comNum);
            fontDT = new DataTable();
            try
            {
                con.Open();
                adaptFNum.Fill(fontDT);
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void DeleteFont() // удаление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"delete from Font    
                                where font_id = @Font_id";   // запрос на удаление по id
            com.Parameters.Add("Font_id", SqlDbType.Int).Value = font_id;
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

        public virtual void InsertFont()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"INSERT INTO [dbo].[Font]
                                           ([font_title]
                                           ,[italic]
                                           ,[underlined]
                                           ,[bold]
                                           ,[color]
                                           ,[size])
                                     VALUES
                                           (@FTitle
                                           ,@Italic
                                           ,@Underlined
                                           ,@Bold
                                           ,@Color
                                           ,@Size)";
            com.Parameters.Add("FTitle", SqlDbType.Int).Value = font_title;
            com.Parameters.Add("Color", SqlDbType.Int).Value = color;
            com.Parameters.Add("Italic", SqlDbType.Bit).Value = italic;
            com.Parameters.Add("Underlined", SqlDbType.Bit).Value = underlined;
            com.Parameters.Add("Bold", SqlDbType.Bit).Value = bold;
            com.Parameters.Add("Size", SqlDbType.Real).Value = size;
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

        public virtual void UpdateFont()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"UPDATE [dbo].[Font]
                               SET [font_title] = @FTitle
                                  ,[italic] = @Italic
                                  ,[underlined] = @Underlined
                                  ,[bold] = @Bold
                                  ,[color] = @Color
                                  ,[size] = @Size
                             WHERE font_id = @fontID";
            com.Parameters.Add("FTitle", SqlDbType.Int).Value = font_title;
            com.Parameters.Add("Color", SqlDbType.Int).Value = color;
            com.Parameters.Add("Italic", SqlDbType.Bit).Value = italic;
            com.Parameters.Add("Underlined", SqlDbType.Bit).Value = underlined;
            com.Parameters.Add("Bold", SqlDbType.Bit).Value = bold;
            com.Parameters.Add("Size", SqlDbType.Real).Value = size;
            com.Parameters.Add("fontID", SqlDbType.Int).Value = font_id;
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

        public virtual void CheckFont()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"SELECT [font_id]
                                  FROM [dbo].[Font]
                                  WHERE 
                                      [font_title] = @FTitle AND [italic] = @Italic AND [underlined] = @Underlined
                                  AND [bold] = @Bold AND [color] = @Color AND [size] = @Size";
            com.Parameters.Add("FTitle", SqlDbType.Int).Value = font_title;
            com.Parameters.Add("Color", SqlDbType.Int).Value = color;
            com.Parameters.Add("Italic", SqlDbType.Bit).Value = italic;
            com.Parameters.Add("Underlined", SqlDbType.Bit).Value = underlined;
            com.Parameters.Add("Bold", SqlDbType.Bit).Value = bold;
            com.Parameters.Add("Size", SqlDbType.Real).Value = size;
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows == false)
                    font_id = 0;
                while (reader.Read())
                {
                    if (reader[0].ToString() != "")
                        font_id = (int)reader[0];
                }
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void FillFontGaps()  // заполнение полей на форме для добавления и редактирования
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from Font
                            where font_id = @FontID";
            com.Parameters.Add("FontID", SqlDbType.Int).Value = font_id;  // запрос на выборку шрифта по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    font_title = (int)reader[1];
                    italic = (bool)reader[2];
                    underlined = (bool)reader[3];
                    bold = (bool)reader[4];
                    color = (int)reader[5];
                    size = double.Parse(reader[6].ToString());
                }
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void FillFTitleGaps(ref FontTitle f_title)  // заполнение полей на форме для добавления и редактирования
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from FontTitle
                            where font_title_id = @FTitleID";
            com.Parameters.Add("FTitleID", SqlDbType.Int).Value = font_title;  // запрос на выборку местоположения по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    f_title.font_title = reader[1].ToString();
                }
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void FillColorGaps(ref Color f_color)  // заполнение полей на форме для добавления и редактирования
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select *
                            from Color
                            where color_id = @ColorID";
            com.Parameters.Add("ColorID", SqlDbType.Int).Value = color;  // запрос на выборку цвета по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    f_color.color = reader[1].ToString();
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
