using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    class Voter
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepared by: Lokesh Nath Yogi\n");
            List<Voter> voters = new List<Voter>()
            {
                new Voter {Id = 1, Name = "Apple", Age = 20, City = "Patan"},
                new Voter {Id = 2, Name = "Banana", Age = 17, City = "Kathmandu"},
                new Voter {Id = 3, Name = "Cherry", Age = 25, City = "Patan"},
                new Voter {Id = 4, Name = "Mango", Age = 19, City = "Pokhara"},
                new Voter {Id = 5, Name = "Berry", Age = 16, City = "Patan"}
            };
            var eligibleVoters = from v in voters
                                 where v.Age > 18 && v.City == "Patan"
                                 select v;
            Console.WriteLine("Voters from Patan whose age is greater than 18:");
            foreach (var voter in eligibleVoters)
            {
                Console.WriteLine($"Name: {voter.Name}, Age: {voter.Age}, City: {voter.City}");
            }
        }
    }
}
