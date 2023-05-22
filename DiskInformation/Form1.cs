using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace DiskInformation
{


    public partial class Form1 : Form
    {
      


    public Form1()
        {
            InitializeComponent();

            
        }

        public static bool IsRunningAsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void RestartAsAdmin(string[] args)
        {
            var exeName = Process.GetCurrentProcess().MainModule.FileName;
            var startInfo = new ProcessStartInfo(exeName)
            {
                Verb = "runas",
                Arguments = string.Join(" ", args)
            };

            Process.Start(startInfo);

        }



        private void BtnGetHardDiskNumber_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher =
             new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            List<HardDrive> hdCollection = new List<HardDrive>();

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                hd.SerialNo = wmi_HD["SerialNumber"].ToString();
                

                hdCollection.Add(hd);
            }

            if (comboBox1.SelectedIndex >= 0)
            {
                HardDrive selectedHD = (HardDrive)comboBox1.SelectedItem;

                string serialNo = GetHardDiskDSerialNumber(selectedHD.Model);

                rtxtDiskInformation.Text = "Selected drive: " + selectedHD.Model + "\nSerial Number: " + serialNo;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            List<HardDrive> hdCollection = new List<HardDrive>();

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();

                hdCollection.Add(hd);
            }

            comboBox1.DataSource = hdCollection;
            comboBox1.DisplayMember = "Model";
        }





        //======================== Methods===================================


        public static string GetHardDiskDSerialNumber(string drive)
        {
            // Create a list to store hard drives
            ArrayList hdCollection = new ArrayList();

            // Query for hard drives
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            // Enumerate through hard drives
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                hd.SerialNo = wmi_HD["SerialNumber"].ToString();

                // Add hard drive to collection
                hdCollection.Add(hd);
            }

            // Query for physical media
            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            // Enumerate through physical media
            int i = 0;
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                // Get the hard drive from collection using index
                HardDrive hd = (HardDrive)hdCollection[i];

                // Set the hardware serial number
                if (wmi_HD["SerialNumber"] != null)
                {
                    hd.SerialNo = wmi_HD["SerialNumber"].ToString();
                }

                ++i;
            }

            // Find the hard drive with the matching drive letter and return its serial number
            foreach (HardDrive hd in hdCollection)
            {
                if (hd.Model.Contains(drive) || hd.SerialNo.Contains(drive))
                {
                    return hd.SerialNo;
                }
            }

            // Return a default value if the serial number is not found
            return "None";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Do something with the selected drive...
                string selectedDrive = comboBox1.SelectedItem.ToString();
                string serialNumber = GetHardDiskDSerialNumber(selectedDrive);
                rtxtDiskInformation.Text = "Selected Drive: " + selectedDrive;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void BtnChangeSerialNumber_Click(object sender, EventArgs e)
        {

            string selectedDrive = comboBox1.SelectedItem.ToString();
            string newSerialNumber = txtNewSerialNumber.Text;

            if (IsRunningAsAdmin())
            {
                if (ChangeSerialNumber(selectedDrive, newSerialNumber))
                {
                    MessageBox.Show("Serial number changed successfully.");
                }
                else
                {
                    MessageBox.Show("Not Implemended Yet.");
                }
            }
            else
            {
                RestartAsAdmin(new string[] { "change", selectedDrive, newSerialNumber });
            }
        }

        private bool ChangeSerialNumber(string selectedDrive, string newSerialNumber)
        {
            // Implement your logic to change the serial number of the selected drive
            MessageBox.Show("Not Implemented");
            return false;
        }
    }
}
