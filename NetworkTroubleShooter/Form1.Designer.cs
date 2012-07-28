namespace NetworkTroubleShooter {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPingModem = new System.Windows.Forms.Button();
			this.btnPingRouter = new System.Windows.Forms.Button();
			this.btnPingGoogle = new System.Windows.Forms.Button();
			this.btnCheckDNS = new System.Windows.Forms.Button();
			this.textBoxPingModem = new System.Windows.Forms.TextBox();
			this.textBoxPingRouter = new System.Windows.Forms.TextBox();
			this.textBoxPingGoogle = new System.Windows.Forms.TextBox();
			this.textBoxCheckDNS = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxEnterModem = new System.Windows.Forms.TextBox();
			this.labelModem = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxEnterRouter = new System.Windows.Forms.TextBox();
			this.labelRouter = new System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxEnterGoogle = new System.Windows.Forms.TextBox();
			this.labelGoogle = new System.Windows.Forms.Label();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBoxEnterDns = new System.Windows.Forms.TextBox();
			this.labelDns = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnPingModem, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnPingRouter, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnPingGoogle, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnCheckDNS, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPingModem, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPingRouter, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPingGoogle, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCheckDNS, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 288);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnPingModem
			// 
			this.btnPingModem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnPingModem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnPingModem.Location = new System.Drawing.Point(3, 3);
			this.btnPingModem.Name = "btnPingModem";
			this.btnPingModem.Size = new System.Drawing.Size(94, 66);
			this.btnPingModem.TabIndex = 0;
			this.btnPingModem.Text = "Ping Modem";
			this.btnPingModem.UseVisualStyleBackColor = false;
			this.btnPingModem.Click += new System.EventHandler(this.btnPingModem_Click);
			// 
			// btnPingRouter
			// 
			this.btnPingRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnPingRouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPingRouter.Location = new System.Drawing.Point(3, 75);
			this.btnPingRouter.Name = "btnPingRouter";
			this.btnPingRouter.Size = new System.Drawing.Size(94, 66);
			this.btnPingRouter.TabIndex = 1;
			this.btnPingRouter.Text = "Ping Router";
			this.btnPingRouter.UseVisualStyleBackColor = false;
			this.btnPingRouter.Click += new System.EventHandler(this.btnPingRouter_Click);
			// 
			// btnPingGoogle
			// 
			this.btnPingGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnPingGoogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPingGoogle.Location = new System.Drawing.Point(3, 147);
			this.btnPingGoogle.Name = "btnPingGoogle";
			this.btnPingGoogle.Size = new System.Drawing.Size(94, 66);
			this.btnPingGoogle.TabIndex = 1;
			this.btnPingGoogle.Text = "Ping Website";
			this.btnPingGoogle.UseVisualStyleBackColor = false;
			this.btnPingGoogle.Click += new System.EventHandler(this.btnPingGoogle_Click);
			// 
			// btnCheckDNS
			// 
			this.btnCheckDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnCheckDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnCheckDNS.Location = new System.Drawing.Point(3, 219);
			this.btnCheckDNS.Name = "btnCheckDNS";
			this.btnCheckDNS.Size = new System.Drawing.Size(94, 66);
			this.btnCheckDNS.TabIndex = 1;
			this.btnCheckDNS.Text = "Check DNS";
			this.btnCheckDNS.UseVisualStyleBackColor = false;
			this.btnCheckDNS.Click += new System.EventHandler(this.btnCheckDNS_Click);
			// 
			// textBoxPingModem
			// 
			this.textBoxPingModem.Location = new System.Drawing.Point(261, 3);
			this.textBoxPingModem.Multiline = true;
			this.textBoxPingModem.Name = "textBoxPingModem";
			this.textBoxPingModem.Size = new System.Drawing.Size(241, 66);
			this.textBoxPingModem.TabIndex = 2;
			// 
			// textBoxPingRouter
			// 
			this.textBoxPingRouter.Location = new System.Drawing.Point(261, 75);
			this.textBoxPingRouter.Multiline = true;
			this.textBoxPingRouter.Name = "textBoxPingRouter";
			this.textBoxPingRouter.Size = new System.Drawing.Size(241, 66);
			this.textBoxPingRouter.TabIndex = 2;
			// 
			// textBoxPingGoogle
			// 
			this.textBoxPingGoogle.Location = new System.Drawing.Point(261, 147);
			this.textBoxPingGoogle.Multiline = true;
			this.textBoxPingGoogle.Name = "textBoxPingGoogle";
			this.textBoxPingGoogle.Size = new System.Drawing.Size(241, 66);
			this.textBoxPingGoogle.TabIndex = 2;
			// 
			// textBoxCheckDNS
			// 
			this.textBoxCheckDNS.Location = new System.Drawing.Point(261, 219);
			this.textBoxCheckDNS.Multiline = true;
			this.textBoxCheckDNS.Name = "textBoxCheckDNS";
			this.textBoxCheckDNS.Size = new System.Drawing.Size(241, 66);
			this.textBoxCheckDNS.TabIndex = 2;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.textBoxEnterModem);
			this.flowLayoutPanel1.Controls.Add(this.labelModem);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 66);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// textBoxEnterModem
			// 
			this.textBoxEnterModem.Location = new System.Drawing.Point(3, 3);
			this.textBoxEnterModem.Name = "textBoxEnterModem";
			this.textBoxEnterModem.Size = new System.Drawing.Size(149, 20);
			this.textBoxEnterModem.TabIndex = 4;
			// 
			// labelModem
			// 
			this.labelModem.AutoSize = true;
			this.labelModem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelModem.Location = new System.Drawing.Point(3, 26);
			this.labelModem.Name = "labelModem";
			this.labelModem.Size = new System.Drawing.Size(40, 13);
			this.labelModem.TabIndex = 5;
			this.labelModem.Text = "Status:";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.textBoxEnterRouter);
			this.flowLayoutPanel2.Controls.Add(this.labelRouter);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(103, 75);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(152, 66);
			this.flowLayoutPanel2.TabIndex = 8;
			// 
			// textBoxEnterRouter
			// 
			this.textBoxEnterRouter.Location = new System.Drawing.Point(3, 3);
			this.textBoxEnterRouter.Name = "textBoxEnterRouter";
			this.textBoxEnterRouter.Size = new System.Drawing.Size(149, 20);
			this.textBoxEnterRouter.TabIndex = 5;
			// 
			// labelRouter
			// 
			this.labelRouter.AutoSize = true;
			this.labelRouter.Location = new System.Drawing.Point(3, 26);
			this.labelRouter.Name = "labelRouter";
			this.labelRouter.Size = new System.Drawing.Size(40, 13);
			this.labelRouter.TabIndex = 5;
			this.labelRouter.Text = "Status:";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.textBoxEnterGoogle);
			this.flowLayoutPanel3.Controls.Add(this.labelGoogle);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(103, 147);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(152, 66);
			this.flowLayoutPanel3.TabIndex = 9;
			// 
			// textBoxEnterGoogle
			// 
			this.textBoxEnterGoogle.Location = new System.Drawing.Point(3, 3);
			this.textBoxEnterGoogle.Name = "textBoxEnterGoogle";
			this.textBoxEnterGoogle.Size = new System.Drawing.Size(149, 20);
			this.textBoxEnterGoogle.TabIndex = 6;
			// 
			// labelGoogle
			// 
			this.labelGoogle.AutoSize = true;
			this.labelGoogle.Location = new System.Drawing.Point(3, 26);
			this.labelGoogle.Name = "labelGoogle";
			this.labelGoogle.Size = new System.Drawing.Size(40, 13);
			this.labelGoogle.TabIndex = 5;
			this.labelGoogle.Text = "Status:";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.Controls.Add(this.textBoxEnterDns);
			this.flowLayoutPanel4.Controls.Add(this.labelDns);
			this.flowLayoutPanel4.Location = new System.Drawing.Point(103, 219);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(152, 66);
			this.flowLayoutPanel4.TabIndex = 10;
			// 
			// textBoxEnterDns
			// 
			this.textBoxEnterDns.Location = new System.Drawing.Point(3, 3);
			this.textBoxEnterDns.Name = "textBoxEnterDns";
			this.textBoxEnterDns.Size = new System.Drawing.Size(149, 20);
			this.textBoxEnterDns.TabIndex = 7;
			// 
			// labelDns
			// 
			this.labelDns.AutoSize = true;
			this.labelDns.Location = new System.Drawing.Point(3, 26);
			this.labelDns.Name = "labelDns";
			this.labelDns.Size = new System.Drawing.Size(40, 13);
			this.labelDns.TabIndex = 5;
			this.labelDns.Text = "Status:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 312);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(545, 350);
			this.MinimumSize = new System.Drawing.Size(545, 350);
			this.Name = "Form1";
			this.Text = "Network Troubleshooter";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnPingModem;
		private System.Windows.Forms.Button btnPingRouter;
		private System.Windows.Forms.Button btnPingGoogle;
		private System.Windows.Forms.Button btnCheckDNS;
		private System.Windows.Forms.TextBox textBoxPingModem;
		private System.Windows.Forms.TextBox textBoxPingRouter;
		private System.Windows.Forms.TextBox textBoxPingGoogle;
		private System.Windows.Forms.TextBox textBoxCheckDNS;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox textBoxEnterModem;
		private System.Windows.Forms.Label labelModem;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.TextBox textBoxEnterRouter;
		private System.Windows.Forms.Label labelRouter;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.TextBox textBoxEnterGoogle;
		private System.Windows.Forms.Label labelGoogle;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.TextBox textBoxEnterDns;
		private System.Windows.Forms.Label labelDns;
	}
}

