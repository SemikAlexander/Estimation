using System;
using System.Collections.Generic;

namespace Estimation
{
    public class Source
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
        public int startRub = 0;

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
                case "purchase":
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
        public int GetProfitByDollar()
        {
            int startUSD = 0, comeUSD = 0, saleUSD = 0;
            foreach (var start in startDollar)
                startUSD += start.Sum;
            foreach (var come in dollar)
                comeUSD += come.Sum;
            foreach (var sale in saleDollar)
                saleUSD += sale.Sum;
            return (startUSD + comeUSD) - saleUSD;
        }
        public int GetProfitByEuro()
        {
            int startEUR = 0, comeEUR = 0, saleEUR = 0;
            foreach (var start in startEuro)
                startEUR += start.Sum;
            foreach (var come in euro)
                comeEUR += come.Sum;
            foreach (var sale in saleEuro)
                saleEUR += sale.Sum;
            return (startEUR + comeEUR) - saleEUR;
        }
        public int GetProfitByHryvna()
        {
            int startUAH = 0, comeUAH = 0, saleUAH = 0;
            foreach (var start in startHryvnia)
                startUAH += start.Sum;
            foreach (var come in hryvnia)
                comeUAH += come.Sum;
            foreach (var sale in saleHryvnia)
                saleUAH += sale.Sum;
            return (startUAH + comeUAH) - saleUAH;
        }
    }
}