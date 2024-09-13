



namespace EventDemoDay9Prog1
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            EventDemo1 e= new EventDemo1();
            e.CountValue += SecondMessage;
            e.Message();



        }

       public static void SecondMessage()
        {
            Console.WriteLine(" i am second message with Associated with calling method ");
        }

        //private static void E_CountValue(object? sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
