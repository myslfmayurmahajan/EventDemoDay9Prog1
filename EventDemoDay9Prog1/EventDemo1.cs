using System;


namespace EventDemoDay9Prog1
{
    public class EventDemo1
    {
        public event EventHandler CountValue;
        

        public void Message()
        {
            Console.WriteLine(" i am first line ");
            CountValue?.Invoke();
        }


    }
}
