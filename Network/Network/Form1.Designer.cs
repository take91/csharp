﻿namespace ChatServer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_Start = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_Start
            // 
            this.cmd_Start.Location = new System.Drawing.Point(30, 12);
            this.cmd_Start.Name = "cmd_Start";
            this.cmd_Start.Size = new System.Drawing.Size(143, 57);
            this.cmd_Start.TabIndex = 0;
            this.cmd_Start.Text = "Server Start";
            this.cmd_Start.UseVisualStyleBackColor = true;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("굴림", 11F);
            this.lbl_Message.Location = new System.Drawing.Point(179, 34);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(170, 15);
            this.lbl_Message.TabIndex = 1;
            this.lbl_Message.Text = "Server Stop 상태입니다.";
            // 
            // txt_Chat
            // 
            this.txt_Chat.Location = new System.Drawing.Point(30, 80);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Chat.Size = new System.Drawing.Size(295, 175);
            this.txt_Chat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.cmd_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Start;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.TextBox txt_Chat;
    }
}

