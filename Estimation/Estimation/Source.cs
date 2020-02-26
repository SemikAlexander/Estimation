using System;
using System.Collections.Generic;
using Estimation.Properties;

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
            try
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
            catch(Exception ex)
            {

            }
        }
        public void DeleteData(int index, int choiseCurrency)
        {
            try
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
            catch (Exception)
            {

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
        public int GetSum()
        {
            double maxUSD = dollar.Count != 0 ? dollar[0].Course : -1,
                maxEUR = euro.Count != 0 ? euro[0].Course : -1,
                maxUAH = hryvnia.Count != 0 ? hryvnia[0].Course : -1;

            foreach (var USD in dollar)
                if (USD.Course > maxUSD)
                    maxUSD = USD.Course;
            foreach (var EUR in euro)
                if (EUR.Course > maxEUR)
                    maxEUR = EUR.Course;
            foreach (var UAH in hryvnia)
                if (UAH.Course > maxUAH)
                    maxUAH = UAH.Course;

            int resUSD = 0, resEUR = 0, resUAH = 0, result = 0;
            foreach(var USD in saleDollar)
            {
                if (USD.Course == Convert.ToDouble(Settings.Default["DollarPurchase"].ToString()))
                    resUSD += Convert.ToInt32(USD.Sum * (USD.Course - Convert.ToDouble(Settings.Default["DollarPurchase"].ToString())));
                else
                    resUSD += Convert.ToInt32(USD.Sum * (USD.Course - maxUSD));
            }
            foreach (var EUR in saleEuro)
            {
                if (EUR.Course == Convert.ToDouble(Settings.Default["EuroPurchase"].ToString()))
                    resEUR += Convert.ToInt32(EUR.Sum * (EUR.Course - Convert.ToDouble(Settings.Default["EuroPurchase"].ToString())));
                else
                    resEUR += Convert.ToInt32(EUR.Sum * (EUR.Course - maxEUR));
            }
            foreach (var UAH in saleHryvnia)
            {
                if (UAH.Course == Convert.ToDouble(Settings.Default["HryvnaPurchase"].ToString()))
                    resUAH += Convert.ToInt32(UAH.Sum * (UAH.Course - Convert.ToDouble(Settings.Default["HryvnaPurchase"].ToString())));
                else
                    resUAH += Convert.ToInt32(UAH.Sum * (UAH.Course - maxUAH));
            }
            return resUSD + resEUR + resUAH;
        }
    }
}