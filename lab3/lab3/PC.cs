using System;


namespace lab3
{
    internal class PC
    {
        public Skreen skreen;
        public Keyboard keyboard;
        public Mouse mouse;
        public System_unit system_unit;
        public PC(Skreen s, Keyboard k, Mouse m, System_unit su)
        {
            skreen = s;
            keyboard = k;
            mouse = m;
            system_unit = su;
        }

        public void Turn_on()
        {
            Console.WriteLine("PC is turned on");
            Console.ForegroundColor = ConsoleColor.Red;
            if (!keyboard.is_connected)
                Console.WriteLine("Keybord is not connected");
            else if (!system_unit.is_connected)
                Console.WriteLine("System unit is not connected");
            else if (!skreen.is_connected)
                Console.WriteLine("Skreen is not connected(how can you see this!?)");
            else if (!mouse.is_connected)
                Console.WriteLine("Mouse is not connected");
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Every thing is connected");
            }
        }
        public void Turn_off()
        {
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("Turning off:");
            keyboard.is_connected = false;
            Console.WriteLine("Keybord is disconnected");
            mouse.is_connected = false;
            Console.WriteLine("Mouse is disconnected");
            skreen.is_connected = false;
            Console.WriteLine("Skreen is disconnected");
            system_unit.is_connected = false;
            Console.WriteLine("System unit is disconnected");
        }
    }
}
