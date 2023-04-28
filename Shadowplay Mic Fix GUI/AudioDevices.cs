using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.NAudio.CoreAudioApi;

namespace Shadowplay_Mic_Fix_GUI
{
    internal class AudioDevices
    {
        public static string GetIdByName(string deviceName)
        {
            var enumerator = new MMDeviceEnumerator();
            foreach (var endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                if (endpoint.FriendlyName == deviceName)
                {
                    return endpoint.ID;
                }
            }

            return null;
        }

        public static string GetNameById(string deviceId)
        {
            var enumerator = new MMDeviceEnumerator();
            foreach (var endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                if (endpoint.ID == deviceId)
                {
                    return endpoint.FriendlyName;
                }
            }

            return null;
        }

        public static List<string> GetAllNames()
        {
            List<string> names = new List<string>();
            var enumerator = new MMDeviceEnumerator();
            foreach (var endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                names.Add(endpoint.FriendlyName);
            }

            return names;
        }

        public static bool DeviceExists(string deviceName)
        {
            var enumerator = new MMDeviceEnumerator();
            foreach (var endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                if (endpoint.FriendlyName == deviceName)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
