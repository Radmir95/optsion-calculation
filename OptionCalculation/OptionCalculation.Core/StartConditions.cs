namespace OptionCalculation.Core
{
    public class StartConditions
    {
        public double S0 = 100;
        public double B0 = 10;
        public int N = 2;
        public double R = 0.1;
        public double a = -0.3;
        public double b = 0.4;
        public double K = 110;


        public StartConditions()
        {

        }

        public StartConditions(double S0, double B0, int N, double R, double a, double b, double K)
        {
            this.S0 = S0;
            this.B0 = B0;
            this.N = N;
            this.R = R;
            this.a = a;
            this.b = b;
            this.K = K;
        }

    }
}
