using System;
using System.ServiceProcess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5421
{
    class EyeTrackerService : ServiceBase
    {
        public EyeTrackerService()
        {
            ServiceName = "EyeTrackerService";
            CanStop = true;
            CanPauseAndContinue = false;
            AutoLog = true;
        }


        protected override void OnStart(string[] args)
        {
            //base.OnStart(args);
            Console.WriteLine("EyeTrackerService.OnStart");
        }



        protected override void OnStop()
        {
            //base.OnStop();
            Console.WriteLine("EyeTrackerService.OnStop");
        }


        static void Main(string[] args)
        {
            System.ServiceProcess.ServiceBase.Run(new EyeTrackerService());
        }

        private void InitializeComponent()
        {
            // 
            // EyeTrackerService
            // 
            this.ServiceName = "EyeTrackerService";

        }
    }
}
