
namespace Problem_Solving
{
    public class FibonacciNumber
    {

        public static double GetFibonacciNumber(int elementLength)
        {
            double[] array = new double[elementLength];            
            if (elementLength == 1 || elementLength == 2)
                return 1;

            array[0] = array[1] = 1;

            for (int i = 2; i <elementLength; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[elementLength - 1];
        }

    }
}
