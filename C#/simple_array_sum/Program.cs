namespace simple_array_sum;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() {1, 2, 3, 4, 10, 11}
        ;
        Console.WriteLine(SimpleArraySum(nums));
    }
    
    public static int SimpleArraySum(List<int> arr)
    {   
        return arr.Sum();
    }
}