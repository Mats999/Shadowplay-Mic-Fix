using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowplay_Mic_Fix_GUI
{
    public static class Tasks
    {
        private static TaskService ts;
        private static string taskName = "Shadowplay Mic Fix";
        private static string executablePath = $"{Directory.GetCurrentDirectory()}\\Shadowplay Mic Fix.exe";

        static Tasks()
        {
            ts = new TaskService();
        }
        public static void CreateTask()
        {
            if (TaskExists(taskName))
            {
                DeleteTask();
            }
            TaskDefinition td = ts.NewTask();
            td.RegistrationInfo.Description = taskName;
            td.Triggers.Add(new LogonTrigger());
            td.Actions.Add(new ExecAction(executablePath));
            td.Principal.RunLevel = TaskRunLevel.Highest;

            ts.RootFolder.RegisterTaskDefinition(taskName, td);
        }

        public static void DeleteTask()
        {
            if (TaskExists(taskName))
            {
                ts.RootFolder.DeleteTask(taskName);
            }
        }

        private static bool TaskExists(string taskName)
        {
            var task = ts.GetTask(taskName);

            if (task != null)
            {
                return true;
            }

            return false;
        }
    }
}
