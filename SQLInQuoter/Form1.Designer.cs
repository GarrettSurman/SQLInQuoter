namespace SQLInQuoter
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonCopyOutput = new System.Windows.Forms.Button();
            this.buttonClearOutput = new System.Windows.Forms.Button();
            this.buttonClearInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 52);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(235, 638);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(313, 52);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(235, 638);
            this.textBoxOutput.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(253, 365);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(54, 24);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = ">>>";
            this.buttonConvert.UseVisualStyleBackColor = true;
            // 
            // buttonCopyOutput
            // 
            this.buttonCopyOutput.Location = new System.Drawing.Point(394, 696);
            this.buttonCopyOutput.Name = "buttonCopyOutput";
            this.buttonCopyOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyOutput.TabIndex = 4;
            this.buttonCopyOutput.Text = "Copy Text";
            this.buttonCopyOutput.UseVisualStyleBackColor = true;
            this.buttonCopyOutput.Click += new System.EventHandler(this.buttonCopyOutput_Click);
            // 
            // buttonClearOutput
            // 
            this.buttonClearOutput.Location = new System.Drawing.Point(313, 696);
            this.buttonClearOutput.Name = "buttonClearOutput";
            this.buttonClearOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonClearOutput.TabIndex = 5;
            this.buttonClearOutput.Text = "Clear";
            this.buttonClearOutput.UseVisualStyleBackColor = true;
            this.buttonClearOutput.Click += new System.EventHandler(this.buttonClearOutput_Click);
            // 
            // buttonClearInput
            // 
            this.buttonClearInput.Location = new System.Drawing.Point(12, 696);
            this.buttonClearInput.Name = "buttonClearInput";
            this.buttonClearInput.Size = new System.Drawing.Size(75, 23);
            this.buttonClearInput.TabIndex = 6;
            this.buttonClearInput.Text = "Clear";
            this.buttonClearInput.UseVisualStyleBackColor = true;
            this.buttonClearInput.Click += new System.EventHandler(this.buttonClearInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 738);
            this.Controls.Add(this.buttonClearInput);
            this.Controls.Add(this.buttonClearOutput);
            this.Controls.Add(this.buttonCopyOutput);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "SQLInQuoter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonCopyOutput;
        private System.Windows.Forms.Button buttonClearOutput;
        private System.Windows.Forms.Button buttonClearInput;
    }
}

