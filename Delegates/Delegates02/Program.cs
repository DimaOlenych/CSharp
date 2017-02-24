using System;

namespace Delegates02
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Метод сообщенный с делегатом");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            MyDelegate myDelegate = new MyDelegate(instance.Method);
            myDelegate.Invoke();
            myDelegate();
        }
    }
}
