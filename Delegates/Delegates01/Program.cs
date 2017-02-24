using System;

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Метод сообщенный с делегатом");
        }
    }

    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            myDelegate.Invoke();
            myDelegate();
        }
    }
}