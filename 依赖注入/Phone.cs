using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    /// <summary>
    /// 抽象类  手机
    /// </summary>
    public abstract class Phone
    {
        private string _Name;

        public string Name { get => _Name; set => _Name = value; }
    }


    /// <summary>
    /// Iphone6s 继承自 Phone
    /// </summary>
    public class Iphone6s : Phone
    {
        public Iphone6s(string name)
        {
            Name = name;
        }
        public void Zhihu()
        {
            Console.WriteLine("逛知乎 " + Name);
        }
        public void Wangzhe()
        {
            Console.WriteLine("玩农药 " + Name);
        }
        public void Hongbao()
        {
            Console.WriteLine("抢红包 " + Name);
        }

    }

}
