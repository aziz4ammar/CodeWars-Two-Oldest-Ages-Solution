public class LargestTwo
{
    public static int[] TwoOldestAges(int[] ages)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;

        foreach (int age in ages)
        {
            if (age > max1)
            {
                max2 = max1;
                max1 = age;
            }
            else if (age > max2)
            {
                max2 = age;
            }
        }

        return new int[] { max2, max1 };
    }
}
