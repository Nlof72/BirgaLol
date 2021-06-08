using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs
{
    class Birga
    {
        public double rate;
        public int days = 0;

        private const double Sigma = 0.092;
        private const double Mu = 0.005;
        static double dt = 0.1;

        Person Person;
        Random random = new Random();

        private double GetNormalRandomValue()
        {
            double u1 =1- random.NextDouble();
            double u2 =1- random.NextDouble();
            if (random.NextDouble() > 0.5)
            {
                return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
            }
            else
            {
                return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            }

        }
        public Birga(double rate, Person person)
        {
            this.rate = rate;
            Person = person;
        }

        public decimal CalcCurs()
        {
            double RndValue = GetNormalRandomValue();
            rate *= Math.Exp((Mu - Math.Pow(Sigma, 2) / 2) * dt + Sigma * Math.Sqrt(dt) * RndValue);
            days++;
            return (decimal)rate;
        }

        public void SellDollars()
        {
            if (Person.score - rate < 0) return;
            Person.dollars++;
            Person.score -= rate + (0.3 * rate / 100);
        }

        public void BuyDollars()
        {
            if (Person.dollars - 1 < 0) return;
            Person.dollars--;
            Person.score += rate - (0.3* rate / 100);
        }
    }

    class Person
    {
        public double score = 1000;
        public double dollars = 0;
        public int loans=0;
    }
}
