namespace Run_time_Polymorphism
{
    class Class1
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepared by: Lokesh Nath Yogi\n");
            Class1 obj = new Class2();
            obj.Show();
            
        }
    }
}
