using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using esea_control.Properties;

namespace esea_control
{
    public partial class MainForm : Form
    {
        private List<ServiceController> suspiciousServices = new List<ServiceController>();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var services = ServiceController.GetDevices();

            foreach (var service in services)
            {
                if (service.ServiceName.ToLower().Contains("esea"))
                {
                    suspiciousServices.Add(service);
                }
            }

            if (suspiciousServices.Count == 0)
            {
                pictureBox.Image = Resources.icons8_checkmark_96;
                infoTitle.Text = "ESEA anticheat is not running.";
                infoText.Text = "No running services that could be associated with ESEA were found. You can reinstall the anticheat by opening ESEA client.";
                mainButton.Enabled = false;
            }
        }

        private void moreButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (suspiciousServices.Count == 0)
            {
                MessageBox.Show("No suspicious services found!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var text = "Following services were found running:\n\n";

            foreach (var service in suspiciousServices)
            {
                text += service.ServiceName + "\n";
            }

            MessageBox.Show(text, "Hmm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            var text = "Disabled successfully following services:\n\n";
            
            foreach (var service in suspiciousServices)
            {
                try
                {
                    ServiceHelper.Uninstall(service.ServiceName);

                    //var path = ServiceHelper.GetServiceBinPath(service.ServiceName);
                    //File.Delete(path);

                    text += service.ServiceName + "\n";
                }
                catch (Exception error)
                {
                    MessageBox.Show("Failed to disable service: " + service.ServiceName + "\n\n" + error.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            text += "\nIn order for changes to take effect, you might want to reboot. Select YES to reboot.";

            var dialogResult = MessageBox.Show(text, "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("shutdown.exe", "-r -t 0");
            }
        }
    }
}
