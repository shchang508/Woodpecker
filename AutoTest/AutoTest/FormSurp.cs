﻿using jini;
using System;
using System.Windows.Forms;

namespace Woodpecker
{
    public partial class FormSurp : Form
    {
        public FormSurp()
        {
            InitializeComponent();

        }

        private void FormSurp_MouseEnter(object sender, EventArgs e)
        {
            Close();
        }

        string MainSettingPath = Application.StartupPath + "\\Config.ini";

        private void Setting_Load(object sender, EventArgs e)
        {
            if (ini12.INIRead(MainSettingPath, "Record", "ImportDB", "") != "")
            {
                if (int.Parse(ini12.INIRead(MainSettingPath, "Record", "ImportDB", "")) == 1)
                {
                    ImportDB.Checked = true;
                }
                else
                {
                    ImportDB.Checked = false;
                }
            }
            else
            {
                ini12.INIWrite(MainSettingPath, "Record", "ImportDB", "0");
                ImportDB.Checked = false;
            }
        }

        private void ImportDB_CheckedChanged(object sender, EventArgs e)
        {
            if (ImportDB.Checked == true)
            {
                // 寫入Import DadaBase啟動
                ini12.INIWrite(MainSettingPath, "Record", "ImportDB", "1");
            }
            else
            {
                // 寫入Import DadaBase關閉
                ini12.INIWrite(MainSettingPath, "Record", "ImportDB", "0");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (IPtextBox.Text != "")
            {
                ini12.INIWrite(MainSettingPath, "Network", "IP", IPtextBox.Text);
            }

            if (PorttextBox.Text != "")
            {
                ini12.INIWrite(MainSettingPath, "Network", "Port", PorttextBox.Text);
            }
            Close();
        }
    }
}
