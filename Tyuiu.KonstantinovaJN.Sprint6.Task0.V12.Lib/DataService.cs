using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            double r = Math.Pow(x, 2) + 1;
            double t = Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            double res = r / t;
            return Math.Round(res, 3);
        }
    }
}
