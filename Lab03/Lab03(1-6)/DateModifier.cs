using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab03
{
    //problem 5
    public class DateModifier
    {
        public int CalcDifference(string firstDateInput, string secondDateInput)
        {
            string[] firstDateVal = firstDateInput.Split(" ");
            string[] secondDateVal = secondDateInput.Split(" ");

            DateTime firstDate = new DateTime(int.Parse(firstDateVal[0]), int.Parse(firstDateVal[1]), int.Parse(firstDateVal[2]));
            DateTime secondDate = new DateTime(int.Parse(secondDateVal[0]), int.Parse(secondDateVal[1]), int.Parse(secondDateVal[2]));
            int result = firstDate.Subtract(secondDate).Days;
            return result < 0 ? secondDate.Subtract(firstDate).Days : result;
        }
    }
}
