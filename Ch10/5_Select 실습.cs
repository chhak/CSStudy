using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/07/27
 * 이름 : 김철학
 * 내용 : 데이터베이스 프로그래밍 실습
 */
namespace Ch10
{
    internal class _5_Select_실습
    {
        static void Main(string[] args)
        {
            // 데이터베이스 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            // 데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                // 데이터베이스 접속
                conn.Open();

                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";

                MySqlDataReader reader = cmd.ExecuteReader();

                // 결과출력                
                Console.WriteLine("{0},{1},{2},{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                while (reader.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3}", reader[0], reader[1], reader[2], reader[3]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("실패 : " + e.Message);
            }
            finally
            {
                // 데이터베이스 종료
                conn.Close();
                Console.WriteLine("종료...");
            }
        }
    }
}
