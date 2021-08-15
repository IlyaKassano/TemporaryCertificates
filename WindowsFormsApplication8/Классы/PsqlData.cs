using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
	static class PsqlData
	{

        public static Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
            "Password=1;Database=tempcert;");

        //Создание локальной таблицы
        public static DataSet ds = new DataSet();

        /// <summary>  
        ///  Попытка подключиться к базе данных.
        ///  В случае ошибки выбрасывает исключение.
        /// </summary>  
        public static void TryConnectToBD()
        {
            try
            {
                PsqlData.connection.Open();
            }
            catch (Npgsql.NpgsqlException)
            {
                MessageBox.Show("Ошибка подключения к базе данных!", "Ошибка");
                Environment.Exit(0);
            }
            PsqlData.connection.Close();
        }

        /// <summary>  
        ///  Заполнение таблицы БД информацией через запрос
        /// </summary>  
        public static void Table_Fill(string name, string sql)
        {
            if (ds.Tables[name] != null)
                ds.Tables[name].Clear();
            Npgsql.NpgsqlDataAdapter da;
            da = new Npgsql.NpgsqlDataAdapter(sql, connection);
            try
            {
                da.Fill(ds, name);
            }
            catch (Npgsql.NpgsqlException)
            {
                MessageBox.Show("Ошибка при добавлении данных в БД", "Ошибка");
            }

            connection.Close();
        }

        /// <summary>  
        ///  Обработка запроса к БД
        /// </summary> 
        public static bool Mod_Execute(string sql)
        {
            Npgsql.NpgsqlCommand command = null;
            command = new Npgsql.NpgsqlCommand(sql, connection);
            connection.Open();
            try
            {
                command.ExecuteReader();
            }
            catch (Npgsql.NpgsqlException)
            {
                MessageBox.Show("Обновление базы данных не было выполнено из-за не указания обновляемых данных" +
                    " или несоответствия их типов", "Ошибка");
                connection.Close();
                return false;
            }
            connection.Close();
            return true;
        }
    }
}
