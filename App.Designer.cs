
namespace EthminerGUI
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_miners = new System.Windows.Forms.ComboBox();
            this.textBox_wallet = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_args = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_localMachineName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_mining = new System.Windows.Forms.Button();
            this.comboBox_pools = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ethminer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem_exit
            // 
            this.toolStripMenuItem_exit.Name = "toolStripMenuItem_exit";
            this.toolStripMenuItem_exit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_exit.Text = "Exit";
            this.toolStripMenuItem_exit.Click += new System.EventHandler(this.toolStripMenuItem_exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MINER :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(8, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 9);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "POOL";
            // 
            // comboBox_miners
            // 
            this.comboBox_miners.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_miners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_miners.FormattingEnabled = true;
            this.comboBox_miners.Location = new System.Drawing.Point(477, 9);
            this.comboBox_miners.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_miners.Name = "comboBox_miners";
            this.comboBox_miners.Size = new System.Drawing.Size(197, 21);
            this.comboBox_miners.TabIndex = 4;
            this.comboBox_miners.SelectedIndexChanged += new System.EventHandler(this.comboBox_miners_SelectedIndexChanged);
            // 
            // textBox_wallet
            // 
            this.textBox_wallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_wallet.Location = new System.Drawing.Point(119, 58);
            this.textBox_wallet.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_wallet.Name = "textBox_wallet";
            this.textBox_wallet.Size = new System.Drawing.Size(613, 20);
            this.textBox_wallet.TabIndex = 9;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(477, 32);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(255, 20);
            this.textBox_password.TabIndex = 11;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BTC ADDRESS ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PASSWORD ";
            // 
            // textBox_args
            // 
            this.textBox_args.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_args.Location = new System.Drawing.Point(119, 82);
            this.textBox_args.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_args.Name = "textBox_args";
            this.textBox_args.Size = new System.Drawing.Size(613, 20);
            this.textBox_args.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "COMMAND：";
            // 
            // textBox_localMachineName
            // 
            this.textBox_localMachineName.Location = new System.Drawing.Point(119, 8);
            this.textBox_localMachineName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_localMachineName.Name = "textBox_localMachineName";
            this.textBox_localMachineName.Size = new System.Drawing.Size(231, 20);
            this.textBox_localMachineName.TabIndex = 2;
            this.textBox_localMachineName.TextChanged += new System.EventHandler(this.textBox_localMachineName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "RIG_NAME :";
            // 
            // button_mining
            // 
            this.button_mining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_mining.Location = new System.Drawing.Point(678, 7);
            this.button_mining.Margin = new System.Windows.Forms.Padding(2);
            this.button_mining.Name = "button_mining";
            this.button_mining.Size = new System.Drawing.Size(54, 23);
            this.button_mining.TabIndex = 5;
            this.button_mining.Text = "START";
            this.button_mining.UseVisualStyleBackColor = true;
            this.button_mining.Click += new System.EventHandler(this.button_mining_Click);
            // 
            // comboBox_pools
            // 
            this.comboBox_pools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_pools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pools.FormattingEnabled = true;
            this.comboBox_pools.Location = new System.Drawing.Point(119, 32);
            this.comboBox_pools.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_pools.Name = "comboBox_pools";
            this.comboBox_pools.Size = new System.Drawing.Size(231, 21);
            this.comboBox_pools.TabIndex = 22;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 117);
            this.Controls.Add(this.comboBox_pools);
            this.Controls.Add(this.button_mining);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_localMachineName);
            this.Controls.Add(this.textBox_args);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_wallet);
            this.Controls.Add(this.comboBox_miners);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(751, 148);
            this.MinimumSize = new System.Drawing.Size(751, 148);
            this.Name = "App";
            this.Text = "ETHMINER-RICHPOOL";
            this.Load += new System.EventHandler(this.App_Load);
            this.Resize += new System.EventHandler(this.App_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_miners;
        private System.Windows.Forms.TextBox textBox_wallet;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_args;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_localMachineName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_mining;
        private System.Windows.Forms.ComboBox comboBox_pools;
    }
}

