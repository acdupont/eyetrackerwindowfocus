using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5641
{
    [RunInstaller(true)]
    public class EyeTrackerServiceInstaller : Installer
    {
        private ServiceProcessInstaller processInstaller;
        private ServiceInstaller serviceInstaller;

        public EyeTrackerServiceInstaller()
        {
            processInstaller = new ServiceProcessInstaller();
            serviceInstaller = new ServiceInstaller();

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Automatic;
            serviceInstaller.ServiceName = "EyeTrackerService";
            serviceInstaller.Description = "Handles starting/stopping eyetracking service that integrates with window focusing";
            Installers.Add(serviceInstaller);
            Installers.Add(processInstaller);
        }
    }
}
