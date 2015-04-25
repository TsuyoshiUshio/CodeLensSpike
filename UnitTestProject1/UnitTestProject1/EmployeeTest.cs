using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestInitialize()
        {
            Employee employee = new Employee(1, "山田", 100);
            Assert.AreEqual(1, employee.Id);
            Assert.AreEqual("山田", employee.Name);
            Assert.AreEqual(100, employee.BaseSalary);
        }
    }
}
