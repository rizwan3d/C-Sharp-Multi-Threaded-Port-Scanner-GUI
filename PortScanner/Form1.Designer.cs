namespace PortScanner
{
    partial class Form1
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
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtStartPort = new System.Windows.Forms.TextBox();
            this.txtEndPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCurrentPort = new System.Windows.Forms.ToolStripProgressBar();
            this.txtTcpTimeout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(309, 8);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(215, 20);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "127.0.0.1";
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // txtStartPort
            // 
            this.txtStartPort.Location = new System.Drawing.Point(309, 34);
            this.txtStartPort.Name = "txtStartPort";
            this.txtStartPort.Size = new System.Drawing.Size(215, 20);
            this.txtStartPort.TabIndex = 1;
            this.txtStartPort.Text = "0";
            // 
            // txtEndPort
            // 
            this.txtEndPort.Location = new System.Drawing.Point(309, 60);
            this.txtEndPort.Name = "txtEndPort";
            this.txtEndPort.Size = new System.Drawing.Size(215, 20);
            this.txtEndPort.TabIndex = 2;
            this.txtEndPort.Text = "65535";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(530, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 99);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(672, 279);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Port";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Open/Close";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Banner Grab";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.txtCurrentPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(693, 23);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 18);
            this.toolStripStatusLabel1.Text = "By Muhammad Rizwan";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(389, 18);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(52, 18);
            this.toolStripStatusLabel3.Text = "Progress";
            // 
            // txtCurrentPort
            // 
            this.txtCurrentPort.Name = "txtCurrentPort";
            this.txtCurrentPort.Size = new System.Drawing.Size(118, 17);
            // 
            // txtTcpTimeout
            // 
            this.txtTcpTimeout.Location = new System.Drawing.Point(309, 86);
            this.txtTcpTimeout.Name = "txtTcpTimeout";
            this.txtTcpTimeout.Size = new System.Drawing.Size(215, 20);
            this.txtTcpTimeout.TabIndex = 4;
            this.txtTcpTimeout.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Host I.P or Domain example: (127.0.0.1) or (localhost)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter A start Port : (0) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter A End Port : (65535)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Normal Timeout amount is between 1 - 10 secs \r\n( 1 = 1 second)(higher timeout = h" +
    "igher accuracy)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTcpTimeout);
            this.Controls.Add(this.txtEndPort);
            this.Controls.Add(this.txtStartPort);
            this.Controls.Add(this.txtIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtStartPort;
        private System.Windows.Forms.TextBox txtEndPort;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtTcpTimeout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripProgressBar txtCurrentPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

