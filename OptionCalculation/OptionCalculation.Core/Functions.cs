using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionCalculation.Core
{
    public class Functions
    {

        public StartConditions sc;

        public Functions(StartConditions sc)
        {
            this.sc = sc;
        }

        public int Fact(int n)
        {
            int res = 1;

            for (int i = n; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }

        public double ProbabilityInscrease(double r, double a, double b)
        {
            return (double)(r - a) / (b - a);
        }

        public double ProbabilityDecrease(double r, double a, double b)
        {
            return 1 - (r - a) / (b - a);
        }

        public double FindFN(double S0, double a, double b, double n ,double k)
        {
            var p = ProbabilityInscrease(sc.R, a, b);
            var q = ProbabilityDecrease(sc.R, a, b);

            double FN = 0;

            for (var i = 0; i < sc.N + 1; i++)
            {
                FN += Math.Max(0, ( sc.S0 * (Math.Pow((1 + b), i))  * (Math.Pow((1 + a), sc.N - i)) - k) ) * (Fact(sc.N)/Fact(i)*Fact(sc.N - i)) * (Math.Pow(p,i)) * (Math.Pow(q, sc.N - i)) ;
            }

            return FN;
        }

        public double FindCN()
        {
            double Fn = FindFN(sc.S0, sc.a, sc.b, sc.N, sc.K);
            double Cn = 1/Math.Pow(((1 + sc.R)), sc.N) * Fn;
            return Cn;
        }

        public double GetPrevSharesCost()
        {
            return sc.S0;
        }

        public double GetIncreasedSharesCost(double cost, double b)
        {
            return cost + b * cost;
        }

        public double GetLoweredSharesCost(double cost, double a)
        {
            return cost + a * cost;
        }


        public double GetPrevBondsCost()
        {
            return sc.B0;
        }

        public double GetIncreasedBondsCost(double cost, double b)
        {
            return cost + b * cost;
        }

        public double GetLoweredBondsCost(double cost, double a)
        {
            return cost + a * cost;
        }

        public double FindFnMinusCurrStepA(double sharesCost, int currStep, double a, double b, int N, double K)
        {
            var p = ProbabilityInscrease(sc.R, a, b);
            var q = ProbabilityDecrease(sc.R, a, b);

            double FnCurrStepA = 0;
            int index = N - currStep + 1;
            int index1 = N - currStep;

            for (int i = 0; i < index; i++)
            {
                double num = Math.Max(0, ( sharesCost * ( 1 + a ) * (Math.Pow((1 + b), i))  * (Math.Pow((1 + a), index1 - i)) - K) ) * (Fact(index1)/Fact(i)*Fact(index1 - i)) * (Math.Pow(p,i)) * (Math.Pow(q, index1 - i)) ;
                FnCurrStepA += num;
            }
            return FnCurrStepA;
        }

        public double FindFnMinusCurrStepB(double sharesCost, int currStep, double a, double b, int N, double K)
        {
            var p = ProbabilityInscrease(sc.R, a, b);
            var q = ProbabilityDecrease(sc.R, a, b);

            double FnCurrStepB = 0;
            int index = N - currStep + 1;
            int index1 = N - currStep;

            for (int i = 0; i < index; i++)
            {
                double num = Math.Max(0, (sharesCost * (1 + b) * (Math.Pow((1 + b), i)) * (Math.Pow((1 + a), index1 - i)) - K)) * (Fact(index1) / Fact(i) * Fact(index1 - i)) * (Math.Pow(p, i)) * (Math.Pow(q, index1 - i));
                FnCurrStepB += num;
            }
            return FnCurrStepB;
        }


        public double FindGamma(int currStep, double sharesCost)
        {
            double FnCurrA = FindFnMinusCurrStepA(sharesCost, currStep, sc.a, sc.b, sc.N, sc.K);
            double FnCurrB = FindFnMinusCurrStepB(sharesCost, currStep, sc.a, sc.b, sc.N, sc.K);

            double gamma = Math.Pow((1 / (1 + sc.R)), sc.N - currStep) * (FnCurrB - FnCurrA)/(sharesCost*(sc.b-sc.a));

            return gamma;
        }

        public double FindBetta(double x, double gamma, double sharesCost, double boundCost)
        {
            return (double)(x - (double)gamma * sharesCost) / boundCost;
        }
    }
}
