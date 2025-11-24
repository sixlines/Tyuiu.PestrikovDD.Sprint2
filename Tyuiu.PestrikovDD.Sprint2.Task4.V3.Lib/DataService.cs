using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PestrikovDD.Sprint2.Task4.V3.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double z;
            return Math.Round(z = x < (y - 1) ? (y + (y - 1) / (x + 2)) : (x + 2 * y * (1 / (y + 3))), 3);
        }
    }
}
