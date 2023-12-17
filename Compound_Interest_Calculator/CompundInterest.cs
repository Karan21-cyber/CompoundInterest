using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest_Calculator
{
   public class CompundInterest
    {
        private double principal;
        private double monthlyAmount;
        private double timeOfYear;
        private double rate;

        public CompundInterest()
        {
        }
        public CompundInterest(double principal, double monthlyAmount, double timeOfYear, double rate)
        {
            this.principal = principal;
            this.monthlyAmount = monthlyAmount;
            this.timeOfYear = timeOfYear;
            this.rate = rate;
        }

       

        public double Principal { get { return principal; } set { principal = value; } }

        public double MonthlyAmount { get {  return monthlyAmount; } set {  monthlyAmount = value; } }
        public double TimeOfYear { get {  return timeOfYear; } set {  timeOfYear = value; } }
        public double Rate { get { return rate; } set { rate = value; } }

        public double Calculate(double annualRate, int CompoundFrequency)
        {
            double total = principal;
            double ratePerPeriod = annualRate / CompoundFrequency / 100;
            double totalPeriods = timeOfYear * CompoundFrequency;
            for(int i = 0; i < totalPeriods;i++)
            {
                total += monthlyAmount;
                total *= (1 + ratePerPeriod);
            }

            return total;
        }

        public double CalculateAnnually()
        {
            
            return Calculate(rate,1);
        }


        public double CalculateSemiAnnually()
        {
            return Calculate(rate,2);
        }

        public double CalculateQuartarly()
        {
            return Calculate(rate,4) ;
        }

        public double CalculateMonthly()
        {

            return Calculate(rate,12);
        }
    }
}
