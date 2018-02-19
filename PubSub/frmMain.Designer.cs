namespace PubSub
{
  partial class frmMain
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
      this.btnSpawn = new System.Windows.Forms.Button();
      this.btnUrgent = new System.Windows.Forms.Button();
      this.pnlTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtLog
      // 
      this.txtLog.BackColor = System.Drawing.Color.Black;
      this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtLog.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtLog.ForeColor = System.Drawing.Color.Lime;
      this.txtLog.Location = new System.Drawing.Point(0, 56);
      this.txtLog.Multiline = true;
      this.txtLog.Name = "txtLog";
      this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtLog.Size = new System.Drawing.Size(484, 205);
      this.txtLog.TabIndex = 2;
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.btnUrgent);
      this.pnlTop.Controls.Add(this.btnSpawn);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(484, 56);
      this.pnlTop.TabIndex = 3;
      // 
      // btnSpawn
      // 
      this.btnSpawn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSpawn.Location = new System.Drawing.Point(397, 12);
      this.btnSpawn.Name = "btnSpawn";
      this.btnSpawn.Size = new System.Drawing.Size(75, 23);
      this.btnSpawn.TabIndex = 0;
      this.btnSpawn.Text = "Spawn";
      this.btnSpawn.UseVisualStyleBackColor = true;
      this.btnSpawn.Click += new System.EventHandler(this.btnSpawn_Click);
      // 
      // btnUrgent
      // 
      this.btnUrgent.Location = new System.Drawing.Point(12, 12);
      this.btnUrgent.Name = "btnUrgent";
      this.btnUrgent.Size = new System.Drawing.Size(75, 23);
      this.btnUrgent.TabIndex = 1;
      this.btnUrgent.Text = "URGENT";
      this.btnUrgent.UseVisualStyleBackColor = true;
      this.btnUrgent.Click += new System.EventHandler(this.btnUrgent_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 261);
      this.Controls.Add(this.txtLog);
      this.Controls.Add(this.pnlTop);
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main Form";
      this.pnlTop.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Button btnSpawn;
    private System.Windows.Forms.Button btnUrgent;
  }
}