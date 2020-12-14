using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            XiaoMing xiaoMing = new XiaoMing("小眀",12);
            xiaoMing.Read();
            xiaoMing.play();
            xiaoMing.grab();

        }
    }
}
