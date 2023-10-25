using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Exceptions
{
    internal class Program
    {
        static int _count = 0;

        static void Main(string[] args)
        {
            var info = new Info() { First = 1, Second = 2 };
            BinaryFormatter formatter = new BinaryFormatter();
            //using (var stream = File.OpenWrite("MyFile"))
            //{
            //    formatter.Serialize(stream, info);
            //}
            using (var stream = File.OpenRead("MyFile"))
            {
                Console.WriteLine(((Info)formatter.Deserialize(stream)).First);
            }
        }

        static void Method1() => Method2();

        static void Method2() => throw new MyException("Wee");
    }

    public class MyException : ArgumentException
    {
        public MyException(string m) : base(m) { }
        public MyException(string m, Exception inner) : base(m, inner) { }
    }

    [Serializable]
    class Info
    {
        public int First { get; set; }
        public int Second { get; set; }
    }
}
