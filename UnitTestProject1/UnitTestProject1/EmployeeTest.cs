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
        [TestMethod]
        public void TestCalcSalary()
        {
            Employee employee = new Employee(2, "田中", 100);
            Assert.AreEqual(201, employee.Salary());
        }

        [TestMethod]
        public void TestPoliteExpression()
        {
            Employee employee = new Employee(3, "砂金", 100);
            Assert.AreEqual("砂金さん", employee.PoliteName());
        }
    }
}
