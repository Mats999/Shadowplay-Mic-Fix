using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowplay_Mic_Fix_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            micComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> names = AudioDevices.GetAllNames();
            foreach (string name in names)
            {
                micComboBox.Items.Add(name);
            }
            micComboBox.SelectedIndex = 0;
        }

        private void createTaskBtn_Click(object sender, EventArgs e)
        {
            Tasks.CreateTask();
        }

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            Tasks.DeleteTask();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = micComboBox.SelectedItem.ToString();
            string id = AudioDevices.GetIdByName(name);
            SaveFile.SetMicID(id);
            SaveFile.SetMicName(name);
            SaveFile.WriteSaveFile();
        }
    }
}
