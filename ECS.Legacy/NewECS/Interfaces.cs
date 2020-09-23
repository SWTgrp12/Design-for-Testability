using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.NewECS
{
    public interface IHeater
    { 
        void TurnOn();

        void TurnOff();

        bool State { get; }
    }

    public interface ITempSensor
    {
        int GetTemp();
    }

    interface ITester
    {
        bool RunSelfTest();
    }

    interface IVindue
    {
        void Open();

        void Close();

        bool State { get;}

    }
}
