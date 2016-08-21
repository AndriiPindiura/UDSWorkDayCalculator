using CSharpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    [TestClass]
    public class WorkDayCalculatorTests
    {

        WeekEnd[] weekEnds = new WeekEnd[] {
                new WeekEnd(new DateTime(2016, 8, 6), new DateTime(2016, 8, 7)),
                new WeekEnd(new DateTime(2016, 8, 13), new DateTime(2016, 8, 14)),
                new WeekEnd(new DateTime(2016, 8, 20), new DateTime(2016, 8, 21)),
                new WeekEnd(new DateTime(2016, 8, 24), new DateTime(2016, 8, 24)),
                new WeekEnd(new DateTime(2016, 8, 27), new DateTime(2016, 8, 28)),
                new WeekEnd(new DateTime(2016, 9, 3), new DateTime(2016, 9, 4)),
                new WeekEnd(new DateTime(2016, 9, 10), new DateTime(2016, 9, 11)),
                new WeekEnd(new DateTime(2016, 9, 17), new DateTime(2016, 9, 18)),
                new WeekEnd(new DateTime(2016, 9, 24), new DateTime(2016, 9, 25)),
                new WeekEnd(new DateTime(2016, 10, 1), new DateTime(2016, 10, 2)),
                new WeekEnd(new DateTime(2016, 10, 8), new DateTime(2016, 10, 9)),
                new WeekEnd(new DateTime(2016, 10, 15), new DateTime(2016, 10, 16)),
                new WeekEnd(new DateTime(2016, 10, 1), new DateTime(2016, 10, 2)),
                new WeekEnd(new DateTime(2016, 10, 22), new DateTime(2016, 10, 23)),
                new WeekEnd(new DateTime(2016, 10, 29), new DateTime(2016, 10, 30)),
            };

        [TestMethod]
        public void TestNoWeekEnd()
        {
            DateTime startDate = new DateTime(2014, 12, 1);
            int count = 10;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, null);
            Assert.AreEqual(startDate.AddDays(count), result);
        }

        [TestMethod]
        public void TestWithWeekEnd()
        {
            DateTime startDate = new DateTime(2016, 8, 5);
            int count = 10;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 19), result);
        }

        [TestMethod]
        public void TestForMonth()
        {
            DateTime startDate = new DateTime(2016, 8, 1);
            int count = 31;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 9, 14), result);
        }

        [TestMethod]
        public void TestStartFromWeekends()
        {
            DateTime startDate = new DateTime(2016, 8, 6);
            int count = 10;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 19), result);
        }

        [TestMethod]
        public void TestWeekStartAtSunday()
        {
            DateTime startDate = new DateTime(2016, 8, 7);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 16), result);
        }

        [TestMethod]
        public void TestWeekStartAtMonday()
        {
            DateTime startDate = new DateTime(2016, 8, 1);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 10), result);
        }

        [TestMethod]
        public void TestWeekStartAtTuesday()
        {
            DateTime startDate = new DateTime(2016, 8, 2);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 11), result);
        }

        [TestMethod]
        public void TestWeekStartAtWednesday()
        {
            DateTime startDate = new DateTime(2016, 8, 3);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 12), result);
        }

        [TestMethod]
        public void TestWeekStartAtThursday()
        {
            DateTime startDate = new DateTime(2016, 8, 4);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 15), result);
        }

        [TestMethod]
        public void TestWeekStartAtFriday()
        {
            DateTime startDate = new DateTime(2016, 8, 5);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 16), result);
        }

        [TestMethod]
        public void TestWeekStartAtSaturday()
        {
            DateTime startDate = new DateTime(2016, 8, 6);
            int count = 7;
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 16), result);
        }

        //
        // Calendar 
        //
        [TestMethod]
        public void TestCalendarNoWeekEnd()
        {
            DateTime startDate = new DateTime(2016, 8, 1);
            int count = 10;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, null);
            Assert.AreEqual(new DateTime(2016, 8, 10), result);
        }

        [TestMethod]
        public void TestCalendarWithWeekEnd()
        {
            DateTime startDate = new DateTime(2016, 8, 5);
            int count = 10;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 18), result);
        }

        [TestMethod]
        public void TestCalendarForMonth()
        {
            DateTime startDate = new DateTime(2016, 8, 1);
            int count = 31;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 9, 13), result);
        }

        [TestMethod]
        public void TestCalendarStartFromWeekends()
        {
            DateTime startDate = new DateTime(2016, 8, 6);
            int count = 10;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 19), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtSunday()
        {
            DateTime startDate = new DateTime(2016, 8, 7);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 16), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtMonday()
        {
            DateTime startDate = new DateTime(2016, 8, 1);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 9), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtTuesday()
        {
            DateTime startDate = new DateTime(2016, 8, 2);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 10), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtWednesday()
        {
            DateTime startDate = new DateTime(2016, 8, 3);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 11), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtThursday()
        {
            DateTime startDate = new DateTime(2016, 8, 4);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 12), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtFriday()
        {
            DateTime startDate = new DateTime(2016, 8, 5);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 15), result);
        }

        [TestMethod]
        public void TestCalendarWeekStartAtSaturday()
        {
            DateTime startDate = new DateTime(2016, 8, 6);
            int count = 7;
            DateTime result = new WorkDayCalculatorCalendar().Calculate(startDate, count, this.weekEnds);
            Console.WriteLine(result);
            Assert.AreEqual(new DateTime(2016, 8, 16), result);
        }

    }
}
