using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GroshevID.Sprint6.Task1.V13.Lib
{
    public class DataService : ISprint6Task1V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            HashSet<double> values = new HashSet<double>();
            double F;
            
            for ( int x = startValue; x <= stopValue; x++ )
            {
                F = 3 * Math.Cos(x) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2;
                values.Add(F);
            }

            return values.ToArray();
        }
    }
}
