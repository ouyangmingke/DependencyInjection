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
            /****控制反转（IOC Inversion Of Control）
             * 通过将控制权脱离，由第三方来做
             * 
             * 依赖注入是其典型的实现方法
             * 
             * 用户 需要一部手机
             * 如果在用户类中去创建手机,当手机功能需要修改或者说需要更换一部手机
             * 那么我们需要到用户类中一步步修改就很麻烦
             * 
             * 但是如果我们在外部进行手机的创建,就降低了     耦合
             * 
             * 这个手机就是用户的                            依赖
             * 而外部对其创建并交给用户使用就是              依赖注入
             * 
             **********/

            Person xiaoMing = new XiaoMing("小眀", 12, new Iphone6s("IP6"));
            xiaoMing.Read();
            xiaoMing.Play();
            xiaoMing.Grab();
            Console.WriteLine();

            xiaoMing = new XiaoHong("小红", 12, new IphoneX("IPX"));
            xiaoMing.Read();
            xiaoMing.Play();
            xiaoMing.Grab();
            Console.Read();

        }
    }
}
