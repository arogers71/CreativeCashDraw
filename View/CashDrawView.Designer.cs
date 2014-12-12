namespace CreativeCashDraw.View
{
    partial class CashDrawView
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
            this.txtCashFile = new System.Windows.Forms.TextBox();
            this.lblCashFile = new System.Windows.Forms.Label();
            this.cmdOpenCashFile = new System.Windows.Forms.Button();
            this.ofdCashFile = new System.Windows.Forms.OpenFileDialog();
            this.cmdStartProcess = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCashFile
            // 
            this.txtCashFile.Location = new System.Drawing.Point(67, 5);
            this.txtCashFile.Name = "txtCashFile";
            this.txtCashFile.Size = new System.Drawing.Size(354, 20);
            this.txtCashFile.TabIndex = 0;
            this.txtCashFile.TextChanged += new System.EventHandler(this.txtCashFile_TextChanged);
            // 
            // lblCashFile
            // 
            this.lblCashFile.AutoSize = true;
            this.lblCashFile.Location = new System.Drawing.Point(8, 8);
            this.lblCashFile.Name = "lblCashFile";
            this.lblCashFile.Size = new System.Drawing.Size(53, 13);
            this.lblCashFile.TabIndex = 1;
            this.lblCashFile.Text = "Cash File:";
            // 
            // cmdOpenCashFile
            // 
            this.cmdOpenCashFile.Location = new System.Drawing.Point(427, 3);
            this.cmdOpenCashFile.Name = "cmdOpenCashFile";
            this.cmdOpenCashFile.Size = new System.Drawing.Size(33, 23);
            this.cmdOpenCashFile.TabIndex = 2;
            this.cmdOpenCashFile.Text = "...";
            this.cmdOpenCashFile.UseVisualStyleBackColor = true;
            this.cmdOpenCashFile.Click += new System.EventHandler(this.cmdOpenCashFile_Click);
            // 
            // ofdCashFile
            // 
            this.ofdCashFile.DefaultExt = "*.*";
            // 
            // cmdStartProcess
            // 
            this.cmdStartProcess.Enabled = false;
            this.cmdStartProcess.Location = new System.Drawing.Point(385, 69);
            this.cmdStartProcess.Name = "cmdStartProcess";
            this.cmdStartProcess.Size = new System.Drawing.Size(75, 23);
            this.cmdStartProcess.TabIndex = 3;
            this.cmdStartProcess.Text = "Start";
            this.cmdStartProcess.UseVisualStyleBackColor = true;
            this.cmdStartProcess.Click += new System.EventHandler(this.cmdStartProcess_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(8, 33);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(67, 30);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(354, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // CashDrawView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 104);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmdStartProcess);
            this.Controls.Add(this.cmdOpenCashFile);
            this.Controls.Add(this.lblCashFile);
            this.Controls.Add(this.txtCashFile);
            this.Name = "CashDrawView";
            this.Text = "CashDrawView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCashFile;
        private System.Windows.Forms.Label lblCashFile;
        private System.Windows.Forms.Button cmdOpenCashFile;
        private System.Windows.Forms.OpenFileDialog ofdCashFile;
        private System.Windows.Forms.Button cmdStartProcess;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}