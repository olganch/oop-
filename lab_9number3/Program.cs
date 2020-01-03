using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

*/
namespace Lab_9_3_Event
{
    /*
    1.	Use event keyword with delegate type to declare an event. 
    ..a delegate becomes an event using the event keyword.
    2.	Check event is null or not before raising an event. 
    3.	Subscribe to events using "+=" operator. Unsubscribe it using "-=" operator. 
    4.	Function that handles the event is called event handler.Event handler must have same signature as declared by event delegate.
    5.	Events can have arguments which will be passed to handler function.
    6.	Events can also be declared static, virtual, sealed and abstract. 
    7.	An Interface can include event as a member. 
    8.	Events will not be raised if there is no subscriber 
    9.	Event handlers are invoked synchronously if there are multiple subscribers 
    10.	The .NET framework uses an EventHandler delegate and an EventArgs base class. 
    */

    /* Publisher is a publisher class that publishes the beforePrintEvent. 
     * if no class is subscribed to the event beforePrintEvent == null
     */

    // Event publisher
    public class Publisher
    {
        // declare delegate 
        public delegate void BeforePrint();

        //declare event of type delegate
        public event BeforePrint beforePrintEvent;

        public Publisher() { }

        public void PrintSubscriber(int num)
        {
            //call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    } // end class 

    // Event subscriber
    class Subscriber
    {
        public Subscriber(Publisher publisher, int val)
        {
            this.publisher = publisher;
            this.value = val;
            //subscribe to beforePrintEvent event
            publisher.beforePrintEvent += Handler_beforePrintEvent;
        }
        //beforePrintevent handler
        void Handler_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: Handler is going to print a value");
        }

        public void PrintMoney() { publisher.PrintMoney(value); }
        public void PrintSubscriber() { publisher.PrintSubscriber(value); }

        private Publisher publisher = null;
        private int value { set; get; }
    } // end class

    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber_1 = new Subscriber(publisher, 100000);
            Subscriber subscriber_2 = new Subscriber(publisher, 44);

            subscriber_1.PrintMoney();
            subscriber_1.PrintSubscriber();

            Console.ReadKey();
        }
    }

}