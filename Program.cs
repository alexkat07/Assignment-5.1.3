using System.ComponentModel.Design;

namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsDuplicate([1, 2, 3, 1]));

            bool IsDuplicate(int[] input) 
            {
                Dictionary <int, int> duplicates = new Dictionary<int, int>();

                foreach (int i in input) 
                {
                    if (!duplicates.ContainsKey(i))
                    {
                        duplicates.Add(i, i);
                    }
                    else 
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
