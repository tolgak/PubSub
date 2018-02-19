namespace PubSub
{
  partial class frmFeature
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
      this.txtLog = new System.Windows.Forms.TextBox();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.btnResubscribe = new System.Windows.Forms.Button();
      this.lblTopic3 = new System.Windows.Forms.Label();
      this.lblTopic2 = new System.Windows.Forms.Label();
      this.lblTopic1 = new System.Windows.Forms.Label();
      this.lblMessageInfo = new System.Windows.Forms.Label();
      this.btnPublish = new System.Windows.Forms.Button();
      this.pnlTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtLog
      // 
      this.txtLog.BackColor = System.Drawing.Color.Black;
      this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtLog.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtLog.ForeColor = System.Drawing.Color.Lime;
      this.txtLog.Location = new System.Drawing.Point(4, 88);
      this.txtLog.Multiline = true;
      this.txtLog.Name = "txtLog";
      this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtLog.Size = new System.Drawing.Size(474, 369);
      this.txtLog.TabIndex = 0;
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.btnResubscribe);
      this.pnlTop.Controls.Add(this.lblTopic3);
      this.pnlTop.Controls.Add(this.lblTopic2);
      this.pnlTop.Controls.Add(this.lblTopic1);
      this.pnlTop.Controls.Add(this.lblMessageInfo);
      this.pnlTop.Controls.Add(this.btnPublish);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(4, 4);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(474, 84);
      this.pnlTop.TabIndex = 1;
      // 
      // btnResubscribe
      // 
      this.btnResubscribe.Location = new System.Drawing.Point(380, 33);
      this.btnResubscribe.Name = "btnResubscribe";
      this.btnResubscribe.Size = new System.Drawing.Size(91, 23);
      this.btnResubscribe.TabIndex = 5;
      this.btnResubscribe.Text = "Rescubscribe";
      this.btnResubscribe.UseVisualStyleBackColor = true;
      this.btnResubscribe.Click += new System.EventHandler(this.btnResubscribe_Click);
      // 
      // lblTopic3
      // 
      this.lblTopic3.AutoSize = true;
      this.lblTopic3.Location = new System.Drawing.Point(3, 56);
      this.lblTopic3.Name = "lblTopic3";
      this.lblTopic3.Size = new System.Drawing.Size(35, 13);
      this.lblTopic3.TabIndex = 4;
      this.lblTopic3.Text = "label3";
      // 
      // lblTopic2
      // 
      this.lblTopic2.AutoSize = true;
      this.lblTopic2.Location = new System.Drawing.Point(3, 43);
      this.lblTopic2.Name = "lblTopic2";
      this.lblTopic2.Size = new System.Drawing.Size(35, 13);
      this.lblTopic2.TabIndex = 3;
      this.lblTopic2.Text = "label2";
      // 
      // lblTopic1
      // 
      this.lblTopic1.AutoSize = true;
      this.lblTopic1.Location = new System.Drawing.Point(3, 30);
      this.lblTopic1.Name = "lblTopic1";
      this.lblTopic1.Size = new System.Drawing.Size(35, 13);
      this.lblTopic1.TabIndex = 2;
      this.lblTopic1.Text = "label1";
      // 
      // lblMessageInfo
      // 
      this.lblMessageInfo.AutoSize = true;
      this.lblMessageInfo.Location = new System.Drawing.Point(3, 8);
      this.lblMessageInfo.Name = "lblMessageInfo";
      this.lblMessageInfo.Size = new System.Drawing.Size(71, 13);
      this.lblMessageInfo.TabIndex = 1;
      this.lblMessageInfo.Text = "Message Info";
      // 
      // btnPublish
      // 
      this.btnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPublish.Location = new System.Drawing.Point(380, 3);
      this.btnPublish.Name = "btnPublish";
      this.btnPublish.Size = new System.Drawing.Size(91, 23);
      this.btnPublish.TabIndex = 0;
      this.btnPublish.Text = "Publish";
      this.btnPublish.UseVisualStyleBackColor = true;
      this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
      // 
      // frmFeature
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(482, 461);
      this.Controls.Add(this.txtLog);
      this.Controls.Add(this.pnlTop);
      this.Name = "frmFeature";
      this.Padding = new System.Windows.Forms.Padding(4);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFeature_FormClosing);
      this.pnlTop.ResumeLayout(false);
      this.pnlTop.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Button btnPublish;
    private System.Windows.Forms.Label lblMessageInfo;
    private System.Windows.Forms.Label lblTopic3;
    private System.Windows.Forms.Label lblTopic2;
    private System.Windows.Forms.Label lblTopic1;
    private System.Windows.Forms.Button btnResubscribe;
  }
}

