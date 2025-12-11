using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GroshevID.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            HashSet<double> values = new HashSet<double>();
            double F;

            for (int x = startValue; x <= stopValue; x++)
            {
                F = (5*x + 2.5) / (Math.Sin(x) + 3) + 2*x + Math.Cos(x);
                values.Add(Math.Round(F, 2));
            }

            return values.ToArray();
        }
    }
}
