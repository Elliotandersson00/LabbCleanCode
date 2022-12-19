using LabbCleanCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode
{
    public class ConsolIO : IUI
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void ExceptionStringHandler(string s, Exception e)
        {
           Console.WriteLine(s, e);
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }

        public string GetString()
        {
            return Console.ReadLine();
        }

        public void PutString(string s)
        {
            Console.WriteLine(s);
        }
    }
}
