using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._06
{
    internal class _06_01
    {
        static void Main1(string[] args)
        {
            Dictionary<string, string> colorDic = new Dictionary<string, string>();

            ????????????????????????
            ????????????????????????
            ????????????????????????


            try
            {
                colorDic.Add("red", "빨강");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("yellow : {0}", colorDic["yellow"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var v in colorDic)
            {
                Console.WriteLine("colorTable[{0}] : {1}", v.Key, v.Value);
            }

            Console.WriteLine("프로그램 종료...");
        }
    }
}
