using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows;

namespace ECS.NewECS
{   
    public class Vindue : IVindue
    {
        public bool State { get; private set; } = false;

        public void Open()
        {
            Console.WriteLine("Opening Window");
            State = true;
        }
        public void Close()
        {
            Console.WriteLine("Closing Window");
            State = false;
        }

    }
}
