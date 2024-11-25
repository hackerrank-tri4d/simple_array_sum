namespace simple_array_sum;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() {1, 2, 3, 4, 10, 11}
        ;
        Console.WriteLine(simpleArraySum);
    }
    
    public static int simpleArraySum(List<int> ar)
    {   
        return ar.Sum();
    }
}