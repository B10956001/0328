
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_listen_port = new System.Windows.Forms.TextBox();
            this.textBox_recive_msg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_target_IP = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_target_port = new System.Windows.Forms.TextBox();
            this.button_start_get = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "接聽 Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(58, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "接聽文字";
            // 
            // textBox_listen_port
            // 
            this.textBox_listen_port.Location = new System.Drawing.Point(180, 101);
            this.textBox_listen_port.Name = "textBox_listen_port";
            this.textBox_listen_port.Size = new System.Drawing.Size(100, 22);
            this.textBox_listen_port.TabIndex = 2;
            this.textBox_listen_port.TextChanged += new System.EventHandler(this.textBox_listen_port_TextChanged);
            // 
            // textBox_recive_msg
            // 
            this.textBox_recive_msg.Location = new System.Drawing.Point(180, 142);
            this.textBox_recive_msg.Name = "textBox_recive_msg";
            this.textBox_recive_msg.Size = new System.Drawing.Size(309, 22);
            this.textBox_recive_msg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(77, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "目標IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(58, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "目標 Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(58, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "傳送文字";
            // 
            // textBox_target_IP
            // 
            this.textBox_target_IP.Location = new System.Drawing.Point(180, 245);
            this.textBox_target_IP.Name = "textBox_target_IP";
            this.textBox_target_IP.Size = new System.Drawing.Size(100, 22);
            this.textBox_target_IP.TabIndex = 7;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(180, 326);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(309, 22);
            this.textBox_send.TabIndex = 8;
            // 
            // textBox_target_port
            // 
            this.textBox_target_port.Location = new System.Drawing.Point(180, 284);
            this.textBox_target_port.Name = "textBox_target_port";
            this.textBox_target_port.Size = new System.Drawing.Size(100, 22);
            this.textBox_target_port.TabIndex = 9;
            // 
            // button_start_get
            // 
            this.button_start_get.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_start_get.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_start_get.Location = new System.Drawing.Point(601, 140);
            this.button_start_get.Name = "button_start_get";
            this.button_start_get.Size = new System.Drawing.Size(103, 24);
            this.button_start_get.TabIndex = 10;
            this.button_start_get.Text = "啟動接收";
            this.button_start_get.UseVisualStyleBackColor = true;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_send.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_send.Location = new System.Drawing.Point(601, 322);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(103, 24);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "傳送";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_start_get);
            this.Controls.Add(this.textBox_target_port);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_target_IP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_recive_msg);
            this.Controls.Add(this.textBox_listen_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_listen_port;
        private System.Windows.Forms.TextBox textBox_recive_msg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_target_IP;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_target_port;
        private System.Windows.Forms.Button button_start_get;
        private System.Windows.Forms.Button button_send;
    }
}

