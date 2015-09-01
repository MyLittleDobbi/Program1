using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class Class1
    {
        public int j;
        public void F()
        {
            j++;
          
        }
        public int a;
        public int f()
        {
            //while (true) { }
            return 3;
        }
    }
    class Class2 :Class1
    {
        public int b=45;
        public int B { set; get; }
        public Class2()
        {
           // b =a;
            i++;
        }
        public int dF()
        {
            b = B;
            return b;
        }
        private static int i = 0;
        new public int f( ) 
        {
            //while (true) { }
            return 2;
        }
    }
    public class A
    {
        public int pub { get; set;}
        private int pri { get; set; }
        protected int pro { get; set; }
    }



    public interface A1
    {

    }
    public interface A3
    {

    }
    public class A2
    {


    }
    public class B: A2 , A1 
    {


    }
}
