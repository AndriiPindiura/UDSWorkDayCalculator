using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculatorCalendar : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if (weekEnds == null || weekEnds.Length < 1)
            {
                return startDate.AddDays(dayCount - 1);
            }
            else
            {
                DateTime resultDate = startDate;
                WeekEnd weekends = Array.Find(weekEnds, x => x.StartDate == resultDate || x.EndDate == resultDate);
                for (int i = weekends != null ? 0 : 1; i < dayCount ; i++)
                {
                    weekends = Array.Find(weekEnds, x => x.StartDate == resultDate || x.EndDate == resultDate);
                    resultDate = weekends != null ? resultDate.AddDays((weekends.EndDate - resultDate).Days + 1) : resultDate.AddDays(1);
                    weekends = Array.Find(weekEnds, x => x.StartDate == resultDate || x.EndDate == resultDate);
                    resultDate = weekends != null ? resultDate.AddDays((weekends.EndDate - resultDate).Days + 1) : resultDate;
                }
                return resultDate;
            }
        }
    }
}
