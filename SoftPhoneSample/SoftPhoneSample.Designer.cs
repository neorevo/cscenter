namespace SoftPhoneSample
{
    partial class SoftPhoneSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftPhoneSample));
            this.iCapi = new AxICAPILib.AxICAPI();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.txt_UserId = new System.Windows.Forms.TextBox();
            this.txt_UserPw = new System.Windows.Forms.TextBox();
            this.lbl_UserPw = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AnswerCallNumber = new System.Windows.Forms.TextBox();
            this.btn_AnswerCall = new System.Windows.Forms.Button();
            this.btn_ClearCall = new System.Windows.Forms.Button();
            this.txt_AgentDn = new System.Windows.Forms.TextBox();
            this.lbl_AgentDn = new System.Windows.Forms.Label();
            this.txt_DestDn = new System.Windows.Forms.TextBox();
            this.lbl_DestDn = new System.Windows.Forms.Label();
            this.btn_MakeCall = new System.Windows.Forms.Button();
            this.lbl_LogLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.iCapi)).BeginInit();
            this.SuspendLayout();
            // 
            // iCapi
            // 
            this.iCapi.Enabled = true;
            this.iCapi.Location = new System.Drawing.Point(404, 280);
            this.iCapi.Margin = new System.Windows.Forms.Padding(4);
            this.iCapi.Name = "iCapi";
            this.iCapi.OcxState = ((System.Windows.Forms.AxHost.State) (resources.GetObject("iCapi.OcxState")));
            this.iCapi.Size = new System.Drawing.Size(150, 75);
            this.iCapi.TabIndex = 0;
            this.iCapi.Visible = false;
            this.iCapi.Ringing += new AxICAPILib._DICAPIEvents_RingingEventHandler(this.iCapi_Ringing);
            this.iCapi.AgentLogin += new AxICAPILib._DICAPIEvents_AgentLoginEventHandler(this.iCapi_AgentLogin);
            this.iCapi.ResponseAnswerCall += new AxICAPILib._DICAPIEvents_ResponseAnswerCallEventHandler(this.iCapi_ResponseAnswerCall);
            this.iCapi.ResponseAgentLogin += new AxICAPILib._DICAPIEvents_ResponseAgentLoginEventHandler(this.iCapi_ResponseAgentLogin);
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(31, 20);
            this.lbl_UserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(62, 18);
            this.lbl_UserId.TabIndex = 1;
            this.lbl_UserId.Text = "아이디";
            // 
            // txt_UserId
            // 
            this.txt_UserId.Location = new System.Drawing.Point(135, 16);
            this.txt_UserId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserId.Name = "txt_UserId";
            this.txt_UserId.Size = new System.Drawing.Size(284, 28);
            this.txt_UserId.TabIndex = 2;
            // 
            // txt_UserPw
            // 
            this.txt_UserPw.Location = new System.Drawing.Point(135, 49);
            this.txt_UserPw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserPw.Name = "txt_UserPw";
            this.txt_UserPw.PasswordChar = '*';
            this.txt_UserPw.Size = new System.Drawing.Size(284, 28);
            this.txt_UserPw.TabIndex = 4;
            // 
            // lbl_UserPw
            // 
            this.lbl_UserPw.AutoSize = true;
            this.lbl_UserPw.Location = new System.Drawing.Point(17, 52);
            this.lbl_UserPw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserPw.Name = "lbl_UserPw";
            this.lbl_UserPw.Size = new System.Drawing.Size(80, 18);
            this.lbl_UserPw.TabIndex = 3;
            this.lbl_UserPw.Text = "비밀번호";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(429, 16);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 99);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "전화번호";
            // 
            // txt_AnswerCallNumber
            // 
            this.txt_AnswerCallNumber.Location = new System.Drawing.Point(135, 139);
            this.txt_AnswerCallNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AnswerCallNumber.MaxLength = 11;
            this.txt_AnswerCallNumber.Name = "txt_AnswerCallNumber";
            this.txt_AnswerCallNumber.ReadOnly = true;
            this.txt_AnswerCallNumber.Size = new System.Drawing.Size(284, 28);
            this.txt_AnswerCallNumber.TabIndex = 7;
            // 
            // btn_AnswerCall
            // 
            this.btn_AnswerCall.Location = new System.Drawing.Point(429, 139);
            this.btn_AnswerCall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AnswerCall.Name = "btn_AnswerCall";
            this.btn_AnswerCall.Size = new System.Drawing.Size(107, 32);
            this.btn_AnswerCall.TabIndex = 8;
            this.btn_AnswerCall.Text = "전화 받기";
            this.btn_AnswerCall.UseVisualStyleBackColor = true;
            this.btn_AnswerCall.Click += new System.EventHandler(this.btn_AnswerCall_Click);
            // 
            // btn_ClearCall
            // 
            this.btn_ClearCall.Location = new System.Drawing.Point(429, 179);
            this.btn_ClearCall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClearCall.Name = "btn_ClearCall";
            this.btn_ClearCall.Size = new System.Drawing.Size(107, 32);
            this.btn_ClearCall.TabIndex = 9;
            this.btn_ClearCall.Text = "전화 끊기";
            this.btn_ClearCall.UseVisualStyleBackColor = true;
            this.btn_ClearCall.Click += new System.EventHandler(this.btn_ClearCall_Click);
            // 
            // txt_AgentDn
            // 
            this.txt_AgentDn.Location = new System.Drawing.Point(135, 83);
            this.txt_AgentDn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_AgentDn.Name = "txt_AgentDn";
            this.txt_AgentDn.Size = new System.Drawing.Size(284, 28);
            this.txt_AgentDn.TabIndex = 11;
            // 
            // lbl_AgentDn
            // 
            this.lbl_AgentDn.AutoSize = true;
            this.lbl_AgentDn.Location = new System.Drawing.Point(59, 87);
            this.lbl_AgentDn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AgentDn.Name = "lbl_AgentDn";
            this.lbl_AgentDn.Size = new System.Drawing.Size(31, 18);
            this.lbl_AgentDn.TabIndex = 10;
            this.lbl_AgentDn.Text = "DN";
            // 
            // txt_DestDn
            // 
            this.txt_DestDn.Location = new System.Drawing.Point(135, 223);
            this.txt_DestDn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DestDn.Name = "txt_DestDn";
            this.txt_DestDn.PasswordChar = '*';
            this.txt_DestDn.Size = new System.Drawing.Size(284, 28);
            this.txt_DestDn.TabIndex = 13;
            // 
            // lbl_DestDn
            // 
            this.lbl_DestDn.AutoSize = true;
            this.lbl_DestDn.Location = new System.Drawing.Point(20, 228);
            this.lbl_DestDn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DestDn.Name = "lbl_DestDn";
            this.lbl_DestDn.Size = new System.Drawing.Size(73, 18);
            this.lbl_DestDn.TabIndex = 12;
            this.lbl_DestDn.Text = "Dest DN";
            // 
            // btn_MakeCall
            // 
            this.btn_MakeCall.Location = new System.Drawing.Point(429, 223);
            this.btn_MakeCall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MakeCall.Name = "btn_MakeCall";
            this.btn_MakeCall.Size = new System.Drawing.Size(107, 32);
            this.btn_MakeCall.TabIndex = 14;
            this.btn_MakeCall.Text = "전화 걸기";
            this.btn_MakeCall.UseVisualStyleBackColor = true;
            this.btn_MakeCall.Click += new System.EventHandler(this.btn_MakeCall_Click);
            // 
            // lbl_LogLabel
            // 
            this.lbl_LogLabel.Location = new System.Drawing.Point(-1, 309);
            this.lbl_LogLabel.Name = "lbl_LogLabel";
            this.lbl_LogLabel.Size = new System.Drawing.Size(555, 46);
            this.lbl_LogLabel.TabIndex = 15;
            this.lbl_LogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SoftPhoneSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 356);
            this.Controls.Add(this.lbl_LogLabel);
            this.Controls.Add(this.btn_MakeCall);
            this.Controls.Add(this.txt_DestDn);
            this.Controls.Add(this.lbl_DestDn);
            this.Controls.Add(this.txt_AgentDn);
            this.Controls.Add(this.lbl_AgentDn);
            this.Controls.Add(this.btn_ClearCall);
            this.Controls.Add(this.btn_AnswerCall);
            this.Controls.Add(this.txt_AnswerCallNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_UserPw);
            this.Controls.Add(this.lbl_UserPw);
            this.Controls.Add(this.txt_UserId);
            this.Controls.Add(this.lbl_UserId);
            this.Controls.Add(this.iCapi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SoftPhoneSample";
            this.Text = "Soft Phone Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoftPhoneSample_FormClosed);
            ((System.ComponentModel.ISupportInitialize) (this.iCapi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_AnswerCall;
        private System.Windows.Forms.Button btn_ClearCall;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_MakeCall;
        private AxICAPILib.AxICAPI iCapi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AgentDn;
        private System.Windows.Forms.Label lbl_DestDn;
        private System.Windows.Forms.Label lbl_LogLabel;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Label lbl_UserPw;
        private System.Windows.Forms.TextBox txt_AgentDn;
        private System.Windows.Forms.TextBox txt_AnswerCallNumber;
        private System.Windows.Forms.TextBox txt_DestDn;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.TextBox txt_UserPw;

        #endregion
    }
}