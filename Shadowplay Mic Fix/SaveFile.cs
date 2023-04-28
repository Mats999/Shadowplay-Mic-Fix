using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shadowplay_Mic_Fix
{
    public class MicInfo
    {
        public MicInfo(string micName, string micID)
        {
            this.MicName = micName;
            this.MicID = micID;
        }
        public string MicName { get; set; }
        public string MicID { get; set; }
    }

    static class SaveFile
    {
        private static string saveFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Shadowplay Mic Fix");
        private static string saveFileName = "savefile.json";
        private static MicInfo micInfo;

        static SaveFile()
        {
            ReadSaveFile();
        }

        public static void ReadSaveFile()
        {
            if (File.Exists(Path.Combine(saveFilePath, saveFileName)))
            {
                string jsonData = File.ReadAllText(Path.Combine(saveFilePath, saveFileName));
                MicInfo ob = JsonSerializer.Deserialize<MicInfo>(jsonData);
                micInfo = ob;
            }
            else { micInfo = new MicInfo("", ""); }
        }

        public static void WriteSaveFile()
        {
            string jsonData = JsonSerializer.Serialize(micInfo);
            File.WriteAllText(Path.Combine(saveFilePath, saveFileName), jsonData);
        }

        public static void SetMicName(string micName) { micInfo.MicName = micName; }
        public static string GetMicName() { return micInfo.MicName; }
        public static void SetMicID(string micID) { micInfo.MicID = micID; }
        public static string GetMicID() { return micInfo.MicID; }
    }
}
