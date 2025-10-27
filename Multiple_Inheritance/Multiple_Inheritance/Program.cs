namespace Multiple_Inheritance
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Prepared by: Lokesh Nath Yogi\n");
            SmartPhone obj = new SmartPhone(); 
            obj.GetPhoneModel();
            obj.GetCameraDetails();
            obj.GetDetails();
        }
    }
    class Phone
    {
        public void GetPhoneModel()
        {
            Console.WriteLine("IPhone 17 Pro Max");
        }
    }
    interface ICamera
    {
        void GetCameraDetails();
    }
    class SmartPhone : Phone, ICamera
    {
        public void GetCameraDetails()
        {
            Console.WriteLine("48 Mega Pixel Camera");
        }
        public void GetDetails()
        {
            Console.WriteLine("It's a Iphone Smart Phone");
        }
    }
}
