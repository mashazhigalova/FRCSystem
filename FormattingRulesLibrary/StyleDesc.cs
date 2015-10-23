using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class StyleDesc
    {
        public virtual int style_id    // возвращает id стиля
        {
            get;
            set;
        }

        public virtual string style_title   // возвращает название стиля
        {
            get;
            set;
        }

        public virtual int font    // возвращает шрифт
        {
            get;
            set;
        }

        public virtual string font_title   // возвращает название шрифта
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

        public virtual string color    // возвращает  цвета
        {
            get;
            set;
        }

        public virtual int paragraph    // возвращает абзац
        {
            get;
            set;
        }

        public virtual string align   // возвращает  выравнивания
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

        public virtual void LoadStyles(ref DataTable styles, int work_id)   // просмотр работ 
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");

            SqlCommand com = con.CreateCommand();

            com.CommandText = @"SELECT        StyleDesc.style_id, StyleDesc.style_title, Alignment.alignment, Paragraph.left_indent, Paragraph.right_indent, Paragraph.paragraph_id, Paragraph.indent_1st_string, 
                         Paragraph.interval_before, Paragraph.interval_after, Paragraph.interval_between, Font.italic, Font.underlined, Font.bold, Color.color, Font.size, FontTitle.font_title, Style.work_id
                        FROM            StyleDesc INNER JOIN
                         Style ON StyleDesc.style_id = Style.style_id INNER JOIN
                         Paragraph ON StyleDesc.paragraph = Paragraph.paragraph_id INNER JOIN
                         Alignment ON Paragraph.alignment = Alignment.align_id INNER JOIN
                         Font ON StyleDesc.font = Font.font_id INNER JOIN
                         Color ON Font.color = Color.color_id INNER JOIN
                         FontTitle ON Font.font_title = FontTitle.font_title_id
                         WHERE Style.work_id = @Work_id";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            com.Parameters.Add("Work_id", SqlDbType.Int).Value = work_id;   // выборка фио, номера и буквы класса, др, пола, номера тел, адреса и тд
            styles = new System.Data.DataTable();
            try
            {
                con.Open();
                adapter.Fill(styles);

            }
            finally
            {
                con.Close();
            }
        }

        public virtual void UpdateStyle()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"UPDATE [dbo].[StyleDesc]
                                   SET [style_title] = @STitle
                                      ,[font] = @Font
                                      ,[paragraph] = @Par
                                 WHERE style_id=@styleID";   // вставка значений, соответствующих заполненным полям
            com.Parameters.Add("STitle", SqlDbType.VarChar).Value = style_title;
            com.Parameters.Add("Font", SqlDbType.Int).Value = font;
            com.Parameters.Add("Par", SqlDbType.Int).Value = paragraph;
            com.Parameters.Add("styleID", SqlDbType.Real).Value = style_id;
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

        public virtual void InsertStyle()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"INSERT INTO [dbo].[StyleDesc]
                                           ([style_title]
                                           ,[font]
                                           ,[paragraph])
                                     VALUES
                                           (@Style_title
                                           ,@Font
                                           ,@Par)";
            com.Parameters.Add("Style_title", SqlDbType.VarChar).Value = style_title;
            com.Parameters.Add("Font", SqlDbType.Int).Value = font;
            com.Parameters.Add("Par", SqlDbType.Int).Value = paragraph;
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

        public virtual bool IsThereStyle(int work_id) //проверка на наличие повторяющихся стилей для одной работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"SELECT [style_id], [work_id]
                                  FROM [dbo].[Style]
                                  WHERE 
                                     style_id = @StyleID
                                      AND work_id = @WorkID";
            com.Parameters.Add("StyleID", SqlDbType.Int).Value = style_id;
            com.Parameters.Add("WorkID", SqlDbType.Int).Value = work_id;
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows == false)
                    return false;
                else return true;
            }
            finally
            {
                con.Close();
            }
        }

        public virtual void InsertStyleInStyles(int work_id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"INSERT INTO [dbo].[Style]
                                           ([style_id]
                                           ,[work_id])
                                     VALUES
                                           (@StyleID
                                           ,@WorkID)";
            com.Parameters.Add("StyleID", SqlDbType.Int).Value = style_id;
            com.Parameters.Add("WorkID", SqlDbType.Int).Value = work_id;
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

        public virtual void DeleteStyleInStyles(int work_id) // удаление стиля
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"DELETE FROM [dbo].[Style]    
                                where work_id = @Work_id AND style_id = @Style_id";   // запрос на удаление по id
            com.Parameters.Add("Work_id", SqlDbType.Int).Value = work_id;
            com.Parameters.Add("Style_id", SqlDbType.Int).Value = style_id;
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

        public virtual void DeleteStyle() // удаление стиля
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"delete from StyleDesc    
                                where style_id = @Style_id";   // запрос на удаление по id
            com.Parameters.Add("Style_id", SqlDbType.Int).Value = style_id;
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

        public static string _Font(System.Data.DataTable dt, int index, bool styleobj, StyleDesc style, GeneralInfo info)
        {
            string font = "";
            string bold = "", italic = "", underlined = "";
            if (styleobj == true)
            {
                style.font_title = dt.Rows[index]["font_title"].ToString().Trim();
                style.color = dt.Rows[index]["color"].ToString().Trim();
                style.size = double.Parse(dt.Rows[index]["size"].ToString().Trim());
                style.bold = (bool)dt.Rows[index]["bold"];
                style.italic = (bool)dt.Rows[index]["italic"];
                style.underlined = (bool)dt.Rows[index]["underlined"];
                if (style.bold != false)
                    bold = "полужирный";
                if (style.italic != false)
                    italic = "курсив";
                if (style.underlined != false)
                    underlined = "подчеркнутый";
                font = style.font_title + "; " + style.color + "; " + style.size + "пт";
                if (bold != "")
                    font += "; " + bold;
                if (italic != "")
                    font += "; " + italic;
                if (underlined != "")
                    font += "; " + underlined;
            }
            else
            {
                info.num_font_title = dt.Rows[index]["font_title"].ToString().Trim();
                info.num_color = dt.Rows[index]["color"].ToString().Trim();
                info.num_size = double.Parse(dt.Rows[index]["size"].ToString().Trim());
                info.num_bold = (bool)dt.Rows[index]["bold"];
                info.num_italic = (bool)dt.Rows[index]["italic"];
                info.num_underlined = (bool)dt.Rows[index]["underlined"];
                if (info.num_bold != false)
                    bold = "полужирный";
                if (info.num_italic != false)
                    italic = "курсив";
                if (info.num_underlined != false)
                    underlined = "подчеркнутый";
                font = info.num_font_title + "; " + info.num_color + "; " + info.num_size + "пт";
                if (bold != "")
                    font += "; " + bold;
                if (italic != "")
                    font += "; " + italic;
                if (underlined != "")
                    font += "; " + underlined;
            }
            return font;
        }

        public static string Paragraph(int index, StyleDesc style, DataTable styles)
        {
            string par = "";
            string li = "", ri = "", i1st = "", ib = "", ia = "", ibetween = "";
            if (double.Parse(styles.Rows[index]["left_indent"].ToString()) != 0.0)
            {
                style.left_indent = double.Parse(styles.Rows[index]["left_indent"].ToString());
                li = "отступ слева: " + style.left_indent.ToString() + " см";
            }
            if (double.Parse(styles.Rows[index]["right_indent"].ToString()) != 0.0)
            {
                style.right_indent = double.Parse(styles.Rows[index]["right_indent"].ToString());
                ri = "отступ справа: " + style.right_indent.ToString() + " см";
            }
            if (double.Parse(styles.Rows[index]["indent_1st_string"].ToString()) != 0.0)
            {
                style.indent_1st_string = double.Parse(styles.Rows[index]["indent_1st_string"].ToString());
                i1st = "отступ 1-ой строки: " + style.indent_1st_string.ToString() + " см";
            }
            style.interval_before = double.Parse(styles.Rows[index]["interval_before"].ToString());
            style.interval_after = double.Parse(styles.Rows[index]["interval_after"].ToString());
            style.interval_between = double.Parse(styles.Rows[index]["interval_between"].ToString());
            style.align = styles.Rows[index]["alignment"].ToString().Trim();
            if (style.interval_before != 0.0)
                ib = "интервал до абзаца: " + style.interval_before.ToString() + " пт";
            if (style.interval_after != 0.0)
                ia = "интервал после абзаца: " + style.interval_after.ToString() + " пт";
            if (style.interval_between != 0.0)
                ibetween = "междустрочный интервал: " + style.interval_between.ToString() + " пт";
            par = "выравнивание - " + style.align;
            if (li != "")
                par += "; " + li;
            if (ri != "")
                par += "; " + ri;
            if (i1st != "")
                par += "; " + i1st;
            if (ib != "")
                par += "; " + ib;
            if (ia != "")
                par += "; " + ia;
            if (ibetween != "")
                par += "; " + ibetween;
            return par;
        }

        public static string Style(StyleDesc style, DataTable styles, List<StyleDesc> styles_list, GeneralInfo info)
        {
            string str_style = "";
            for (int i = 0; i < styles.Rows.Count; i++)
            {
                if (styles.Rows[i]["style_id"] != null)
                {
                    style = new StyleDesc();
                    style.style_id = int.Parse(styles.Rows[i]["style_id"].ToString());
                    style.style_title = styles.Rows[i]["style_title"].ToString().Trim();
                    str_style += "***" + style.style_title + "***" + Environment.NewLine + "Абзац: " + Paragraph(i, style, styles)
                        + Environment.NewLine + "Шрифт: " + _Font(styles, i, true, style, info) + Environment.NewLine;
                    styles_list.Add(style);
                }
            }
            return str_style;
        }

    }
}
