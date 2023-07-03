namespace BMI_Calculator
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
            this.lblheight = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblindicator = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtbmi = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtindicat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheight
            // 
            this.lblheight.Location = new System.Drawing.Point(86, 97);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(52, 23);
            this.lblheight.TabIndex = 0;
            this.lblheight.Text = "Height";
            // 
            // lblweight
            // 
            this.lblweight.Location = new System.Drawing.Point(86, 148);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(52, 23);
            this.lblweight.TabIndex = 1;
            this.lblweight.Tag = "";
            this.lblweight.Text = "Weight";
            // 
            // lblbmi
            // 
            this.lblbmi.Location = new System.Drawing.Point(86, 192);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(52, 23);
            this.lblbmi.TabIndex = 1;
            this.lblbmi.Tag = "";
            this.lblbmi.Text = "BMI";
            // 
            // lblstatus
            // 
            this.lblstatus.Location = new System.Drawing.Point(321, 97);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(52, 23);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "Status";
            // 
            // lblindicator
            // 
            this.lblindicator.Location = new System.Drawing.Point(318, 148);
            this.lblindicator.Name = "lblindicator";
            this.lblindicator.Size = new System.Drawing.Size(69, 23);
            this.lblindicator.TabIndex = 0;
            this.lblindicator.Text = "Indicator";
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(144, 94);
            this.txtheight.Multiline = true;
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(157, 26);
            this.txtheight.TabIndex = 2;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(144, 145);
            this.txtweight.Multiline = true;
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(157, 26);
            this.txtweight.TabIndex = 2;
            // 
            // txtbmi
            // 
            this.txtbmi.Location = new System.Drawing.Point(144, 189);
            this.txtbmi.Multiline = true;
            this.txtbmi.Name = "txtbmi";
            this.txtbmi.ReadOnly = true;
            this.txtbmi.Size = new System.Drawing.Size(157, 26);
            this.txtbmi.TabIndex = 2;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(379, 94);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(157, 26);
            this.txtstatus.TabIndex = 2;
            // 
            // txtindicat
            // 
            this.txtindicat.Location = new System.Drawing.Point(379, 145);
            this.txtindicat.Multiline = true;
            this.txtindicat.Name = "txtindicat";
            this.txtindicat.ReadOnly = true;
            this.txtindicat.Size = new System.Drawing.Size(157, 26);
            this.txtindicat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(171, 245);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(92, 32);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 349);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtbmi);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtindicat);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lblindicator);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblheight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblindicator;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtbmi;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtindicat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculate;
    }
}

