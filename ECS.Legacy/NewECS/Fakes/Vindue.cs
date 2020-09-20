using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows;

namespace ECS.NewECS
{   
    public class FakeVindue : IVindue
    {
        public bool State { get; private set; } = false;

        public void Open()
        {
            Console.WriteLine("Window is Open");
            State = true;
        }
        public void Close()
        {
            Console.WriteLine("Window is Closed");
            State = false;
        }

    }
}
