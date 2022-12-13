using LabbCleanCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.ConsolIO
{
    public class ConsolIO : IUI
    {
        public void Clear()
        {
            //nothing
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
