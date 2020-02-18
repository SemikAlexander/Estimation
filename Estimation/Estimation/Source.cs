using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimation
{
    class Source
    {
        public struct Currency
        {
            public int Sum;
            public double Course;
        }
        public Currency currency;
        public List<Currency> dollar = new List<Currency>();
        public List<Currency> euro = new List<Currency>();
        public List<Currency> hryvnia = new List<Currency>();

        public void AddData(string curse, string price, int choiseCurrency)
        {
            switch (choiseCurrency)
            {
                case 0:
                    currency.Course = Convert.ToDouble(curse);
                    currency.Sum = Convert.ToInt32(price);
                    dollar.Add(currency);
                    break;
                case 1:
                    currency.Course = Convert.ToDouble(curse);
                    currency.Sum = Convert.ToInt32(price);
                    euro.Add(currency);
                    break;
                case 2:
                    currency.Course = Convert.ToDouble(curse);
                    currency.Sum = Convert.ToInt32(price);
                    hryvnia.Add(currency);
                    break;
            }
        }
        public void DeleteData(int index, int choiseCurrency)
        {
            switch (choiseCurrency)
            {
                case 0:
                    dollar.RemoveAt(index);
                    break;
                case 1:
                    euro.RemoveAt(index);
                    break;
                case 2:
                    hryvnia.RemoveAt(index);
                    break;
            }
        }
    }
}
