using System;


namespace lab3
{
    internal class PC
    {
        public bool is_connected_skreen;
        public bool is_connected_keyboard;
        public bool is_connected_mouse;
        public bool is_connected_system_unit;
        public PC(Skreen s, Keyboard k, Mouse m, System_unit su)
        {
            is_connected_keyboard = k.is_connected;
            is_connected_mouse = m.is_connected;
            is_connected_skreen = s.is_connected;
            is_connected_system_unit = su.is_connected;
        }

        public void Turn_on()
        {
            Console.WriteLine("PC is turned on");
            Console.ForegroundColor = ConsoleColor.Red;
            if (!is_connected_keyboard)
                Console.WriteLine("Keybord is not connected");
            else if (!is_connected_system_unit)
                Console.WriteLine("System unit is not connected");
            else if (!is_connected_skreen)
                Console.WriteLine("Skreen is not connected(how can you see this!?)");
            else if (!is_connected_mouse)
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
            is_connected_keyboard = false;
            Console.WriteLine("Keybord is disconnected");
            is_connected_mouse = false;
            Console.WriteLine("Mouse is disconnected");
            is_connected_skreen = false;
            Console.WriteLine("Skreen is disconnected");
            is_connected_system_unit = false;
            Console.WriteLine("System unit is disconnected");
        }
    }
}
