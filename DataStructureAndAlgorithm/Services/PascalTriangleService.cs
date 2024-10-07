namespace Services;

class PascalTriangleService
{
    /// <summary>
    /// 巴斯卡三角形
    /// </summary>
    /// <param name="r">第 r 列</param>
    /// <returns></returns>
    public static List<int> PascalTraingleRow (int r)
    {
        List<int> result = [];

        for (int i = 0; i < r + 1; i++) 
        {
            if (i == 0)
            {
                result.Add(1);
            }
            else
            {
                result.Add(result[i - 1] * (r - i - 1) / i);
            }
        }

        return result;
    }
}
