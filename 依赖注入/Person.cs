using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    /// <summary>
    /// 抽象类  人
    /// </summary>
    public abstract class Person
    {

        private string _Name;
        private int _Age;

        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }
    }

    /// <summary>
    /// 小眀 继承自 人
    /// </summary>
    public class XiaoMing : Person
    {
        /// <summary>
        /// 重载构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public XiaoMing(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Read()
        {
            Iphone6s iphone6S = new Iphone6s("Ip6");
            iphone6S.Zhihu();
        }
        public void play()
        {
            Iphone6s iphone6S = new Iphone6s("Ip6");
            iphone6S.Wangzhe();

        }
        public void grab()
        {
            Iphone6s iphone6S = new Iphone6s("Ip6");
            iphone6S.Hongbao();
        }


    }

}
