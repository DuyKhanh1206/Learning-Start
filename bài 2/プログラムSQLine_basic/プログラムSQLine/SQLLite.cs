using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace プログラムSQLine
{

    public class ClsSQLite
    {
        /// <summary>SQLLiteのファイルパス string đường dãn SQlite</summary>
        public string _sqlFilePath ;

        /// <summary>コンストラクタ</summary>
        public ClsSQLite(string sqlFilePath)
        {
            _sqlFilePath = sqlFilePath;
        }

        public void ExecuteNoneQuery(string sql)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_sqlFilePath))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();

            using (SQLiteConnection connection = new SQLiteConnection(_sqlFilePath))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;

                    // DataAdapterの生成 / load all data
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                    // データベースからデータを取得
                    da.Fill(dt);
                }
            }
            return dt;
        }

    }
}
