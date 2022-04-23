using System;

namespace _07_02_singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = A.CreateA();
            a1.Name = "birinci A";

            A a2 = A.CreateA();


            A a3 = A.CreateA();
        }
    }

    public class A
    {
        public static A Ainstance;

        public string Name;
        public static A CreateA()
        {
            lock (new object())
            {
                if (Ainstance == null)
                {

                    Ainstance = new A();
                }
            }
            return Ainstance;
        }

    }
}
