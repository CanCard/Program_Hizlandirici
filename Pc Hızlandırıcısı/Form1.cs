using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Hızlandırıcısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("DTShellHlp"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("RadeonSoftware"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("amdow"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("AMDRSServ"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SettingSyncHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("DiscSoftBusServiceLite"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("ApplicationFrameHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("HPSupportSolutionsFrameworkService"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("WUDFHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("java"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("WmiPrvSE"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("wlanext"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("armsvc"))
            {
                process.Kill();
            }


            /*BURDAN SONRASI ALERTO FALERTO
             * KABATMA
             * YİGENİM
             * OKEE
             * AYUKÜN MÜ HA
             * AŞŞŞASI BUTON 2 BABBA
            */

            foreach (var process in Process.GetProcessesByName("OfficeClickToRun"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SecurityHealthService"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SystemSettingsBroker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("StartMenuExperienceHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("dasHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("AppVShNotify"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("MoUsoCoreWorker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SppExtComObj"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SearchIndexer"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("RuntimeBroker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("UserOOBEBroker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("ShellExperienceHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("notepad"))
            {
                process.Kill();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("notepad"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("DTShellHlp"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("RadeonSoftware"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("amdow"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("AMDRSServ"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SettingSyncHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("DiscSoftBusServiceLite"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("ApplicationFrameHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("HPSupportSolutionsFrameworkService"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("WUDFHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("java"))
            {
                process.Kill();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("OfficeClickToRun"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SecurityHealthService"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SystemSettingsBroker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("StartMenuExperienceHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("dasHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("AppVShNotify"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("MoUsoCoreWorker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SppExtComObj"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("SearchIndexer"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("RuntimeBroker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("UserOOBEBroker"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("ShellExperienceHost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("WmiPrvSE"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("wlanext"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("armsvc"))
            {
                process.Kill();
            }
        }
    }
}
