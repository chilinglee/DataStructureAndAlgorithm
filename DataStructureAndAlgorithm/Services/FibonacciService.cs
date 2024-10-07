namespace Services;

public class FibonacciService
{
    /// <summary>
    /// 費波那切數列
    /// </summary>
    /// <param name="n">第 n 個數</param>
    /// <returns></returns>
    public static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if(n == 1)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
