using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KosovskihVA.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public double Calculation(List<double> data, string mode)
        {
            switch (mode)
            {
                case "Count":
                    {
                        return data.Count();
                    }
                case "Sum":
                    {
                        double result = 0;
                        foreach (var item in data)
                        {
                            result += item;
                        }
                        return result;
                    }
                case "Mid":
                    {
                        return Calculation(data, "Count") / Calculation(data, "Sum"); 
                    }
                case "Min":
                    {
                        return data.Min();
                    }
                case "Max":
                    {
                        return data.Max();
                    }
                default: { return double.NaN; }
            }
        }
        public bool Comparison(double value, int filter, int mode)
        {
            switch (mode)
            {
                case 0:
                    return value > filter;
                case 1:
                    return value < filter;
                default:
                    return false;
            }
        }
    }
}
