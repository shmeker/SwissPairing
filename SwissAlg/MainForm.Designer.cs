
namespace SwissAlg
{
	partial class FrmSwissDemo
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnGenerate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.NudPlayerCount = new System.Windows.Forms.NumericUpDown();
			this.NudRoundNumber = new System.Windows.Forms.NumericUpDown();
			this.DgvPlayers = new System.Windows.Forms.DataGridView();
			this.TcRounds = new System.Windows.Forms.TabControl();
			this.tpRound1 = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.NudPlayerCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NudRoundNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvPlayers)).BeginInit();
			this.TcRounds.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnGenerate
			// 
			this.BtnGenerate.Location = new System.Drawing.Point(814, 44);
			this.BtnGenerate.Name = "BtnGenerate";
			this.BtnGenerate.Size = new System.Drawing.Size(150, 46);
			this.BtnGenerate.TabIndex = 0;
			this.BtnGenerate.Text = "Generate";
			this.BtnGenerate.UseVisualStyleBackColor = true;
			this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(123, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Player count:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(464, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "Round number:";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(23, 126);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1720, 19);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// NudPlayerCount
			// 
			this.NudPlayerCount.Location = new System.Drawing.Point(123, 81);
			this.NudPlayerCount.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
			this.NudPlayerCount.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.NudPlayerCount.Name = "NudPlayerCount";
			this.NudPlayerCount.Size = new System.Drawing.Size(240, 39);
			this.NudPlayerCount.TabIndex = 7;
			this.NudPlayerCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			// 
			// NudRoundNumber
			// 
			this.NudRoundNumber.Location = new System.Drawing.Point(464, 81);
			this.NudRoundNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.NudRoundNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NudRoundNumber.Name = "NudRoundNumber";
			this.NudRoundNumber.Size = new System.Drawing.Size(240, 39);
			this.NudRoundNumber.TabIndex = 8;
			this.NudRoundNumber.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			// 
			// DgvPlayers
			// 
			this.DgvPlayers.AllowUserToAddRows = false;
			this.DgvPlayers.AllowUserToDeleteRows = false;
			this.DgvPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.DgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvPlayers.Location = new System.Drawing.Point(38, 177);
			this.DgvPlayers.Name = "DgvPlayers";
			this.DgvPlayers.ReadOnly = true;
			this.DgvPlayers.RowHeadersVisible = false;
			this.DgvPlayers.RowHeadersWidth = 82;
			this.DgvPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DgvPlayers.RowTemplate.Height = 41;
			this.DgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DgvPlayers.Size = new System.Drawing.Size(480, 574);
			this.DgvPlayers.TabIndex = 9;
			// 
			// TcRounds
			// 
			this.TcRounds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TcRounds.Controls.Add(this.tpRound1);
			this.TcRounds.Location = new System.Drawing.Point(566, 177);
			this.TcRounds.Name = "TcRounds";
			this.TcRounds.SelectedIndex = 0;
			this.TcRounds.Size = new System.Drawing.Size(1177, 582);
			this.TcRounds.TabIndex = 10;
			// 
			// tpRound1
			// 
			this.tpRound1.Location = new System.Drawing.Point(8, 46);
			this.tpRound1.Name = "tpRound1";
			this.tpRound1.Padding = new System.Windows.Forms.Padding(3);
			this.tpRound1.Size = new System.Drawing.Size(1161, 528);
			this.tpRound1.TabIndex = 0;
			this.tpRound1.Text = "Round 1";
			this.tpRound1.UseVisualStyleBackColor = true;
			// 
			// FrmSwissDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1775, 782);
			this.Controls.Add(this.TcRounds);
			this.Controls.Add(this.DgvPlayers);
			this.Controls.Add(this.NudRoundNumber);
			this.Controls.Add(this.NudPlayerCount);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnGenerate);
			this.Name = "FrmSwissDemo";
			this.Text = "Swiss pairings demo";
			((System.ComponentModel.ISupportInitialize)(this.NudPlayerCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NudRoundNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvPlayers)).EndInit();
			this.TcRounds.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnGenerate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown NudPlayerCount;
		private System.Windows.Forms.NumericUpDown NudRoundNumber;
		private System.Windows.Forms.DataGridView DgvPlayers;
		private System.Windows.Forms.TabControl TcRounds;
		private System.Windows.Forms.TabPage tpRound1;
	}
}

