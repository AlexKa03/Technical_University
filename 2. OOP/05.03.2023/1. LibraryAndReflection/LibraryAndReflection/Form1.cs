using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAndReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindingFlags bf = BindingFlags.Static;
            var my = new MyClass("ME", 2);
            var fieldName = my.GetType().GetField("_name", BindingFlags.NonPublic | BindingFlags.Instance);
            var fieldCount = typeof(MyClass).GetField("_count", BindingFlags.NonPublic | BindingFlags.Static);
            int c = 1;
            c += (int)fieldCount.GetValue(my);
            Text = fieldName.GetValue(my).ToString() + " " + c;
            bf ^= BindingFlags.Static;
            if (bf.HasFlag(BindingFlags.Static))
            {
                Text = true.ToString();
            }
            Text = ((int)typeof(MyClass)
                .GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Static)
                .Invoke(null, new object[] { 1, 2 }))
                .ToString();


        }
    }

    class MyClass
    {
        private static int _count;
        private readonly string _name;

        public MyClass(string name, int count)
        {
            _name = name;
            _count = count;
        }

        private static int Add(int a, int b) => a + b;
    }
}
