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

        /// <summary>
        /// 抽象方法    不能有方法体
        /// 子类必须实现全部抽象方法
        /// 除非子类也是抽象类
        /// </summary>
        public abstract void Read();

        public abstract void Play();

        public abstract void Grab();

    }

    /// <summary>
    /// 小眀 继承自 人
    /// </summary>
    public class XiaoMing : Person
    {

        /// <summary>
        /// readonly 只读常量  可以在构造方法中进行初始化
        /// </summary>
        private readonly Phone _Phone;

        /// <summary>
        /// 重载构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phone">通过外部实例化 Phone 来降低耦合</param>
        public XiaoMing(string name, int age, Phone phone)
        {
            Name = name;
            Age = age;
            _Phone = phone;
            Console.WriteLine("当前用户是：" + Name + " 年龄：" + Age + " 使用手机是：" + _Phone.Name);
        }

        public override void Read()
        {
            Console.Write("我是小眀 ");
            _Phone.Zhihu();
        }
        public override void Play()
        {
            Console.Write("我是小眀 ");
            _Phone.Wangzhe();

        }
        public override void Grab()
        {
            Console.Write("我是小眀 ");
            _Phone.Hongbao();
        }
    }

    /// <summary>
    /// 小红 继承自 人
    /// </summary>
    public class XiaoHong : Person
    {
        /// <summary>
        /// readonly 只读常量  可以在构造方法中进行初始化
        /// </summary>
        private readonly Phone _Phone;

        /// <summary>
        /// 重载构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phone">通过外部实例化 Phone 来降低耦合</param>
        public XiaoHong(string name, int age, Phone phone)
        {
            Name = name;
            Age = age;
            _Phone = phone;
            Console.WriteLine("当前用户是：" + Name + " 年龄：" + Age + " 使用手机是：" + _Phone.Name);
        }

        public override void Read()
        {
            Console.Write("我是小红 ");
            _Phone.Zhihu();
        }
        public override void Play()
        {
            Console.Write("我是小红 ");
            _Phone.Wangzhe();

        }
        public override void Grab()
        {
            Console.Write("我是小红 ");
            _Phone.Hongbao();
        }


    }

}
