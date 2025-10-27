namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepared by: Lokesh Nath Yogi\n");
            try
            {
                Console.Write("Enter price of product:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Price you entered: {price}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid numeric price value.");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("An unexpected error occurred: " + Ex.Message);
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
            }
        }
    }
}
