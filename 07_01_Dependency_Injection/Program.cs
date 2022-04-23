using System;

namespace _07_01_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //A instanceA = new A();
            ////instanceA = null;
            //A instanceA2 = new A();
            //method1DI();
            Context ctx = new Context();

            Repository rep1 = new Repository(ctx);
            rep1.SaveRepo();

            Repository rep2 = new Repository(ctx);
            rep2.SaveRepo();

            

            

        }

        private static void method1DI()
        {
            B b = new B();
            A instanceA = new A(b);
            A instanceA2 = new A(b);
            instanceA = null;
            instanceA2 = null;
        }


    }

    public class Repository
    {
        
        Context _context;
        public Repository(Context ctx)
        {
            _context = ctx;
           // _context = new Context();
        }

        public void SaveRepo()
        {
            _context.Kaydet();
        }
    }

    public class Context
    {
        public void Kaydet()
        {
            Console.WriteLine("Mssql Db ye lkayıt yapıldı");
        }
    }

    public class A
    {
        B _b;
        public A(B b)
        {
            //_b = new B();
            _b = b;
           
        }
        
    }

    public class B
    {
        
    }
}
