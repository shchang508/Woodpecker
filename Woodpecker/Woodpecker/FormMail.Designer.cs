﻿namespace Woodpecker
{
    partial class FormMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendMailBtn = new System.Windows.Forms.Button();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TotalTestTime = new System.Windows.Forms.TextBox();
            this.textBox_Tester = new System.Windows.Forms.TextBox();
            this.textBox_Version = new System.Windows.Forms.TextBox();
            this.SaveMailBtn = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.textBox_ModelName = new System.Windows.Forms.TextBox();
            this.textBox_TestCase1 = new System.Windows.Forms.TextBox();
            this.label_MailSchedule1 = new System.Windows.Forms.Label();
            this.textBox_TestCase2 = new System.Windows.Forms.TextBox();
            this.textBox_TestCase3 = new System.Windows.Forms.TextBox();
            this.textBox_TestCase4 = new System.Windows.Forms.TextBox();
            this.textBox_TestCase5 = new System.Windows.Forms.TextBox();
            this.SendMailcheckBox = new System.Windows.Forms.CheckBox();
            this.textBox_ProjectNumber = new System.Windows.Forms.TextBox();
            this.ProjectNumberLabel = new System.Windows.Forms.Label();
            this.textBox_TeamViewerID = new System.Windows.Forms.TextBox();
            this.labelTeamViewerID = new System.Windows.Forms.Label();
            this.textBox_TeamViewerPassWord = new System.Windows.Forms.TextBox();
            this.labelTeamViewerPassWord = new System.Windows.Forms.Label();
            this.GmailcheckBox = new System.Windows.Forms.CheckBox();
            this.label_ErrorMessage = new System.Windows.Forms.Label();
            this.pictureBox_To = new System.Windows.Forms.PictureBox();
            this.pictureBox_From = new System.Windows.Forms.PictureBox();
            this.label_MailSchedule2 = new System.Windows.Forms.Label();
            this.label_MailSchedule3 = new System.Windows.Forms.Label();
            this.label_MailSchedule4 = new System.Windows.Forms.Label();
            this.label_MailSchedule5 = new System.Windows.Forms.Label();
            this.lebalNetworkPrompt = new System.Windows.Forms.Label();
            this.GroupBox_maileSubject = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_From)).BeginInit();
            this.GroupBox_maileSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendMailBtn
            // 
            this.SendMailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SendMailBtn.Location = new System.Drawing.Point(38, 407);
            this.SendMailBtn.Name = "SendMailBtn";
            this.SendMailBtn.Size = new System.Drawing.Size(71, 26);
            this.SendMailBtn.TabIndex = 0;
            this.SendMailBtn.Text = "Send";
            this.SendMailBtn.UseVisualStyleBackColor = true;
            this.SendMailBtn.Visible = false;
            this.SendMailBtn.Click += new System.EventHandler(this.SendMailBtn_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.White;
            this.ToLabel.Location = new System.Drawing.Point(35, 146);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(31, 16);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To :";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FromLabel.ForeColor = System.Drawing.Color.White;
            this.FromLabel.Location = new System.Drawing.Point(312, 387);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(36, 15);
            this.FromLabel.TabIndex = 2;
            this.FromLabel.Text = "From";
            this.FromLabel.Visible = false;
            // 
            // textBox_To
            // 
            this.textBox_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_To.Location = new System.Drawing.Point(84, 144);
            this.textBox_To.Name = "textBox_To";
            this.textBox_To.Size = new System.Drawing.Size(240, 21);
            this.textBox_To.TabIndex = 3;
            this.textBox_To.TextChanged += new System.EventHandler(this.textBox_To_TextChanged);
            // 
            // textBox_From
            // 
            this.textBox_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_From.Location = new System.Drawing.Point(361, 384);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(240, 21);
            this.textBox_From.TabIndex = 4;
            this.textBox_From.Text = "tpdqatest@gmail.com";
            this.textBox_From.Visible = false;
            this.textBox_From.TextChanged += new System.EventHandler(this.textBox_From_TextChanged);
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ProjectName.Location = new System.Drawing.Point(405, 31);
            this.textBox_ProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.Size = new System.Drawing.Size(169, 21);
            this.textBox_ProjectName.TabIndex = 5;
            this.textBox_ProjectName.TextChanged += new System.EventHandler(this.textBox_ProjectName_TextChanged);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel.Location = new System.Drawing.Point(315, 33);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(90, 16);
            this.ProjectLabel.TabIndex = 6;
            this.ProjectLabel.Text = "Project name ";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(315, 94);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(82, 16);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "SW Version ";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartLabel.ForeColor = System.Drawing.Color.White;
            this.StartLabel.Location = new System.Drawing.Point(309, 412);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(86, 15);
            this.StartLabel.TabIndex = 8;
            this.StartLabel.Text = "Total test time ";
            this.StartLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tester ";
            // 
            // textBox_TotalTestTime
            // 
            this.textBox_TotalTestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TotalTestTime.Location = new System.Drawing.Point(398, 410);
            this.textBox_TotalTestTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TotalTestTime.Name = "textBox_TotalTestTime";
            this.textBox_TotalTestTime.Size = new System.Drawing.Size(169, 21);
            this.textBox_TotalTestTime.TabIndex = 10;
            this.textBox_TotalTestTime.Visible = false;
            this.textBox_TotalTestTime.TextChanged += new System.EventHandler(this.textBox_TotalTestTime_TextChanged);
            // 
            // textBox_Tester
            // 
            this.textBox_Tester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Tester.Location = new System.Drawing.Point(405, 124);
            this.textBox_Tester.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Tester.Name = "textBox_Tester";
            this.textBox_Tester.Size = new System.Drawing.Size(169, 21);
            this.textBox_Tester.TabIndex = 11;
            this.textBox_Tester.TextChanged += new System.EventHandler(this.textBox_Tester_TextChanged);
            // 
            // textBox_Version
            // 
            this.textBox_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Version.Location = new System.Drawing.Point(405, 93);
            this.textBox_Version.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Version.Name = "textBox_Version";
            this.textBox_Version.Size = new System.Drawing.Size(169, 21);
            this.textBox_Version.TabIndex = 12;
            this.textBox_Version.TextChanged += new System.EventHandler(this.textBox_Version_TextChanged);
            // 
            // SaveMailBtn
            // 
            this.SaveMailBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveMailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SaveMailBtn.Location = new System.Drawing.Point(574, 447);
            this.SaveMailBtn.Margin = new System.Windows.Forms.Padding(2, 2, 24, 2);
            this.SaveMailBtn.Name = "SaveMailBtn";
            this.SaveMailBtn.Size = new System.Drawing.Size(78, 36);
            this.SaveMailBtn.TabIndex = 65;
            this.SaveMailBtn.Text = "SAVE";
            this.SaveMailBtn.UseVisualStyleBackColor = true;
            this.SaveMailBtn.Visible = false;
            this.SaveMailBtn.Click += new System.EventHandler(this.SaveSchBtn_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.Color.White;
            this.ModelLabel.Location = new System.Drawing.Point(315, 64);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(86, 16);
            this.ModelLabel.TabIndex = 67;
            this.ModelLabel.Text = "Model name ";
            // 
            // textBox_ModelName
            // 
            this.textBox_ModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ModelName.Location = new System.Drawing.Point(405, 62);
            this.textBox_ModelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ModelName.Name = "textBox_ModelName";
            this.textBox_ModelName.Size = new System.Drawing.Size(169, 21);
            this.textBox_ModelName.TabIndex = 66;
            this.textBox_ModelName.TextChanged += new System.EventHandler(this.textBox_ModelName_TextChanged);
            // 
            // textBox_TestCase1
            // 
            this.textBox_TestCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TestCase1.Location = new System.Drawing.Point(88, 31);
            this.textBox_TestCase1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCase1.Name = "textBox_TestCase1";
            this.textBox_TestCase1.Size = new System.Drawing.Size(169, 21);
            this.textBox_TestCase1.TabIndex = 69;
            this.textBox_TestCase1.TextChanged += new System.EventHandler(this.textBox_TestCase1_TextChanged);
            // 
            // label_MailSchedule1
            // 
            this.label_MailSchedule1.AutoSize = true;
            this.label_MailSchedule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MailSchedule1.ForeColor = System.Drawing.Color.White;
            this.label_MailSchedule1.Location = new System.Drawing.Point(14, 35);
            this.label_MailSchedule1.Name = "label_MailSchedule1";
            this.label_MailSchedule1.Size = new System.Drawing.Size(72, 16);
            this.label_MailSchedule1.TabIndex = 68;
            this.label_MailSchedule1.Text = "Schedule1";
            // 
            // textBox_TestCase2
            // 
            this.textBox_TestCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TestCase2.Location = new System.Drawing.Point(88, 62);
            this.textBox_TestCase2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCase2.Name = "textBox_TestCase2";
            this.textBox_TestCase2.Size = new System.Drawing.Size(169, 21);
            this.textBox_TestCase2.TabIndex = 70;
            this.textBox_TestCase2.TextChanged += new System.EventHandler(this.textBox_TestCase2_TextChanged);
            // 
            // textBox_TestCase3
            // 
            this.textBox_TestCase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TestCase3.Location = new System.Drawing.Point(88, 93);
            this.textBox_TestCase3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCase3.Name = "textBox_TestCase3";
            this.textBox_TestCase3.Size = new System.Drawing.Size(169, 21);
            this.textBox_TestCase3.TabIndex = 71;
            this.textBox_TestCase3.TextChanged += new System.EventHandler(this.textBox_TestCase3_TextChanged);
            // 
            // textBox_TestCase4
            // 
            this.textBox_TestCase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TestCase4.Location = new System.Drawing.Point(88, 124);
            this.textBox_TestCase4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCase4.Name = "textBox_TestCase4";
            this.textBox_TestCase4.Size = new System.Drawing.Size(169, 21);
            this.textBox_TestCase4.TabIndex = 72;
            this.textBox_TestCase4.TextChanged += new System.EventHandler(this.textBox_TestCase4_TextChanged);
            // 
            // textBox_TestCase5
            // 
            this.textBox_TestCase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TestCase5.Location = new System.Drawing.Point(88, 155);
            this.textBox_TestCase5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TestCase5.Name = "textBox_TestCase5";
            this.textBox_TestCase5.Size = new System.Drawing.Size(169, 21);
            this.textBox_TestCase5.TabIndex = 73;
            this.textBox_TestCase5.TextChanged += new System.EventHandler(this.textBox_TestCase5_TextChanged);
            // 
            // SendMailcheckBox
            // 
            this.SendMailcheckBox.AutoSize = true;
            this.SendMailcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SendMailcheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.SendMailcheckBox.Location = new System.Drawing.Point(38, 26);
            this.SendMailcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SendMailcheckBox.Name = "SendMailcheckBox";
            this.SendMailcheckBox.Size = new System.Drawing.Size(135, 24);
            this.SendMailcheckBox.TabIndex = 74;
            this.SendMailcheckBox.Text = "Mail Function";
            this.SendMailcheckBox.UseVisualStyleBackColor = true;
            this.SendMailcheckBox.CheckedChanged += new System.EventHandler(this.SendMailcheckBox_CheckedChanged);
            // 
            // textBox_ProjectNumber
            // 
            this.textBox_ProjectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_ProjectNumber.Location = new System.Drawing.Point(460, 11);
            this.textBox_ProjectNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ProjectNumber.Name = "textBox_ProjectNumber";
            this.textBox_ProjectNumber.Size = new System.Drawing.Size(169, 21);
            this.textBox_ProjectNumber.TabIndex = 77;
            this.textBox_ProjectNumber.Visible = false;
            this.textBox_ProjectNumber.TextChanged += new System.EventHandler(this.textBox_ProjectNumber_TextChanged);
            // 
            // ProjectNumberLabel
            // 
            this.ProjectNumberLabel.AutoSize = true;
            this.ProjectNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ProjectNumberLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectNumberLabel.Location = new System.Drawing.Point(315, 14);
            this.ProjectNumberLabel.Name = "ProjectNumberLabel";
            this.ProjectNumberLabel.Size = new System.Drawing.Size(94, 15);
            this.ProjectNumberLabel.TabIndex = 76;
            this.ProjectNumberLabel.Text = "Project number ";
            this.ProjectNumberLabel.Visible = false;
            // 
            // textBox_TeamViewerID
            // 
            this.textBox_TeamViewerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TeamViewerID.Location = new System.Drawing.Point(460, 37);
            this.textBox_TeamViewerID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TeamViewerID.Name = "textBox_TeamViewerID";
            this.textBox_TeamViewerID.Size = new System.Drawing.Size(169, 21);
            this.textBox_TeamViewerID.TabIndex = 80;
            this.textBox_TeamViewerID.Visible = false;
            this.textBox_TeamViewerID.TextChanged += new System.EventHandler(this.textBox_TeamViewerID_TextChanged);
            // 
            // labelTeamViewerID
            // 
            this.labelTeamViewerID.AutoSize = true;
            this.labelTeamViewerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTeamViewerID.ForeColor = System.Drawing.Color.White;
            this.labelTeamViewerID.Location = new System.Drawing.Point(315, 40);
            this.labelTeamViewerID.Name = "labelTeamViewerID";
            this.labelTeamViewerID.Size = new System.Drawing.Size(94, 15);
            this.labelTeamViewerID.TabIndex = 79;
            this.labelTeamViewerID.Text = "TeamViewer ID ";
            this.labelTeamViewerID.Visible = false;
            // 
            // textBox_TeamViewerPassWord
            // 
            this.textBox_TeamViewerPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TeamViewerPassWord.Location = new System.Drawing.Point(460, 63);
            this.textBox_TeamViewerPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TeamViewerPassWord.Name = "textBox_TeamViewerPassWord";
            this.textBox_TeamViewerPassWord.Size = new System.Drawing.Size(169, 21);
            this.textBox_TeamViewerPassWord.TabIndex = 82;
            this.textBox_TeamViewerPassWord.Visible = false;
            this.textBox_TeamViewerPassWord.TextChanged += new System.EventHandler(this.textBox_TeamViewerPassWord_TextChanged);
            // 
            // labelTeamViewerPassWord
            // 
            this.labelTeamViewerPassWord.AutoSize = true;
            this.labelTeamViewerPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTeamViewerPassWord.ForeColor = System.Drawing.Color.White;
            this.labelTeamViewerPassWord.Location = new System.Drawing.Point(313, 65);
            this.labelTeamViewerPassWord.Name = "labelTeamViewerPassWord";
            this.labelTeamViewerPassWord.Size = new System.Drawing.Size(135, 15);
            this.labelTeamViewerPassWord.TabIndex = 81;
            this.labelTeamViewerPassWord.Text = "TeamViewer PassWord";
            this.labelTeamViewerPassWord.Visible = false;
            // 
            // GmailcheckBox
            // 
            this.GmailcheckBox.AutoSize = true;
            this.GmailcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailcheckBox.ForeColor = System.Drawing.Color.White;
            this.GmailcheckBox.Location = new System.Drawing.Point(38, 95);
            this.GmailcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.GmailcheckBox.Name = "GmailcheckBox";
            this.GmailcheckBox.Size = new System.Drawing.Size(101, 20);
            this.GmailcheckBox.TabIndex = 83;
            this.GmailcheckBox.Text = "Gmail check";
            this.GmailcheckBox.UseVisualStyleBackColor = true;
            this.GmailcheckBox.Visible = false;
            this.GmailcheckBox.CheckedChanged += new System.EventHandler(this.GamilcheckBox_CheckedChanged);
            // 
            // label_ErrorMessage
            // 
            this.label_ErrorMessage.AutoSize = true;
            this.label_ErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorMessage.Location = new System.Drawing.Point(33, 447);
            this.label_ErrorMessage.Name = "label_ErrorMessage";
            this.label_ErrorMessage.Size = new System.Drawing.Size(83, 29);
            this.label_ErrorMessage.TabIndex = 84;
            this.label_ErrorMessage.Text = "~~~~~";
            this.label_ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_To
            // 
            this.pictureBox_To.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_To.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_To.Location = new System.Drawing.Point(329, 144);
            this.pictureBox_To.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_To.Name = "pictureBox_To";
            this.pictureBox_To.Size = new System.Drawing.Size(23, 23);
            this.pictureBox_To.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_To.TabIndex = 92;
            this.pictureBox_To.TabStop = false;
            // 
            // pictureBox_From
            // 
            this.pictureBox_From.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_From.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_From.Location = new System.Drawing.Point(606, 384);
            this.pictureBox_From.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_From.Name = "pictureBox_From";
            this.pictureBox_From.Size = new System.Drawing.Size(23, 23);
            this.pictureBox_From.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_From.TabIndex = 91;
            this.pictureBox_From.TabStop = false;
            this.pictureBox_From.Visible = false;
            // 
            // label_MailSchedule2
            // 
            this.label_MailSchedule2.AutoSize = true;
            this.label_MailSchedule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MailSchedule2.ForeColor = System.Drawing.Color.White;
            this.label_MailSchedule2.Location = new System.Drawing.Point(14, 66);
            this.label_MailSchedule2.Name = "label_MailSchedule2";
            this.label_MailSchedule2.Size = new System.Drawing.Size(72, 16);
            this.label_MailSchedule2.TabIndex = 93;
            this.label_MailSchedule2.Text = "Schedule2";
            // 
            // label_MailSchedule3
            // 
            this.label_MailSchedule3.AutoSize = true;
            this.label_MailSchedule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MailSchedule3.ForeColor = System.Drawing.Color.White;
            this.label_MailSchedule3.Location = new System.Drawing.Point(14, 97);
            this.label_MailSchedule3.Name = "label_MailSchedule3";
            this.label_MailSchedule3.Size = new System.Drawing.Size(72, 16);
            this.label_MailSchedule3.TabIndex = 94;
            this.label_MailSchedule3.Text = "Schedule3";
            // 
            // label_MailSchedule4
            // 
            this.label_MailSchedule4.AutoSize = true;
            this.label_MailSchedule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MailSchedule4.ForeColor = System.Drawing.Color.White;
            this.label_MailSchedule4.Location = new System.Drawing.Point(14, 128);
            this.label_MailSchedule4.Name = "label_MailSchedule4";
            this.label_MailSchedule4.Size = new System.Drawing.Size(72, 16);
            this.label_MailSchedule4.TabIndex = 95;
            this.label_MailSchedule4.Text = "Schedule4";
            // 
            // label_MailSchedule5
            // 
            this.label_MailSchedule5.AutoSize = true;
            this.label_MailSchedule5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MailSchedule5.ForeColor = System.Drawing.Color.White;
            this.label_MailSchedule5.Location = new System.Drawing.Point(14, 159);
            this.label_MailSchedule5.Name = "label_MailSchedule5";
            this.label_MailSchedule5.Size = new System.Drawing.Size(72, 16);
            this.label_MailSchedule5.TabIndex = 96;
            this.label_MailSchedule5.Text = "Schedule5";
            // 
            // lebalNetworkPrompt
            // 
            this.lebalNetworkPrompt.AutoSize = true;
            this.lebalNetworkPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebalNetworkPrompt.ForeColor = System.Drawing.Color.White;
            this.lebalNetworkPrompt.Location = new System.Drawing.Point(136, 96);
            this.lebalNetworkPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lebalNetworkPrompt.Name = "lebalNetworkPrompt";
            this.lebalNetworkPrompt.Size = new System.Drawing.Size(364, 16);
            this.lebalNetworkPrompt.TabIndex = 78;
            this.lebalNetworkPrompt.Text = "( Use this function to check the connection with Gmail server )";
            this.lebalNetworkPrompt.Visible = false;
            // 
            // GroupBox_maileSubject
            // 
            this.GroupBox_maileSubject.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_maileSubject.Controls.Add(this.textBox_TestCase1);
            this.GroupBox_maileSubject.Controls.Add(this.label_MailSchedule5);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_ProjectName);
            this.GroupBox_maileSubject.Controls.Add(this.label_MailSchedule4);
            this.GroupBox_maileSubject.Controls.Add(this.ProjectLabel);
            this.GroupBox_maileSubject.Controls.Add(this.label_MailSchedule3);
            this.GroupBox_maileSubject.Controls.Add(this.VersionLabel);
            this.GroupBox_maileSubject.Controls.Add(this.label_MailSchedule2);
            this.GroupBox_maileSubject.Controls.Add(this.label1);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_Tester);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_Version);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_ModelName);
            this.GroupBox_maileSubject.Controls.Add(this.ModelLabel);
            this.GroupBox_maileSubject.Controls.Add(this.label_MailSchedule1);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_TestCase2);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_TestCase3);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_TestCase4);
            this.GroupBox_maileSubject.Controls.Add(this.textBox_TestCase5);
            this.GroupBox_maileSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_maileSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.GroupBox_maileSubject.Location = new System.Drawing.Point(35, 187);
            this.GroupBox_maileSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox_maileSubject.Name = "GroupBox_maileSubject";
            this.GroupBox_maileSubject.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox_maileSubject.Size = new System.Drawing.Size(591, 188);
            this.GroupBox_maileSubject.TabIndex = 97;
            this.GroupBox_maileSubject.TabStop = false;
            this.GroupBox_maileSubject.Text = "MAIL SUBJECT";
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(658, 494);
            this.Controls.Add(this.GroupBox_maileSubject);
            this.Controls.Add(this.pictureBox_To);
            this.Controls.Add(this.pictureBox_From);
            this.Controls.Add(this.label_ErrorMessage);
            this.Controls.Add(this.GmailcheckBox);
            this.Controls.Add(this.textBox_TeamViewerPassWord);
            this.Controls.Add(this.labelTeamViewerPassWord);
            this.Controls.Add(this.textBox_TeamViewerID);
            this.Controls.Add(this.labelTeamViewerID);
            this.Controls.Add(this.lebalNetworkPrompt);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.textBox_ProjectNumber);
            this.Controls.Add(this.ProjectNumberLabel);
            this.Controls.Add(this.textBox_TotalTestTime);
            this.Controls.Add(this.SendMailcheckBox);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.SaveMailBtn);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.SendMailBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMail";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_From)).EndInit();
            this.GroupBox_maileSubject.ResumeLayout(false);
            this.GroupBox_maileSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.TextBox textBox_From;
        public System.Windows.Forms.Button SendMailBtn;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TotalTestTime;
        private System.Windows.Forms.TextBox textBox_Tester;
        private System.Windows.Forms.TextBox textBox_Version;
        private System.Windows.Forms.Button SaveMailBtn;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox textBox_ModelName;
        private System.Windows.Forms.TextBox textBox_TestCase1;
        private System.Windows.Forms.Label label_MailSchedule1;
        private System.Windows.Forms.TextBox textBox_TestCase2;
        private System.Windows.Forms.TextBox textBox_TestCase3;
        private System.Windows.Forms.TextBox textBox_TestCase4;
        private System.Windows.Forms.TextBox textBox_TestCase5;
        private System.Windows.Forms.TextBox textBox_ProjectNumber;
        private System.Windows.Forms.Label ProjectNumberLabel;
        private System.Windows.Forms.TextBox textBox_TeamViewerID;
        private System.Windows.Forms.Label labelTeamViewerID;
        private System.Windows.Forms.TextBox textBox_TeamViewerPassWord;
        private System.Windows.Forms.Label labelTeamViewerPassWord;
        private System.Windows.Forms.CheckBox GmailcheckBox;
        private System.Windows.Forms.PictureBox pictureBox_From;
        private System.Windows.Forms.PictureBox pictureBox_To;
        private System.Windows.Forms.Label label_MailSchedule2;
        private System.Windows.Forms.Label label_MailSchedule3;
        private System.Windows.Forms.Label label_MailSchedule4;
        private System.Windows.Forms.Label label_MailSchedule5;
        private System.Windows.Forms.Label lebalNetworkPrompt;
        private System.Windows.Forms.GroupBox GroupBox_maileSubject;
        internal System.Windows.Forms.TextBox textBox_To;
        internal System.Windows.Forms.CheckBox SendMailcheckBox;
        internal System.Windows.Forms.Label label_ErrorMessage;
    }
}