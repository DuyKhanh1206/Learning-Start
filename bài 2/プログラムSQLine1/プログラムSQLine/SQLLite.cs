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
        private  string _sqlFilePath ;

        /// <summary>コンストラクタ</summary>
        public ClsSQLite(string sqlFilePath)
            {
                _sqlFilePath = sqlFilePath;
            }


        /// <summary>SQLの実行 thực thi truy vấn</summary>
        public void ExecuteNoneQuery(string sql)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_sqlFilePath))
            {
                connection.Open();
                SQLiteTransaction trans = connection.BeginTransaction();
                try
                {
                    using (SQLiteCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
        
        /// <summary>SQLの実行（トランザクションあり）</summary>
        public void ExecuteNoneQueryWithTransaction(string[] sqls)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_sqlFilePath))
            {
                connection.Open();
                SQLiteTransaction trans = connection.BeginTransaction();

                try
                {
                    foreach (string sql in sqls)
                    {
                        using (SQLiteCommand cmd = connection.CreateCommand())
                        {
                            cmd.Transaction = trans;

                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        

        /// <summary>DataReaderを使ったデータの取得 Truy xuất dữ liệu bằng DataReader </summary>
        public IReadOnlyList<T> ExecuteReader<T>(string sql, Func<SQLiteDataReader, T> createEntity)
        {
            var result = new List<T>();

            using (SQLiteConnection connection = new SQLiteConnection(_sqlFilePath))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    //SQLの設定   truyền string sql vào cmd
                    cmd.CommandText = sql; 

                    //検索 load data sent to list
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(createEntity(reader));
                        }
                    }
                }
            }
            return result;
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
