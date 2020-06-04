using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RoboApp.Services
{
    public interface IBlueToothM
    {
        Task OpenBluetooth();
        bool CheckLocationPermission();
        void CloseApp();
        Task AskLocationPermission();

        void MakeToastMessage(string Message);

    }
}
