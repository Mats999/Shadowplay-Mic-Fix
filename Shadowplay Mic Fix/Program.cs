using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shadowplay_Mic_Fix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String micName = SaveFile.GetMicName();
            String micID = SaveFile.GetMicID();
            String micNameKey = "{FCDCC7A2-EF61-4782-AF8A-74FC89A6A11A}";
            String micIdKey = "{E8541E5B-8DA8-4BB1-82B5-F841FDA12F5B}";
            String registryPath = "SOFTWARE\\NVIDIA Corporation\\Global\\ShadowPlay\\NVSPCAPS";
            String serviceName = "NvContainerLocalSystem";

            while (true)
            {
                if (AudioDevices.DeviceExists(micName))
                {
                    break;
                }
                Thread.Sleep(1000);
            }

            RegistryKey shadowplayRegistry = Registry.CurrentUser.OpenSubKey(registryPath, true);
            byte[] micNameBytes = System.Text.Encoding.Unicode.GetBytes(micName);
            Array.Resize(ref micNameBytes, 512);
            byte[] micIdBytes = System.Text.Encoding.Unicode.GetBytes(micID);
            Array.Resize(ref micIdBytes, 512);

            ServiceController service = new ServiceController(serviceName);
            service.WaitForStatus(ServiceControllerStatus.Running);
            try
            {
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped);
                shadowplayRegistry.SetValue(micNameKey, micNameBytes);
                shadowplayRegistry.SetValue(micIdKey, micIdBytes);
                service.Start();
            }
            catch { }
        }
    }
}
