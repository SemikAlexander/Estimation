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

        public List<Currency> startDollar = new List<Currency>();
        public List<Currency> startEuro = new List<Currency>();
        public List<Currency> startHryvnia = new List<Currency>();

        public List<Currency> saleDollar = new List<Currency>();
        public List<Currency> saleEuro = new List<Currency>();
        public List<Currency> saleHryvnia = new List<Currency>();

        public void AddData(string curse, string price, int choiseCurrency, string act)
        {
            switch (act)
            {
                case "purchase":
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
                    break;
                case "sale":
                    switch (choiseCurrency)
                    {
                        case 0:
                            currency.Course = Convert.ToDouble(curse);
                            currency.Sum = Convert.ToInt32(price);
                            saleDollar.Add(currency);
                            break;
                        case 1:
                            currency.Course = Convert.ToDouble(curse);
                            currency.Sum = Convert.ToInt32(price);
                            saleEuro.Add(currency);
                            break;
                        case 2:
                            currency.Course = Convert.ToDouble(curse);
                            currency.Sum = Convert.ToInt32(price);
                            saleHryvnia.Add(currency);
                            break;
                    }
                    break;
            }
        }
        public void AddData(string curse, string price, int choiseCurrency)
        {
            switch (choiseCurrency)
            {
                case 0:
                    currency.Course = Convert.ToDouble(curse);
                    currency.Sum = Convert.ToInt32(price);
                    startDollar.Add(currency);
                    break;
                case 1:
                    currency.Course = Convert.ToDouble(curse);
                    currency.Sum = Convert.ToInt32(price);
                    startEuro.Add(currency);
                    break;
                case 2:
                    currency.Course = Convert.ToDouble(curse);
                    currency.Sum = Convert.ToInt32(price);
                    startHryvnia.Add(currency);
                    break;
            }
        }
        public void DeleteData(int index, int choiseCurrency, string act)
        {
            switch (act)
            {
                case "":
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
                    break;
                case "sale":
                    switch (choiseCurrency)
                    {
                        case 0:
                            saleDollar.RemoveAt(index);
                            break;
                        case 1:
                            saleEuro.RemoveAt(index);
                            break;
                        case 2:
                            saleHryvnia.RemoveAt(index);
                            break;
                    }
                    break;
            }
        }
        public void DeleteData(int index, int choiseCurrency)
        {
            switch (choiseCurrency)
            {
                case 0:
                    startDollar.RemoveAt(index);
                    break;
                case 1:
                    startEuro.RemoveAt(index);
                    break;
                case 2:
                    startHryvnia.RemoveAt(index);
                    break;
            }
        }
        public int GetStartSum(int choiseCurrency)
        {
            int res = 0;
            switch (choiseCurrency)
            {
                case 0:
                    foreach(var curr in startDollar)
                        res += Convert.ToInt32(curr.Sum * curr.Course);
                    return res;
                case 1:
                    foreach (var curr in startEuro)
                        res += Convert.ToInt32(curr.Sum * curr.Course);
                    return res;
                case 2:
                    foreach (var curr in startHryvnia)
                        res += Convert.ToInt32(curr.Sum * curr.Course);
                    return res;
            }
            return 0;
        }

        public int GetStartSumInCurrency(int choiseCurrency)
        {
            int res = 0;
            switch (choiseCurrency)
            {
                case 0:
                    foreach (var curr in startDollar)
                        res += curr.Sum;
                    return res;
                case 1:
                    foreach (var curr in startEuro)
                        res += curr.Sum;
                    return res;
                case 2:
                    foreach (var curr in startHryvnia)
                        res += curr.Sum;
                    return res;
            }
            return 0;
        }
    }
}