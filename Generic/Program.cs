/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{//Generic Version 2.0 lettiest
 //5.0.1--letiest version in Dot net
 //Generics <>(Placeholed hi Generic ko difined krta hain)


    class Order
    {
        //Boxing:-boxing is proccess two convert  value type to refrence type  is colled boxing
        //Unboxing :-Refrence type to value type conversion is colled unboxing 
        
        static void Main(string[] args)
        {
            int i = 100;
            object obj = i;
            int l = (int)obj;//UNBOXING
            List<string> list = new List<string>();
            Test(10.23);
            Order.Test
        }
        public static void Test<T>(T msg)//method Generic
        {
        }
    }
}*/
//we can decleared class as Generic and Method also
using System;
using System.Collections;
using System.Collections.Generic;

public class Order
{
    public static void Main()
    {
        ArrayList item = new ArrayList();
        item.Add("test");
        item.Add(true);
        item.Add('c');
        item.Add(101);
        List<bool> list = new List<bool>();//it will take only bool value
        list.Add(101);
        list.Add(true);
        list.Add("test");


    }
}