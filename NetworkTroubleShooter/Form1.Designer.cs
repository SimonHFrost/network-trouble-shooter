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
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnPingModem, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnPingRouter, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnPingGoogle, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnCheckDNS, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPingModem, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPingRouter, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPingGoogle, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCheckDNS, 2, 3);
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
			this.btnPingGoogle.Text = "Ping Google";
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
			this.textBoxPingModem.Location = new System.Drawing.Point(203, 3);
			this.textBoxPingModem.Multiline = true;
			this.textBoxPingModem.Name = "textBoxPingModem";
			this.textBoxPingModem.Size = new System.Drawing.Size(299, 66);
			this.textBoxPingModem.TabIndex = 2;
			// 
			// textBoxPingRouter
			// 
			this.textBoxPingRouter.Location = new System.Drawing.Point(203, 75);
			this.textBoxPingRouter.Multiline = true;
			this.textBoxPingRouter.Name = "textBoxPingRouter";
			this.textBoxPingRouter.Size = new System.Drawing.Size(299, 66);
			this.textBoxPingRouter.TabIndex = 2;
			// 
			// textBoxPingGoogle
			// 
			this.textBoxPingGoogle.Location = new System.Drawing.Point(203, 147);
			this.textBoxPingGoogle.Multiline = true;
			this.textBoxPingGoogle.Name = "textBoxPingGoogle";
			this.textBoxPingGoogle.Size = new System.Drawing.Size(299, 66);
			this.textBoxPingGoogle.TabIndex = 2;
			// 
			// textBoxCheckDNS
			// 
			this.textBoxCheckDNS.Location = new System.Drawing.Point(203, 219);
			this.textBoxCheckDNS.Multiline = true;
			this.textBoxCheckDNS.Name = "textBoxCheckDNS";
			this.textBoxCheckDNS.Size = new System.Drawing.Size(299, 66);
			this.textBoxCheckDNS.TabIndex = 2;
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
	}
}

