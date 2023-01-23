namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("dd/MM/yyyy"));

            var date = today.Date;
            Console.WriteLine(date);

            DateTime tomorrow = today.AddDays(1); Console.WriteLine(tomorrow);
        }
       
    }
}