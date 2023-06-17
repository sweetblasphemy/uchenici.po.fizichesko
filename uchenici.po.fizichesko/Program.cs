namespace uchenici.po.fizichesko
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int[] heights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int[] positions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                
                int height1 = heights[positions[0] - 1];
                int height2 = heights[positions[1] - 1];

              
                Console.WriteLine($"{height1} {height2}");

        }
    }
}