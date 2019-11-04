﻿using DirectX.Capture;
using jini;
using MaterialSkin;
using RedRat.RedRat3;
using RedRat.RedRat3.USB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Woodpecker
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            setStyle();
        }

        string MainSettingPath = Application.StartupPath + "\\Config.ini";
        string MailPath = Application.StartupPath + "\\Mail.ini";

        private void loadxml()
        {
            // Redrat Database
            if (System.IO.File.Exists(textBox_RcDbPath.Text))
            {
                XDocument myDoc = XDocument.Load(textBox_RcDbPath.Text);
                var AVDevices = from pn in myDoc.Descendants("AVDevice")
                                where pn.Element("Name") != null
                                select pn.Element("Name").Value;

                foreach (var c in AVDevices)
                {
                    comboBox_TvBrands.Items.Add(c);
                    if (comboBox_TvBrands.Text == "")
                        comboBox_TvBrands.Text = c;
                }
            }
        }

        private void setStyle()
        {
            // Button design
            List<Button> buttonsList = new List<Button> { button_Save, button_ImagePath, button_LogPath, button_RcDbPath, button_GeneratorPath, button_DosPath };
            foreach (Button buttonsAll in buttonsList)
            {
                if (buttonsAll.Enabled == true)
                {
                    buttonsAll.FlatAppearance.BorderColor = Color.FromArgb(45, 103, 179);
                    buttonsAll.FlatAppearance.BorderSize = 1;
                    buttonsAll.BackColor = System.Drawing.Color.FromArgb(45, 103, 179);
                }
                else
                {
                    buttonsAll.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
                    buttonsAll.FlatAppearance.BorderSize = 1;
                    buttonsAll.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
                }
            }
        }

        private void button_ImagePath_Click(object sender, EventArgs e)
        {
            //Save Video Path
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath == "")
            {
                textBox_ImagePath.Text = textBox_ImagePath.Text;
            }
            else
            {
                textBox_ImagePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_LogPath_Click(object sender, EventArgs e)
        {
            //log file save path
            folderBrowserDialog2.ShowDialog();
            if (folderBrowserDialog2.SelectedPath == "")
            {
                textBox_LogPath.Text = textBox_LogPath.Text;
            }
            else
            {
                textBox_LogPath.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void button_RcDbPath_Click(object sender, EventArgs e)
        {
            // RedRat3 Command Path
            openFileDialog2.Filter = "XML files (*.xml)|*.xml";
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName == "")
            {
                textBox_RcDbPath.Text = textBox_RcDbPath.Text;
            }
            else
            {
                textBox_RcDbPath.Text = openFileDialog2.FileName;
                comboBox_TvBrands.Items.Clear();
                loadxml();
            }
        }

        private void button_GeneratorPath_Click(object sender, EventArgs e)
        {
            // Generator Command Path
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
            {
                textBox_GeneratorPath.Text = textBox_GeneratorPath.Text;
            }
            else
            {
                textBox_GeneratorPath.Text = openFileDialog1.FileName;
            }
        }

        private void button_DosPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog3.ShowDialog();
            if (folderBrowserDialog3.SelectedPath == "")
            {
                textBox_DosPath.Text = textBox_DosPath.Text;
            }
            else
            {
                textBox_DosPath.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        public void OkBtn_Click(object sender, EventArgs e)
        {
            //Image Path//
            ini12.INIWrite(MainSettingPath, "Record", "VideoPath", textBox_ImagePath.Text.Trim());

            //Log Path//
            ini12.INIWrite(MainSettingPath, "Record", "LogPath", textBox_LogPath.Text.Trim());

            //RedRat Path//
            ini12.INIWrite(MainSettingPath, "RedRat", "DBFile", textBox_RcDbPath.Text.Trim());

            //Generator Path//
            ini12.INIWrite(MainSettingPath, "Record", "Generator", textBox_GeneratorPath.Text.Trim());

            //DOS Path//
            ini12.INIWrite(MainSettingPath, "Device", "DOS", textBox_DosPath.Text.Trim());

            //Camera Device, Audio//
            ini12.INIWrite(MainSettingPath, "Camera", "VideoIndex", comboBox_CameraDevice.SelectedIndex.ToString());
            ini12.INIWrite(MainSettingPath, "Camera", "VideoName", comboBox_CameraDevice.Text);
            ini12.INIWrite(MainSettingPath, "Camera", "AudioIndex", comboBox_CameraAudio.SelectedIndex.ToString());
            ini12.INIWrite(MainSettingPath, "Camera", "AudioName", comboBox_CameraAudio.Text);

            //RedRat Brands, Select RC//
            ini12.INIWrite(MainSettingPath, "RedRat", "Brands", comboBox_TvBrands.Text.Trim());
            ini12.INIWrite(MainSettingPath, "RedRat", "RedRatIndex", (comboBox__SelectRedrat.SelectedIndex).ToString());
            ini12.INIWrite(MainSettingPath, "RedRat", "SerialNumber", comboBox__SelectRedrat.Text);

            //SerialPort1//
            if (checkBox_SerialPort1.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port A", "BaudRate", comboBox_SerialPort1_BaudRate_Value.Text.Trim());
                ini12.INIWrite(MainSettingPath, "Port A", "DataBit", "8");
                ini12.INIWrite(MainSettingPath, "Port A", "StopBits", "One");
                ini12.INIWrite(MainSettingPath, "Port A", "PortName", comboBox_SerialPort1_PortName_Value.Text);
            }

            //SerialPort2//
            if (checkBox_SerialPort2.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port B", "BaudRate", comboBox_SerialPort2_BaudRate_Value.Text.Trim());
                ini12.INIWrite(MainSettingPath, "Port B", "DataBit", "8");
                ini12.INIWrite(MainSettingPath, "Port B", "StopBits", "One");
                ini12.INIWrite(MainSettingPath, "Port B", "PortName", comboBox_SerialPort2_PortName_Value.Text);
            }

            //SerialPort3//
            if (checkBox_SerialPort3.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port C", "BaudRate", comboBox_SerialPort3_BaudRate_Value.Text.Trim());
                ini12.INIWrite(MainSettingPath, "Port C", "DataBit", "8");
                ini12.INIWrite(MainSettingPath, "Port C", "StopBits", "One");
                ini12.INIWrite(MainSettingPath, "Port C", "PortName", comboBox_SerialPort3_PortName_Value.Text);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            //Image欄位//
            if (Directory.Exists(ini12.INIRead(MainSettingPath, "Record", "VideoPath", "")))
            {
                textBox_ImagePath.Text = ini12.INIRead(MainSettingPath, "Record", "VideoPath", "");
            }
            else if (ini12.INIRead(MainSettingPath, "Record", "VideoPath", "") == "")
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\Image");
                textBox_ImagePath.Text = System.Windows.Forms.Application.StartupPath + "\\Image";
                ini12.INIWrite(MainSettingPath, "Record", "VideoPath", textBox_ImagePath.Text.Trim());
            }
            else
            {
                textBox_ImagePath.Text = "";
                ini12.INIWrite(MainSettingPath, "Record", "VideoPath", textBox_ImagePath.Text.Trim());
                pictureBox_ImagePath.Image = Properties.Resources.ERROR;
            }
            
            //Log欄位//
            if (Directory.Exists(ini12.INIRead(MainSettingPath, "Record", "LogPath", "")))
            {
                textBox_LogPath.Text = ini12.INIRead(MainSettingPath, "Record", "LogPath", "");
            }
            else if (ini12.INIRead(MainSettingPath, "Record", "LogPath", "") == "")
            {
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\Log");
                textBox_LogPath.Text = System.Windows.Forms.Application.StartupPath + "\\Log";
                ini12.INIWrite(MainSettingPath, "Record", "LogPath", textBox_LogPath.Text.Trim());
            }
            else
            {
                textBox_LogPath.Text = "";
                ini12.INIWrite(MainSettingPath, "Record", "LogPath", textBox_LogPath.Text.Trim());
                pictureBox_LogPath.Image = Properties.Resources.ERROR;
            }

            //RC DB欄位//
            if (File.Exists(ini12.INIRead(MainSettingPath, "RedRat", "DBFile", "")))
            {
                textBox_RcDbPath.Text = ini12.INIRead(MainSettingPath, "RedRat", "DBFile", "");
            }
            else
            {
                textBox_RcDbPath.Text = "";
                //pictureBox_RcDbPath.Image = Properties.Resources.ERROR;
            }

            //Generator欄位//
            if (File.Exists(ini12.INIRead(MainSettingPath, "Record", "Generator", "")))
            {
                textBox_GeneratorPath.Text = ini12.INIRead(MainSettingPath, "Record", "Generator", "");
            }
            else
            {
                textBox_GeneratorPath.Text = "";
                //pictureBox_GeneratorPath.Image = Properties.Resources.ERROR;
            }

            //DOS欄位//
            if (Directory.Exists(ini12.INIRead(MainSettingPath, "Device", "DOS", "")))
            {
                textBox_DosPath.Text = ini12.INIRead(MainSettingPath, "Device", "DOS", "");
            }
            else
            {
                textBox_DosPath.Text = "";
                //pictureBox_DosPath.Image = Properties.Resources.ERROR;
            }


            if (ini12.INIRead(MainSettingPath, "Record", "CANbusLog", "") == "1")
            {
                checkBox_canbus.Checked = true;
            }
            else
            {
                checkBox_canbus.Checked = false;
            }

            #region -- SerialPort --
            if (ini12.INIRead(MainSettingPath, "Device", "AutoboxExist", "") == "1")
            {
                GroupBox_Rs232.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " IS USING";

                comboBox_SerialPort1_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort2_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort3_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort4_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort5_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_KlinePort_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();

                if (ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "1")
                {
                    checkBox_SerialPort1.Checked = true;
                    comboBox_SerialPort1_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort1_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort1.Checked = false;
                    comboBox_SerialPort1_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort1_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port B", "Checked", "") == "1")
                {
                    checkBox_SerialPort2.Checked = true;
                    comboBox_SerialPort2_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort2_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port B", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort2.Checked = false;
                    comboBox_SerialPort2_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort2_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port C", "Checked", "") == "1")
                {
                    checkBox_SerialPort3.Checked = true;
                    comboBox_SerialPort3_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort3_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port C", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort3.Checked = false;
                    comboBox_SerialPort3_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort3_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port D", "Checked", "") == "1")
                {
                    checkBox_SerialPort4.Checked = true;
                    comboBox_SerialPort4_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort4_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port D", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort4.Checked = false;
                    comboBox_SerialPort4_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort4_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port E", "Checked", "") == "1")
                {
                    checkBox_SerialPort5.Checked = true;
                    comboBox_SerialPort5_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort5_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port E", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort5.Checked = false;
                    comboBox_SerialPort5_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort5_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Displayhex", "Checked", "") == "1")
                {
                    checkBox_Displayhex.Checked = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Displayhex", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_Displayhex.Checked = false;
                }

            }
            else if (ini12.INIRead(MainSettingPath, "Device", "AutoboxExist", "") == "0")
            {
                GroupBox_Rs232.Text = "AutoKit IS NOT CONNECTED";

                comboBox_SerialPort1_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort2_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort3_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort4_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_SerialPort5_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();
                comboBox_KlinePort_PortName_Value.DataSource = System.IO.Ports.SerialPort.GetPortNames();

                if (ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "1")
                {
                    checkBox_SerialPort1.Checked = true;
                    comboBox_SerialPort1_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort1_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort1.Checked = false;
                    comboBox_SerialPort1_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort1_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port B", "Checked", "") == "1")
                {
                    checkBox_SerialPort2.Checked = true;
                    comboBox_SerialPort2_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort2_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port B", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort2.Checked = false;
                    comboBox_SerialPort2_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort2_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port C", "Checked", "") == "1")
                {
                    checkBox_SerialPort3.Checked = true;
                    comboBox_SerialPort3_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort3_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port C", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort3.Checked = false;
                    comboBox_SerialPort3_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort3_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port D", "Checked", "") == "1")
                {
                    checkBox_SerialPort4.Checked = true;
                    comboBox_SerialPort4_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort4_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port D", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort4.Checked = false;
                    comboBox_SerialPort4_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort4_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Port E", "Checked", "") == "1")
                {
                    checkBox_SerialPort5.Checked = true;
                    comboBox_SerialPort5_BaudRate_Value.Enabled = true;
                    comboBox_SerialPort5_PortName_Value.Enabled = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Port E", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_SerialPort5.Checked = false;
                    comboBox_SerialPort5_BaudRate_Value.Enabled = false;
                    comboBox_SerialPort5_PortName_Value.Enabled = false;
                }

                if (ini12.INIRead(MainSettingPath, "Displayhex", "Checked", "") == "1")
                {
                    checkBox_Displayhex.Checked = true;
                }
                else if (ini12.INIRead(MainSettingPath, "Displayhex", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
                {
                    checkBox_Displayhex.Checked = false;
                }
            }

            if (ini12.INIRead(MainSettingPath, "Kline", "Checked", "") == "1")
            {
                checkBox_Kline.Checked = true;
                comboBox_KlinePort_PortName_Value.Enabled = true;
            }
            else if (ini12.INIRead(MainSettingPath, "Kline", "Checked", "") == "0" || ini12.INIRead(MainSettingPath, "Port A", "Checked", "") == "")
            {
                checkBox_Kline.Checked = false;
                comboBox_KlinePort_PortName_Value.Enabled = false;
            }

            comboBox_SerialPort1_BaudRate_Value.Text = ini12.INIRead(MainSettingPath, "Port A", "BaudRate", "");
            comboBox_SerialPort1_PortName_Value.Text = ini12.INIRead(MainSettingPath, "Port A", "PortName", "");
            comboBox_SerialPort2_BaudRate_Value.Text = ini12.INIRead(MainSettingPath, "Port B", "BaudRate", "");
            comboBox_SerialPort2_PortName_Value.Text = ini12.INIRead(MainSettingPath, "Port B", "PortName", "");
            comboBox_SerialPort3_BaudRate_Value.Text = ini12.INIRead(MainSettingPath, "Port C", "BaudRate", "");
            comboBox_SerialPort3_PortName_Value.Text = ini12.INIRead(MainSettingPath, "Port C", "PortName", "");
            comboBox_SerialPort4_BaudRate_Value.Text = ini12.INIRead(MainSettingPath, "Port D", "BaudRate", "");
            comboBox_SerialPort4_PortName_Value.Text = ini12.INIRead(MainSettingPath, "Port D", "PortName", "");
            comboBox_SerialPort5_BaudRate_Value.Text = ini12.INIRead(MainSettingPath, "Port E", "BaudRate", "");
            comboBox_SerialPort5_PortName_Value.Text = ini12.INIRead(MainSettingPath, "Port E", "PortName", "");
            comboBox_KlinePort_PortName_Value.Text = ini12.INIRead(MainSettingPath, "Kline", "PortName", "");
            #endregion

            #region -- Redrat --
            IRedRat3 redRat3;
            if (ini12.INIRead(MainSettingPath, "Device", "RedRatExist", "") == "1")//Redrat存在//
            {
                for (int i = 0; i < RedRat3USBImpl.FindDevices().Count; i++)
                {
                    redRat3 = (IRedRat3)RedRat3USBImpl.FindDevices()[i].GetRedRat();
                    comboBox__SelectRedrat.Items.Add(redRat3.DeviceInformation.ProductName + " - " + 
                                                     redRat3.DeviceInformation.SerialNumber.ToString());

                    if (ini12.INIRead(MainSettingPath, "RedRat", "SerialNumber", "") == "")
                    {
                        comboBox__SelectRedrat.Text = comboBox__SelectRedrat.Items[0].ToString();
                    }

                    if (redRat3.DeviceInformation.ProductName + " - " + 
                        redRat3.DeviceInformation.SerialNumber.ToString() ==
                        ini12.INIRead(MainSettingPath, "RedRat", "SerialNumber", ""))
                    {
                        comboBox__SelectRedrat.Text = redRat3.DeviceInformation.ProductName + " - " + 
                                                      redRat3.DeviceInformation.SerialNumber.ToString();
                    }
                }
                comboBox_TvBrands.Enabled = true;
                comboBox__SelectRedrat.Enabled = true;
            }
            else
            {
                comboBox_TvBrands.Enabled = false;
                comboBox__SelectRedrat.Enabled = false;
            }
            comboBox_TvBrands.Text = ini12.INIRead(MainSettingPath, "RedRat", "Brands", "");
            loadxml();
            #endregion
            
            #region -- Camera --
            if (ini12.INIRead(MainSettingPath, "Device", "CameraExist", "") == "1")//Camera存在//
            {
                comboBox_CameraDevice.Enabled = true;
                comboBox_CameraAudio.Enabled = true;
                
                Filters filters = new Filters();
                Filter f;

                ini12.INIWrite(MainSettingPath, "Camera", "VideoNumber", filters.VideoInputDevices.Count.ToString());
                ini12.INIWrite(MainSettingPath, "Camera", "AudioNumber", filters.AudioInputDevices.Count.ToString());
                
                for (int c = 0; c < filters.VideoInputDevices.Count; c++)
                {
                    f = filters.VideoInputDevices[c];
                    comboBox_CameraDevice.Items.Add(f.Name);
                    if (f.Name == ini12.INIRead(MainSettingPath, "Camera", "VideoName", ""))
                    {
                        comboBox_CameraDevice.Text = ini12.INIRead(MainSettingPath, "Camera", "VideoName", "");
                    }
                }

                if (comboBox_CameraDevice.Text == "" && filters.VideoInputDevices.Count > 0)
                {
                    comboBox_CameraDevice.SelectedIndex = filters.VideoInputDevices.Count - 1;
                    ini12.INIWrite(MainSettingPath, "Camera", "VideoIndex", comboBox_CameraDevice.SelectedIndex.ToString());
                    ini12.INIWrite(MainSettingPath, "Camera", "VideoName", comboBox_CameraDevice.Text);
                }

                for (int j = 0; j < filters.AudioInputDevices.Count; j++)
                {
                    f = filters.AudioInputDevices[j];
                    comboBox_CameraAudio.Items.Add(f.Name);
                    if (f.Name == ini12.INIRead(MainSettingPath, "Camera", "AudioName", ""))
                    {
                        comboBox_CameraAudio.Text = ini12.INIRead(MainSettingPath, "Camera", "AudioName", "");
                    }
                }

                if (comboBox_CameraAudio.Text == "" && filters.AudioInputDevices.Count > 0)
                {
                    comboBox_CameraAudio.SelectedIndex = filters.AudioInputDevices.Count - 1;
                    ini12.INIWrite(MainSettingPath, "Camera", "AudioIndex", comboBox_CameraAudio.SelectedIndex.ToString());
                    ini12.INIWrite(MainSettingPath, "Camera", "AudioName", comboBox_CameraAudio.Text);
                }
                label_resolution.Text = ini12.INIRead(MainSettingPath, "Camera", "Resolution", "");
            }
            else
            {
                comboBox_CameraDevice.Enabled = false;
                comboBox_CameraAudio.Enabled = false;
            }
            #endregion

            if (ini12.INIRead(MainSettingPath, "LogSearch", "TextNum", "") == "")
            {
                ini12.INIWrite(MainSettingPath, "LogSearch", "TextNum", "0");
            }
        }
        
        //自動調整ComboBox寬度
        private void AdjustWidthComboBox_DropDown(object sender, System.EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        private void checkBox_SerialPort1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SerialPort1.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port A", "Checked", "1");
                comboBox_SerialPort1_BaudRate_Value.Enabled = true;
                comboBox_SerialPort1_PortName_Value.Enabled = true;
                PortCheck();
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Port A", "Checked", "0");
                comboBox_SerialPort1_BaudRate_Value.Enabled = false;
                comboBox_SerialPort1_PortName_Value.Enabled = false;
                PortCheck();
            }
        }

        private void checkBox_SerialPort2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SerialPort2.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port B", "Checked", "1");
                comboBox_SerialPort2_BaudRate_Value.Enabled = true;
                comboBox_SerialPort2_PortName_Value.Enabled = true;
                PortCheck();
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Port B", "Checked", "0");
                comboBox_SerialPort2_BaudRate_Value.Enabled = false;
                comboBox_SerialPort2_PortName_Value.Enabled = false;
                PortCheck();
            }
        }

        private void checkBox_SerialPort3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SerialPort3.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port C", "Checked", "1");
                comboBox_SerialPort3_BaudRate_Value.Enabled = true;
                comboBox_SerialPort3_PortName_Value.Enabled = true;
                PortCheck();
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Port C", "Checked", "0");
                comboBox_SerialPort3_BaudRate_Value.Enabled = false;
                comboBox_SerialPort3_PortName_Value.Enabled = false;
                PortCheck();
            }
        }

        private void checkBox_SerialPort4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SerialPort4.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port D", "Checked", "1");
                comboBox_SerialPort4_BaudRate_Value.Enabled = true;
                comboBox_SerialPort4_PortName_Value.Enabled = true;
                PortCheck();
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Port D", "Checked", "0");
                comboBox_SerialPort4_BaudRate_Value.Enabled = false;
                comboBox_SerialPort4_PortName_Value.Enabled = false;
                PortCheck();
            }
        }

        private void checkBox_SerialPort5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SerialPort5.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Port E", "Checked", "1");
                comboBox_SerialPort5_BaudRate_Value.Enabled = true;
                comboBox_SerialPort5_PortName_Value.Enabled = true;
                PortCheck();
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Port E", "Checked", "0");
                comboBox_SerialPort5_BaudRate_Value.Enabled = false;
                comboBox_SerialPort5_PortName_Value.Enabled = false;
                PortCheck();
            }
        }

        private void checkBox_Displayhex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Displayhex.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Displayhex", "Checked", "1");
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Displayhex", "Checked", "0");
            }
        }

        private void PortCheck()
        {
            if (checkBox_SerialPort1.Checked == true)
            {
                if (comboBox_SerialPort1_PortName_Value.Text == ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", ""))
                {
                    label_ErrorMessage.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " is using!";
                    pictureBox_SerialPort1.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort2.Checked == true &&
                        (comboBox_SerialPort1_PortName_Value.Text == comboBox_SerialPort2_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort1.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort3.Checked == true &&
                        (comboBox_SerialPort1_PortName_Value.Text == comboBox_SerialPort3_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort1.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort4.Checked == true &&
                        (comboBox_SerialPort1_PortName_Value.Text == comboBox_SerialPort4_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort1.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort5.Checked == true &&
                        (comboBox_SerialPort1_PortName_Value.Text == comboBox_SerialPort5_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort1.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_Kline.Checked == true &&
                        (comboBox_SerialPort1_PortName_Value.Text == comboBox_KlinePort_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort1.Image = Properties.Resources.ERROR;
                }
                else
                {
                    pictureBox_SerialPort1.Image = null;
                }
            }
            else if (checkBox_SerialPort1.Checked == false)
            {
                pictureBox_SerialPort1.Image = null;
            }

            if (checkBox_SerialPort2.Checked == true)
            {
                if (comboBox_SerialPort2_PortName_Value.Text == ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", ""))
                {
                    label_ErrorMessage.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " is using!";
                    pictureBox_SerialPort2.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort1.Checked == true &&
                        (comboBox_SerialPort2_PortName_Value.Text == comboBox_SerialPort1_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort2.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort3.Checked == true &&
                        (comboBox_SerialPort2_PortName_Value.Text == comboBox_SerialPort3_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort2.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort4.Checked == true &&
                        (comboBox_SerialPort2_PortName_Value.Text == comboBox_SerialPort4_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort2.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort5.Checked == true &&
                        (comboBox_SerialPort2_PortName_Value.Text == comboBox_SerialPort5_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort2.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_Kline.Checked == true &&
                        (comboBox_SerialPort2_PortName_Value.Text == comboBox_KlinePort_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort2.Image = Properties.Resources.ERROR;
                }
                else
                {
                    pictureBox_SerialPort2.Image = null;
                }
            }
            else if (checkBox_SerialPort2.Checked == false)
            {
                pictureBox_SerialPort2.Image = null;
            }

            if (checkBox_SerialPort3.Checked == true)
            {
                if (comboBox_SerialPort3_PortName_Value.Text == ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", ""))
                {
                    label_ErrorMessage.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " is using!";
                    pictureBox_SerialPort3.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort1.Checked == true &&
                        (comboBox_SerialPort3_PortName_Value.Text == comboBox_SerialPort1_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort3.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort2.Checked == true &&
                        (comboBox_SerialPort3_PortName_Value.Text == comboBox_SerialPort2_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort3.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort4.Checked == true &&
                        (comboBox_SerialPort3_PortName_Value.Text == comboBox_SerialPort4_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort3.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort5.Checked == true &&
                        (comboBox_SerialPort3_PortName_Value.Text == comboBox_SerialPort5_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort3.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_Kline.Checked == true &&
                        (comboBox_SerialPort3_PortName_Value.Text == comboBox_KlinePort_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort3.Image = Properties.Resources.ERROR;
                }
                else
                {
                    pictureBox_SerialPort3.Image = null;
                }
            }
            else if (checkBox_SerialPort3.Checked == false)
            {
                pictureBox_SerialPort3.Image = null;
            }

            if (checkBox_SerialPort4.Checked == true)
            {
                if (comboBox_SerialPort4_PortName_Value.Text == ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", ""))
                {
                    label_ErrorMessage.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " is using!";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort1.Checked == true &&
                        (comboBox_SerialPort4_PortName_Value.Text == comboBox_SerialPort1_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort2.Checked == true &&
                        (comboBox_SerialPort4_PortName_Value.Text == comboBox_SerialPort2_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort3.Checked == true &&
                        (comboBox_SerialPort4_PortName_Value.Text == comboBox_SerialPort3_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort5.Checked == true &&
                        (comboBox_SerialPort4_PortName_Value.Text == comboBox_SerialPort5_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_Kline.Checked == true &&
                        (comboBox_SerialPort4_PortName_Value.Text == comboBox_KlinePort_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else
                {
                    pictureBox_SerialPort4.Image = null;
                }
            }
            else if (checkBox_SerialPort4.Checked == false)
            {
                pictureBox_SerialPort4.Image = null;
            }

            if (checkBox_SerialPort5.Checked == true)
            {
                if (comboBox_SerialPort5_PortName_Value.Text == ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", ""))
                {
                    label_ErrorMessage.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " is using!";
                    pictureBox_SerialPort5.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort1.Checked == true &&
                        (comboBox_SerialPort5_PortName_Value.Text == comboBox_SerialPort1_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort5.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort2.Checked == true &&
                        (comboBox_SerialPort5_PortName_Value.Text == comboBox_SerialPort2_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort3.Checked == true &&
                        (comboBox_SerialPort5_PortName_Value.Text == comboBox_SerialPort3_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort4.Checked == true &&
                        (comboBox_SerialPort5_PortName_Value.Text == comboBox_SerialPort4_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort4.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_Kline.Checked == true &&
                        (comboBox_SerialPort5_PortName_Value.Text == comboBox_KlinePort_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_SerialPort5.Image = Properties.Resources.ERROR;
                }
                else
                {
                    pictureBox_SerialPort5.Image = null;
                }
            }
            else if (checkBox_SerialPort5.Checked == false)
            {
                pictureBox_SerialPort5.Image = null;
            }

            if (checkBox_Kline.Checked == true)
            {
                if (comboBox_KlinePort_PortName_Value.Text == ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", ""))
                {
                    label_ErrorMessage.Text = ini12.INIRead(MainSettingPath, "Device", "AutoboxPort", "") + " is using!";
                    pictureBox_klinePort.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort1.Checked == true &&
                        (comboBox_KlinePort_PortName_Value.Text == comboBox_SerialPort1_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_klinePort.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort2.Checked == true &&
                        (comboBox_KlinePort_PortName_Value.Text == comboBox_SerialPort2_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_klinePort.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort3.Checked == true &&
                        (comboBox_KlinePort_PortName_Value.Text == comboBox_SerialPort3_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_klinePort.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort4.Checked == true &&
                        (comboBox_KlinePort_PortName_Value.Text == comboBox_SerialPort4_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_klinePort.Image = Properties.Resources.ERROR;
                }
                else if (checkBox_SerialPort5.Checked == true &&
                        (comboBox_KlinePort_PortName_Value.Text == comboBox_SerialPort5_PortName_Value.Text))
                {
                    label_ErrorMessage.Text = "SerialPort duplicate";
                    pictureBox_klinePort.Image = Properties.Resources.ERROR;
                }
                else
                {
                    pictureBox_klinePort.Image = null;
                }
            }
            else if (checkBox_Kline.Checked == false)
            {
                pictureBox_klinePort.Image = null;
            }

            if (pictureBox_SerialPort1.Image == null &&
                pictureBox_SerialPort2.Image == null &&
                pictureBox_SerialPort3.Image == null &&
                pictureBox_SerialPort4.Image == null &&
                pictureBox_SerialPort5.Image == null &&
                pictureBox_klinePort.Image == null)
            {
                label_ErrorMessage.Text = ""; // SerialPort save behavior on FormTabControl.cs file.
            }
        }

        private void textBox_ImagePath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_ImagePath.Text.Trim()) == true)
            {
                ini12.INIWrite(MainSettingPath, "Record", "VideoPath", textBox_ImagePath.Text.Trim());
                pictureBox_ImagePath.Image = null;
            }
            else
            {
                pictureBox_ImagePath.Image = Properties.Resources.ERROR;
            }
        }

        private void textBox_LogPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_LogPath.Text.Trim()) == true)
            {
                ini12.INIWrite(MainSettingPath, "Record", "LogPath", textBox_LogPath.Text.Trim());
                pictureBox_LogPath.Image = null;
            }
            else
            {
                pictureBox_LogPath.Image = Properties.Resources.ERROR;
            }
        }

        private void textBox_RcDbPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(textBox_RcDbPath.Text.Trim()) == true)
            {
                ini12.INIWrite(MainSettingPath, "RedRat", "DBFile", textBox_RcDbPath.Text.Trim());
                pictureBox_RcDbPath.Image = null;
            }
            else
            {
                pictureBox_RcDbPath.Image = Properties.Resources.ERROR;
            }
        }

        private void textBox_GeneratorPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(textBox_GeneratorPath.Text.Trim()) == true)
            {
                ini12.INIWrite(MainSettingPath, "Record", "Generator", textBox_GeneratorPath.Text.Trim());
                pictureBox_GeneratorPath.Image = null;
            }
            else
            {
                pictureBox_GeneratorPath.Image = Properties.Resources.ERROR;
            }
        }

        private void textBox_DosPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox_DosPath.Text.Trim()) == true)
            {
                ini12.INIWrite(MainSettingPath, "Device", "DOS", textBox_DosPath.Text.Trim());
                pictureBox_DosPath.Image = null;
            }
            else
            {
                pictureBox_DosPath.Image = Properties.Resources.ERROR;
            }
        }

        private void comboBox_CameraDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Camera", "VideoIndex", comboBox_CameraDevice.SelectedIndex.ToString());
            ini12.INIWrite(MainSettingPath, "Camera", "VideoName", comboBox_CameraDevice.Text);
        }

        private void comboBox_CameraAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Camera", "AudioIndex", comboBox_CameraAudio.SelectedIndex.ToString());
            ini12.INIWrite(MainSettingPath, "Camera", "AudioName", comboBox_CameraAudio.Text);
        }

        private void comboBox_TvBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "RedRat", "Brands", comboBox_TvBrands.Text.Trim());
            
        }

        private void comboBox__SelectRedrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "RedRat", "RedRatIndex", (comboBox__SelectRedrat.SelectedIndex).ToString());
            ini12.INIWrite(MainSettingPath, "RedRat", "SerialNumber", comboBox__SelectRedrat.Text);
        }

        private void comboBox_SerialPort1_PortName_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCheck();
        }

        private void comboBox_SerialPort1_BaudRate_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Port A", "BaudRate", comboBox_SerialPort1_BaudRate_Value.Text.Trim());
        }

        private void comboBox_SerialPort2_PortName_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCheck();
        }

        private void comboBox_SerialPort2_BaudRate_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Port B", "BaudRate", comboBox_SerialPort2_BaudRate_Value.Text.Trim());
        }

        private void comboBox_SerialPort3_PortName_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCheck();
        }

        private void comboBox_SerialPort3_BaudRate_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Port C", "BaudRate", comboBox_SerialPort3_BaudRate_Value.Text.Trim());
        }

        private void comboBox_SerialPort4_PortName_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCheck();
        }

        private void comboBox_SerialPort4_BaudRate_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Port D", "BaudRate", comboBox_SerialPort4_BaudRate_Value.Text.Trim());
        }

        private void comboBox_SerialPort5_PortName_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCheck();
        }

        private void comboBox_SerialPort5_BaudRate_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini12.INIWrite(MainSettingPath, "Port E", "BaudRate", comboBox_SerialPort5_BaudRate_Value.Text.Trim());
        }

        private void checkBox_Kline_CheckedChanged(object sender, EventArgs e)
        {
            //自動跑KlineLog//
            if (checkBox_Kline.Checked == true)
            {
                ini12.INIWrite(MainSettingPath, "Kline", "Checked", "1");
                comboBox_KlinePort_PortName_Value.Enabled = true;
                PortCheck();
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Kline", "Checked", "0");
                comboBox_KlinePort_PortName_Value.Enabled = false;
                PortCheck();
            }
        }

        private void comboBox_Kline_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCheck();
        }

        private void checkBox_canbus_CheckedChanged(object sender, EventArgs e)
        {
            //自動跑CANbusLog//
            if (checkBox_canbus.Checked == true)
            {

                ini12.INIWrite(MainSettingPath, "Record", "CANbusLog", "1");
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Record", "CANbusLog", "0");
            }
        }
    }
}
