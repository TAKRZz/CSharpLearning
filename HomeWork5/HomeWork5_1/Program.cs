using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
            //提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），
            //订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
            OrderService sys = new OrderService();
            sys.Start();

            return;
        }
    }
    public class OrderDetails
    {
        public string ItemName { get; set; }
        public string CusName { get; set; }
        public int OrderCost { get; set; }

        public override string ToString()
        {
            return ItemName + " " + CusName + " " + OrderCost;
        }

        public override bool Equals(object obj)
        {
            OrderDetails o1 = (OrderDetails)obj;
            return o1.CusName != this.CusName && this.ItemName != o1.ItemName && this.OrderCost != o1.OrderCost;
        }
        public OrderDetails() { }
        public OrderDetails(string itemName, string cusName, int orderCost)
        {
            ItemName = itemName;
            CusName = cusName;
            OrderCost = orderCost;
        }
    }
    public class Order
    {
        public Order() { }
        public int OrderNum { set; get; }
        public OrderDetails Details { set; get; }

        public override bool Equals(object obj)
        {
            Order o1 = (Order)obj;
            return this.OrderNum != o1.OrderNum && this.Details != o1.Details;
        }

        public override string ToString()
        {
            return this.OrderNum.ToString() + " " + this.Details.ToString();
        }
        public Order(int orderNum, OrderDetails details)
        {
            OrderNum = orderNum;
            Details = details;
        }
    }
    class OrderService
    {
        List<Order> list1 = new List<Order>();
        //添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。

        public void Start()
        {
            Import();
            ShowMenu();
            int n = -1;
            n = int.Parse(System.Console.ReadLine());
            while (n != 0)
            {
                switch (n)
                {
                    case 0:
                        Export();
                        System.Console.WriteLine("按下任意键以继续 ");
                        return;
                    case 1:
                        AddOrder();
                        break;
                    case 2:
                        DelOrder();
                        break;
                    case 3:
                        chaOrder();
                        break;
                    case 4:
                        SrcOrder();
                        break;
                    case 5:
                        ShowOrder();
                        break;
                    default:
                        Console.WriteLine("输入错误！  ");
                        System.Console.WriteLine("按下任意键以继续 ");
                        Console.Read();
                        break;
                }
                Console.Clear();
                ShowMenu();
                n = int.Parse(System.Console.ReadLine());
            }
        }

        public void ShuffleByNum()
        {
            list1.Sort((x, y) => x.OrderNum.CompareTo(y.OrderNum));
        }
        public void ShuffleByCost()
        {
            list1.Sort((x, y) => x.Details.OrderCost.CompareTo(y.Details.OrderCost));
        }
        public void ShowMenu()
        {
            System.Console.WriteLine("欢迎使用本系统！");
            System.Console.WriteLine("0. 退出系统");
            System.Console.WriteLine("1. 添加订单");
            System.Console.WriteLine("2. 删除订单");
            System.Console.WriteLine("3. 修改订单");
            System.Console.WriteLine("4. 查询订单");
            System.Console.WriteLine("5. 显示订单");
            System.Console.Write("输入序号： ");

        }
        public void AddOrder()
        {
            Console.WriteLine("输入订单编号： ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("输入商品名称： ");
            string str1 = Console.ReadLine();
            Console.WriteLine("输入顾客姓名： ");
            string str2 = Console.ReadLine();
            Console.WriteLine("输入订单价格： ");
            int n2 = int.Parse(Console.ReadLine());
            Order o1 = new Order(n1, new OrderDetails(str1, str2, n2));
            list1.Add(o1);
            ShuffleByNum();
            System.Console.WriteLine("添加成功！ ");
            System.Console.WriteLine("按下回车键以继续 ");
            string str = Console.ReadLine();
        }
        public void DelOrder()
        {
            System.Console.WriteLine("输入要删除的订单编号： ");
            int num1 = int.Parse(System.Console.ReadLine());
            int ind = IsExit(num1);
            if (ind == -1)
            {
                System.Console.WriteLine("无此编号！ ");
            }
            else
            {
                list1.RemoveAt(ind);
                System.Console.WriteLine("删除成功！ ");
            }
            System.Console.WriteLine("按下回车键以继续 ");
            string str = Console.ReadLine();
        }
        private int IsExit(int num1)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].OrderNum == num1)
                {
                    return i;
                }
            }
            return -1;
        }
        public void ShowOrder()

        {
            foreach (Order o1 in list1)
            {
                System.Console.WriteLine(o1.ToString());
            }
            System.Console.WriteLine("按下回车键以继续 ");
            string str = Console.ReadLine();
        }
        public void chaOrder()
        {
            System.Console.WriteLine("输入修改的订单号： ");
            int num1 = int.Parse(Console.ReadLine());
            int ind = IsExit(num1);
            if (ind == -1)
            {
                System.Console.WriteLine("订单号不存在！ ");
                System.Console.WriteLine("按下任意键以继续 ");
                char str1213 = (char)Console.Read();
                return;
            }
            else
            {
                Console.WriteLine("输入订单编号： ");
                int n1 = int.Parse(Console.ReadLine());
                if (IsExit(n1) != -1)
                {
                    System.Console.WriteLine("订单重复！ ");
                    System.Console.WriteLine("按下任意键以继续 ");
                    char str00 = (char)Console.Read();
                    return;
                }
                Console.WriteLine("输入商品名称： ");
                string str1 = Console.ReadLine();
                Console.WriteLine("输入顾客姓名： ");
                string str2 = Console.ReadLine();
                Console.WriteLine("输入订单价格： ");
                int n2 = int.Parse(Console.ReadLine());
                Order o1 = new Order(n1, new OrderDetails(str1, str2, n2));
                list1.RemoveAt(ind);
                list1.Insert(ind, o1);
                ShuffleByNum();
                System.Console.WriteLine("修改成功！ ");
                System.Console.WriteLine("按下回车键以继续 ");
                string str = Console.ReadLine();
            }

        }
        public void SrcOrder()
        {
            System.Console.WriteLine("0.返回主页 ");
            System.Console.WriteLine("1.订单编号");
            System.Console.WriteLine("2.商品名称");
            System.Console.WriteLine("3.客户姓名");
            System.Console.WriteLine("4.订单金额");
            System.Console.Write("输入选项： ");
            int n = int.Parse(System.Console.ReadLine());
            switch (n)
            {
                case 0:
                    return;
                case 1:
                    System.Console.WriteLine("输入订单编号： ");
                    int num1 = int.Parse(Console.ReadLine());
                    //foreach(Order o1 in list1){
                    //    if(o1.OrderNum == num1)
                    //    {
                    //        System.Console.WriteLine(o1.ToString());
                    //    }
                    //}
                    // 感觉linq没有直接用foreach来得快
                    ShuffleByCost();
                    var seq = from o1 in list1 where o1.OrderNum == num1 orderby o1.OrderNum select o1;
                    List<Order> l2 = seq.ToList();

                    foreach (Order o1 in l2)
                    {
                        System.Console.WriteLine(o1.ToString());
                    }
                    break;
                case 2:
                    ShuffleByCost();

                    System.Console.WriteLine("输入商品名称： ");
                    string str1 = Console.ReadLine();
                    foreach (Order o1 in list1)
                    {
                        if (o1.Details.ItemName == str1)
                        {
                            System.Console.WriteLine(o1.ToString());
                        }
                    }
                    break;
                case 3:
                    ShuffleByCost();

                    System.Console.WriteLine("输入商品名称： ");
                    string str2 = Console.ReadLine();
                    foreach (Order o1 in list1)
                    {
                        if (o1.Details.CusName == str2)
                        {
                            System.Console.WriteLine(o1.ToString());
                        }
                    }
                    break;
                case 4:
                    ShuffleByCost();

                    System.Console.WriteLine("输入订单编号： ");
                    int num2 = int.Parse(Console.ReadLine());
                    foreach (Order o1 in list1)
                    {
                        if (o1.Details.OrderCost == num2)
                        {
                            System.Console.WriteLine(o1.ToString());
                        }
                    }
                    break;
                default:
                    System.Console.WriteLine("输入错误！ ");
                    return;
            }
            System.Console.WriteLine("按下回车键以继续 ");
            string str = Console.ReadLine();
        }

        //e1. 在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
        public void Export()
        {
            if (list1 == null)
            {
                System.Console.WriteLine("当前订单为空！ ");
                System.Console.WriteLine("按下回车键以继续 ");
                string str = Console.ReadLine();
            }
            XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream("data.xml", FileMode.Create))
            {
                xmls.Serialize(fs, list1);
            }
        }
        public void Import()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream("data.xml", FileMode.Open))
            {
                list1 = (List<Order>)xmls.Deserialize(fs);
            }
        }
        //e2.对订单程序中OrderService的各个Public方法添加测试用例。


    }

}
