using Microsoft.VisualStudio.TestTools.UnitTesting;
using number_of_base;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Normal_1()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(12000, 1.7, 300, 400, 250, 123);
        }

        [TestMethod]
        public void Test_Normal_2()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(6000, 0.8, 1000, 400, 500, 600);
        }

        [TestMethod]
        public void Test_Normal_3()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(100, 0.8, 50, 40, 56, 61);
        }

        [TestMethod]
        public void Test_Zero()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(0, 0, 0, 0, 0, 0);
        }

        [TestMethod]
        public void Test_Fraction_1()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(0.25, 0.5, 0.25, 0.25, 0.25, 0.25);
        }

        [TestMethod]
        public void Test_Fraction_2()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(0.1925, 0.5, 0.265655, 0.0654, 0.05425, 0.005425);
        }

        [TestMethod]
        public void Test_Fraction_3()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(0.0086725, 0.5, 0.000525, 0.000045025, 0.0000454025, 0.00000455425);
        }

        [TestMethod]
        public void Test_Negative_Number()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base(-6000, -0.8, -1000, -400, -500, -600);
        }

        [TestMethod]
        public void Test_Char_1()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base('h', 0.6, 100, 45, 75, 96);
        }

        [TestMethod]
        public void Test_Char_2()
        {
            Class1 myClass = new Class1();
            int i = myClass.number_of_base('a', 'b', 'c', '3', 'q', '.');
        }

        
    }
}
