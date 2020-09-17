using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.NewECS
{
    interface IHeater
    { 
        void TurnOn();

        void TurnOff();
    }

    interface ITempSensor
    {
        int GetTemp();
    }

    interface ITester
    {
        bool RunSelfTest();
    }

    interface IGui
    {
        void OpenWindow();

        void CloseWindow();

    }
}
