using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbCleanCode.Interfaces
{
    public interface IUI
    {
        void PutString(string s);
        string GetString();
        void Exit();
        void ExceptionStringHandler(string s, Exception e);
        void Clear();
    }
}
