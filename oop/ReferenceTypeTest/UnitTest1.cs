using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oop;

namespace ReferenceTypeTest
{
    [TestClass]
    public class UnitTest1
    {
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
        public void ValueTypePassbyValue()
        {
            int x = 46;
            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

       /* private void IncrementNumber(int number)
        {
            number += 1;
        }
        */

        //this method will effect the above because of the ref. 
        private void IncrementNumber(ref int number)
        {
            number += 1;
        }


        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);

        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }


        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scoot";
            string name2 = "scoot";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's grade book";

            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}
