using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void UppercaseString()
        {
            string name = "adrian";

            name = name.ToUpper();

            Assert.AreEqual("ADRIAN", name);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;

            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void VariableHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Adrian's gradebook";

            Assert.AreEqual(g1.Name, g2.Name);

        }
    }
}
