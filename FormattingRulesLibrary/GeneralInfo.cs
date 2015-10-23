using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingRulesLibrary
{
    public class GeneralInfo
    {
        public GeneralInfo()
        {}

        public GeneralInfo(string wtitle, int ori, double up, double bot, double left, double right, 
            int min, int max, int col, int num, int pform)
        {
            work_title = wtitle;
            orient = ori;
            up_field = up;
            bot_field = bot;
            left_field = left;
            right_field = right;
            min_volume = min;
            max_volume = max;
            colont = col;
            numeration = num;
            paper_format = pform;
        }

        public virtual int work_id    // возвращает id работы
        {
            get;
            set;
        }

        public virtual string work_title   // возвращает название работы
        {
            get;
            set;
        }

        public virtual int orient    // возвращает id ориентации
        {
            get;
            set;
        }

        public virtual double up_field  // возвращает верхнее поле
        {
            get;
            set;
        }

        public virtual double bot_field  // возвращает нижнее поле
        {
            get;
            set;
        }

        public virtual double left_field  // возвращает левое поле
        {
            get;
            set;
        }

        public virtual double right_field  // возвращает правое поле
        {
            get;
            set;
        }

        public virtual int min_volume   // возвращает минимальный объем
        {
            get;
            set;
        }

        public virtual int max_volume   // возвращает максимальный объем
        {
            get;
            set;
        }

        public virtual int colont   // возвращает id колонтитула
        {
            get;
            set;
        }

        public virtual int numeration   // возвращает id нумерации
        {
            get;
            set;
        }

        public virtual string num_location   // возвращает положение номера
        {
            get;
            set;
        }

        public virtual string num_font_title   // возвращает название шрифта
        {
            get;
            set;
        }

        public virtual double num_size  // возвращает размер
        {
            get;
            set;
        }

        public virtual bool num_italic  // возвращает курсив
        {
            get;
            set;
        }

        public virtual bool num_underlined  // возвращает подчеркнутый
        {
            get;
            set;
        }

        public virtual bool num_bold  // возвращает жирный
        {
            get;
            set;
        }

        public virtual string num_color    // возвращает  цвета
        {
            get;
            set;
        }

        public virtual int paper_format   // возвращает id формата бумаги
        {
            get;
            set;
        }
        public virtual string paper_format_value   // возвращает значение формата бумаги
        {
            get;
            set;
        }
        public virtual int paper_format_width   // возвращает ширину формата бумаги
        {
            get;
            set;
        }

        public virtual int paper_format_heigth   // возвращает длину формата бумаги
        {
            get;
            set;
        }

        public virtual double bottom_size_colont   // возвращает верхний колонт
        {
            get;
            set;
        }

        public virtual double up_size_colont   // возвращает нижний клонт
        {
            get;
            set;
        }

        public virtual string orientation   // возвращает ориентацию
        {
            get;
            set;
        }

        public virtual void LoadInfos(ref DataTable infos)   // просмотр работ 
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");

            SqlCommand com = con.CreateCommand();

            com.CommandText = @"SELECT        Colont.bottom_size_colont, Colont.up_size_colont, Color.color, FontTitle.font_title, Font.font_id, Font.italic, Font.underlined, Color.color_id, Colont.colont_id, FontTitle.font_title_id, Font.bold, Font.size, 
                         GeneralInformation.work_id, GeneralInformation.work_title, GeneralInformation.up_field, GeneralInformation.bottom_field, GeneralInformation.left_field, GeneralInformation.right_field, 
                         GeneralInformation.min_vol_pages, GeneralInformation.max_vol_pages, Location.location, Numeration.numeration_id, Location.location_id, 
                         PaperFormat.paper_format_id, PaperFormat.paper_format, PaperFormat.width, PaperFormat.heigth, Orientation.orientation, Orientation.orient_id
                         FROM            GeneralInformation LEFT OUTER JOIN
                         Colont ON GeneralInformation.colont = Colont.colont_id LEFT OUTER JOIN
                         Numeration ON GeneralInformation.numeration = Numeration.numeration_id LEFT JOIN
                         Font LEFT JOIN
                         Color ON Font.color = Color.color_id LEFT JOIN
                         FontTitle ON Font.font_title = FontTitle.font_title_id ON Numeration.num_font = Font.font_id LEFT JOIN
                         Location ON Numeration.location = Location.location_id  LEFT JOIN
                         Orientation ON GeneralInformation.orientation = Orientation.orient_id LEFT JOIN
                         PaperFormat ON GeneralInformation.paper_format = PaperFormat.paper_format_id";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            infos = new System.Data.DataTable();
            try
            {
                con.Open();
                adapter.Fill(infos);

            }
            finally
            {
                con.Close();
            }
        }

        public virtual void AddBlankInfo()    // добавление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"insert into GeneralInformation ([work_title],[orientation],[up_field],[bottom_field]
                                                               ,[left_field],[right_field],[min_vol_pages],[max_vol_pages]
                                                               ,[colont],[numeration],[paper_format])
                                values (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)";   // вставка пустых значений
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

        public virtual void AddInfo()    // добавление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            if (colont == 0 || numeration == 0)
            {
                if (colont == 0)
                    com.CommandText = @"insert into GeneralInformation ([work_title],[orientation],[up_field],[bottom_field],[left_field],[right_field],[min_vol_pages],[max_vol_pages],[colont],[numeration],[paper_format])
                                values (@WorkTitle, @Orient, @UpField, @BotField, @LeftField, @RightField, @MinVol, @MaxVol, NULL, @Num, @PFormat)";   // вставка значений, соответствующих заполненным полям
                if (numeration == 0)
                    com.CommandText = @"insert into GeneralInformation ([work_title],[orientation],[up_field],[bottom_field],[left_field],[right_field],[min_vol_pages],[max_vol_pages],[colont],[numeration],[paper_format])
                                values (@WorkTitle, @Orient, @UpField, @BotField, @LeftField, @RightField, @MinVol, @MaxVol, @Colont, NULL, @PFormat)";   // вставка значений, соответствующих заполненным полям
                if (colont == 0 && numeration == 0)
                    com.CommandText = @"insert into GeneralInformation ([work_title],[orientation],[up_field],[bottom_field],[left_field],[right_field],[min_vol_pages],[max_vol_pages],[colont],[numeration],[paper_format])
                                values (@WorkTitle, @Orient, @UpField, @BotField, @LeftField, @RightField, @MinVol, @MaxVol, NULL, NULL, @PFormat)";   // вставка значений, соответствующих заполненным полям
            }
            else
                com.CommandText = @"insert into GeneralInformation ([work_title]
                                                               ,[orientation]
                                                               ,[up_field]
                                                               ,[bottom_field]
                                                               ,[left_field]
                                                               ,[right_field]
                                                               ,[min_vol_pages]
                                                               ,[max_vol_pages]
                                                               ,[colont]
                                                               ,[numeration]
                                                               ,[paper_format])
                                values (@WorkTitle, @Orient, @UpField, @BotField, @LeftField, @RightField, @MinVol, @MaxVol, @Colont, @Num, @PFormat)";   // вставка значений, соответствующих заполненным полям
            com.Parameters.Add("WorkTitle", SqlDbType.VarChar, work_title.Length).Value = work_title;
            com.Parameters.Add("Orient", SqlDbType.Int).Value = orient;
            com.Parameters.Add("UpField", SqlDbType.Real).Value = up_field;
            com.Parameters.Add("BotField", SqlDbType.Real).Value = bot_field;
            com.Parameters.Add("LeftField", SqlDbType.Real).Value = left_field;
            com.Parameters.Add("RightField", SqlDbType.Real).Value = right_field;
            com.Parameters.Add("MinVol", SqlDbType.Int).Value = min_volume;
            com.Parameters.Add("MaxVol", SqlDbType.Int).Value = max_volume;
            com.Parameters.Add("Colont", SqlDbType.Int).Value = colont;
            com.Parameters.Add("Num", SqlDbType.Int).Value = numeration;
            com.Parameters.Add("PFormat", SqlDbType.Int).Value = paper_format;
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

        public virtual void UpdateInfo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            if (colont == 0 || numeration == 0)
            {
                if (colont == 0)
                    com.CommandText = @"UPDATE GeneralInformation set [work_title]=@WorkTitle,[orientation]=@Orient,[up_field]=@UpField,
                                        [bottom_field]=@BotField,[left_field]=@LeftField,[right_field]=@RightField,[min_vol_pages]=@MinVol,
                                        [max_vol_pages]=@MaxVol,[colont]=NULL,[numeration]=@Num,[paper_format]=@PFormat
                                        where work_id = @Work_id";   // вставка значений, соответствующих заполненным полям
                if (numeration == 0)
                    com.CommandText = @"UPDATE GeneralInformation set [work_title]=@WorkTitle,[orientation]=@Orient,[up_field]=@UpField,
                                        [bottom_field]=@BotField,[left_field]=@LeftField,[right_field]=@RightField,[min_vol_pages]=@MinVol,
                                        [max_vol_pages]=@MaxVol,[colont]=@Colont,[numeration]=NULL,[paper_format]=@PFormat
                                        where work_id = @Work_id";   // вставка значений, соответствующих заполненным полям
                if (colont == 0 && numeration == 0)
                    com.CommandText = @"UPDATE GeneralInformation set [work_title]=@WorkTitle,[orientation]=@Orient,[up_field]=@UpField,
                                        [bottom_field]=@BotField,[left_field]=@LeftField,[right_field]=@RightField,[min_vol_pages]=@MinVol,
                                        [max_vol_pages]=@MaxVol,[colont]=NULL,[numeration]=NULL,[paper_format]=@PFormat
                                        where work_id = @Work_id";   // вставка значений, соответствующих заполненным полям
            }
            else
                com.CommandText = @"UPDATE GeneralInformation set [work_title]=@WorkTitle,[orientation]=@Orient,[up_field]=@UpField,
                                        [bottom_field]=@BotField,[left_field]=@LeftField,[right_field]=@RightField,[min_vol_pages]=@MinVol,
                                        [max_vol_pages]=@MaxVol,[colont]=@Colont,[numeration]=@Num,[paper_format]=@PFormat
                                         where work_id = @Work_id";   // вставка значений, соответствующих заполненным полям
            com.Parameters.Add("WorkTitle", SqlDbType.VarChar, work_title.Length).Value = work_title;
            com.Parameters.Add("Orient", SqlDbType.Int).Value = orient;
            com.Parameters.Add("UpField", SqlDbType.Real).Value = up_field;
            com.Parameters.Add("BotField", SqlDbType.Real).Value = bot_field;
            com.Parameters.Add("LeftField", SqlDbType.Real).Value = left_field;
            com.Parameters.Add("RightField", SqlDbType.Real).Value = right_field;
            com.Parameters.Add("MinVol", SqlDbType.Int).Value = min_volume;
            com.Parameters.Add("MaxVol", SqlDbType.Int).Value = max_volume;
            com.Parameters.Add("Colont", SqlDbType.Int).Value = colont;
            com.Parameters.Add("Num", SqlDbType.Int).Value = numeration;
            com.Parameters.Add("PFormat", SqlDbType.Int).Value = paper_format;
            com.Parameters.Add("Work_id", SqlDbType.Int).Value = work_id;
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

        public virtual void DeleteInfo() // удаление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"delete from GeneralInformation    
                                where work_id = @Work_id";   // запрос на удаление по id
            com.Parameters.Add("Work_id", SqlDbType.Int).Value = work_id;
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

        public static int LastWork()   // просмотр работ 
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");

            SqlCommand com = con.CreateCommand();

            com.CommandText = @"SELECT MAX([dbo].[GeneralInformation].[work_id]) 
                                                FROM [dbo].[GeneralInformation]";
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable infos = new System.Data.DataTable();
            try
            {
                con.Open();
                adapter.Fill(infos);
            }
            finally
            {
                con.Close();
            }
            return int.Parse(infos.Rows[0][0].ToString());
        }
        public virtual void DeleteBlankInfo() // удаление работы
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"delete from GeneralInformation    
                                where work_id = (SELECT MAX([dbo].[GeneralInformation].[work_id]) 
                                                FROM [dbo].[GeneralInformation])";   // запрос на удаление по id
            
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
                            from GeneralInformation
                            where work_id = @workID";
            com.Parameters.Add("workID", SqlDbType.Int).Value = work_id;  // запрос на выборку работ по id
            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    work_title = reader[1].ToString();               //присваивание 
                    if (reader[2].ToString() != "")
                        orient = (int)reader[2];            //свойствам работы
                    up_field = double.Parse(reader[3].ToString());         //значений
                    bot_field = double.Parse(reader[4].ToString());        //прочитываемых
                    left_field = double.Parse(reader[5].ToString());             //после
                    right_field = double.Parse(reader[6].ToString());               //выполнения
                    min_volume = (int)reader[7];      //запроса
                    max_volume = (int)reader[8];
                    if (reader[9].ToString()!="")
                        colont = (int)reader[9];
                    if (reader[10].ToString()!="")
                        numeration = (int)reader[10];
                    if (reader[11].ToString() != "")
                        paper_format = (int)reader[11];        //на выборку
                }
            }
            finally
            {
                con.Close();
            }
        }

        public void LoadOrientation(ref DataTable dtOrient)   // загрузка таблицы ориентация данными из БД
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select * from Orientation";
            dtOrient = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            try
            {
                con.Open();
                adapter.Fill(dtOrient);
            }
            finally
            {
                con.Close();
            }
        }

        public void LoadPFormats(ref DataTable dtPaperFormats)   // загрузка таблицы форматы бумаги данными из БД
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");
            SqlCommand com = con.CreateCommand();
            com.CommandText = @"select * from PaperFormat";
            dtPaperFormats = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            try
            {
                con.Open();
                adapter.Fill(dtPaperFormats);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
