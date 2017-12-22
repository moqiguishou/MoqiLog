namespace moqi_log
{
    partial class MoqiLog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.log_path = new System.Windows.Forms.Label();
            this.text_LogPath = new System.Windows.Forms.TextBox();
            this.log_details = new System.Windows.Forms.Label();
            this.text_LogDetails = new System.Windows.Forms.TextBox();
            this.btn_ShowDetails = new System.Windows.Forms.Button();
            this.text_Add = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lab_Add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_path
            // 
            this.log_path.AutoSize = true;
            this.log_path.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log_path.Location = new System.Drawing.Point(80, 64);
            this.log_path.Name = "log_path";
            this.log_path.Size = new System.Drawing.Size(63, 14);
            this.log_path.TabIndex = 0;
            this.log_path.Text = "日志路径";
            // 
            // text_LogPath
            // 
            this.text_LogPath.Location = new System.Drawing.Point(195, 63);
            this.text_LogPath.Name = "text_LogPath";
            this.text_LogPath.Size = new System.Drawing.Size(383, 21);
            this.text_LogPath.TabIndex = 1;
            // 
            // log_details
            // 
            this.log_details.AutoSize = true;
            this.log_details.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log_details.Location = new System.Drawing.Point(80, 116);
            this.log_details.Name = "log_details";
            this.log_details.Size = new System.Drawing.Size(63, 14);
            this.log_details.TabIndex = 2;
            this.log_details.Text = "日志详情";
            // 
            // text_LogDetails
            // 
            this.text_LogDetails.Location = new System.Drawing.Point(195, 115);
            this.text_LogDetails.Multiline = true;
            this.text_LogDetails.Name = "text_LogDetails";
            this.text_LogDetails.Size = new System.Drawing.Size(383, 145);
            this.text_LogDetails.TabIndex = 3;
            // 
            // btn_ShowDetails
            // 
            this.btn_ShowDetails.Location = new System.Drawing.Point(83, 150);
            this.btn_ShowDetails.Name = "btn_ShowDetails";
            this.btn_ShowDetails.Size = new System.Drawing.Size(60, 23);
            this.btn_ShowDetails.TabIndex = 4;
            this.btn_ShowDetails.Text = "显示";
            this.btn_ShowDetails.UseVisualStyleBackColor = true;
            this.btn_ShowDetails.Click += new System.EventHandler(this.btn_ShowDetails_Click);
            // 
            // text_Add
            // 
            this.text_Add.Location = new System.Drawing.Point(195, 303);
            this.text_Add.Multiline = true;
            this.text_Add.Name = "text_Add";
            this.text_Add.Size = new System.Drawing.Size(383, 86);
            this.text_Add.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(347, 431);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "确认添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lab_Add
            // 
            this.lab_Add.AutoSize = true;
            this.lab_Add.Location = new System.Drawing.Point(81, 317);
            this.lab_Add.Name = "lab_Add";
            this.lab_Add.Size = new System.Drawing.Size(53, 12);
            this.lab_Add.TabIndex = 7;
            this.lab_Add.Text = "添加日志";
            // 
            // MoqiLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.lab_Add);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.text_Add);
            this.Controls.Add(this.btn_ShowDetails);
            this.Controls.Add(this.text_LogDetails);
            this.Controls.Add(this.log_details);
            this.Controls.Add(this.text_LogPath);
            this.Controls.Add(this.log_path);
            this.Name = "MoqiLog";
            this.Text = "MoqiLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log_path;
        private System.Windows.Forms.TextBox text_LogPath;
        private System.Windows.Forms.Label log_details;
        private System.Windows.Forms.TextBox text_LogDetails;
        private System.Windows.Forms.Button btn_ShowDetails;
        private System.Windows.Forms.TextBox text_Add;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lab_Add;
    }
}

