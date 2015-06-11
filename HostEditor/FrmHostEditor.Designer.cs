namespace HostEditor
{
    partial class FrmHostEditor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHostEditor));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGroup = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtServerAddress = new System.Windows.Forms.ComboBox();
			this.btnSolve = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "服务器名(&N)：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "服务器地址(&A)：";
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(14, 24);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(316, 21);
			this.txtServerName.TabIndex = 1;
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(14, 113);
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(500, 21);
			this.txtComment.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "备注(&M)：";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(358, 141);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.OnBtnOKClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(361, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "分组(&G)：";
			// 
			// txtGroup
			// 
			this.txtGroup.FormattingEnabled = true;
			this.txtGroup.Items.AddRange(new object[] {
            "默认"});
			this.txtGroup.Location = new System.Drawing.Point(363, 24);
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.Size = new System.Drawing.Size(151, 20);
			this.txtGroup.TabIndex = 4;
			this.txtGroup.Text = "默认";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(439, 141);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.OnBtnCancelClick);
			// 
			// txtServerAddress
			// 
			this.txtServerAddress.FormattingEnabled = true;
			this.txtServerAddress.Location = new System.Drawing.Point(14, 70);
			this.txtServerAddress.Name = "txtServerAddress";
			this.txtServerAddress.Size = new System.Drawing.Size(500, 20);
			this.txtServerAddress.TabIndex = 6;
			// 
			// btnSolve
			// 
			this.btnSolve.Image = ((System.Drawing.Image)(resources.GetObject("btnSolve.Image")));
			this.btnSolve.Location = new System.Drawing.Point(333, 22);
			this.btnSolve.Name = "btnSolve";
			this.btnSolve.Size = new System.Drawing.Size(24, 24);
			this.btnSolve.TabIndex = 2;
			this.toolTip1.SetToolTip(this.btnSolve, "使用现有网络连接来解析该服务器");
			this.btnSolve.UseVisualStyleBackColor = true;
			this.btnSolve.Click += new System.EventHandler(this.OnDnsSolveRequest);
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "解析";
			// 
			// FrmHostEditor
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(530, 176);
			this.Controls.Add(this.btnSolve);
			this.Controls.Add(this.txtServerAddress);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtGroup);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtComment);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtServerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmHostEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "HostEditor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHostEditor_FormClosing);
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox txtGroup;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox txtServerAddress;
		private System.Windows.Forms.Button btnSolve;
		private System.Windows.Forms.ToolTip toolTip1;
    }
}