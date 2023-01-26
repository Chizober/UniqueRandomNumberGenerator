namespace RandNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Enumerable.Range(0, 27).ToArray();
            var randNum = new Random();

            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = randNum.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }

            for (int i = 0; i < nums.Length; ++i)
                Console.WriteLine(nums[i]);
        }
    }
}
