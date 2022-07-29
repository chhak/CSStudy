using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _06_09
    {
        static void Main9(string[] args)
        {
            // 데이터베이스 접속 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "????????";
            string password = "????????";
            string database = "????????";

            Console.WriteLine("********************************");
            Console.WriteLine("데이터 매니저 프로그램 v1.0");
            Console.WriteLine("********************************");

            while (true)
            {
                string strConn = $"server={server};";
                strConn += $"port={port};";
                strConn += $"username={username};";
                strConn += $"password={password};";
                strConn += $"database={database}";

                MySqlConnection conn = new MySqlConnection(strConn);

                Console.WriteLine("종료:0, 입력:1, 전체조회:2");
                Console.Write("선택 : ");

                int answer = int.Parse(Console.ReadLine());

                if (answer == 0)
                {
                    break;
                }
                else if (answer == 1)
                {
                    Console.Write("아이디 : ");
                    string uid = Console.ReadLine();

                    Console.Write("이름 : ");
                    string name = Console.ReadLine();

                    Console.Write("휴대폰 : ");
                    string hp = Console.ReadLine();

                    Console.Write("나이 : ");
                    int age = int.Parse(Console.ReadLine());

                    try
                    {
                        conn.Open();

                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO `user2`" +
                        " VALUES ('" + uid + "','" + name + "','" + hp + "'," + age + ")";

                        ????????????????????????
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        conn.Close();
                        Console.WriteLine("입력완료...");
                        Console.WriteLine();
                    }
                }
                else if (answer == 2)
                {
                    try
                    {
                        conn.Open();

                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT * FROM `user2`";

                        MySqlDataReader reader = ????????????????????????
                        while (reader.Read())
                        {
                            Console.WriteLine("{0},{1},{2},{3}", reader[0],
                                                                 reader[1],
                                                                 reader[2],
                                                                 reader[3]);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        conn.Close();
                        Console.WriteLine("조회완료...");
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("프로그램 종료...");
        }
    }
}
