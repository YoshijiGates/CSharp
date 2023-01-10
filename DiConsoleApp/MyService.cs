using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiConsoleApp
{
    public class MyService : IMyService
    {
        public void getValue()
        {
            Debug.WriteLine("MyService コンストラクタ");
        }
    }
}
