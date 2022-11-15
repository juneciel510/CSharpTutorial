using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class TestingEvents
    {
        // https://www.youtube.com/watch?v=gYC-9PUGwDI
        public void Test()
        {
            Console.WriteLine("Press A/B to simulate a button click");
            var key = Console.ReadLine();
            if (key == "a")
            {
                KeyPressed();
            }
            if (key == "b")
            {
                KeyPressed2();
            }
        }

        static void KeyPressed()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
            {
                Console.WriteLine($"You clicked a button");
            };
            button.OnClick();
        }

        static void KeyPressed2()
        {
            Button2 button2 = new Button2();
            //the function subscribe to event will be invoke when the event is fired
            button2.ClickEvent += (s, args) =>
            {
                Console.WriteLine($"You clicked a button {args.Name}");
            };
            button2.OnClick();
        }

    }

    public class Button
    {
        public EventHandler ClickEvent;
        public void OnClick()
        {
            ClickEvent.Invoke(this, EventArgs.Empty);
        }
    }

    public class Button2
    {
        public EventHandler<MyCustomArguments> ClickEvent;
        public void OnClick()
        {
            MyCustomArguments myArgs = new MyCustomArguments();
            myArgs.Name = "Ian";
            //if ClickEvent is not Null, then invoke
            ClickEvent?.Invoke(this, myArgs);
        }
    }

    public class MyCustomArguments:EventArgs
    {
        public string Name { get; set; }
    }
}
