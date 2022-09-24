using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CountTest1()
        {

            var message = Logic.Count(2);
            Assert.AreEqual("1 * 2 = 2\n"+ "2 * 2 = 4\n"+ "3 * 2 = 6\n"+ "4 * 2 = 8\n"+ "5 * 2 = 10\n" + "6 * 2 = 12\n" + "7 * 2 = 14\n" + "8 * 2 = 16\n" + "9 * 2 = 18\n" , message);
        }
        [TestMethod()]
        public void CountTest2()
        {

            var message = Logic.Count(15);
            Assert.AreSame("Введено неверное число, перезапустите программу и повторите попытку", message);
        }
        
        
    }
}