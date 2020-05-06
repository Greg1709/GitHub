using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.controler;

namespace Test.view
{
    class EmployeViewTest
    {
        private EmpControler bobControler = new EmpControler(2);
        [Test]
        public void test()
        {
            
        }
        [Test]
        public void TestRequest()
        {
            List<string>[] vs;
            vs = bobControler.getConnect();
            Assert.IsNotNull(vs[1][1]);
        }
    }
}
