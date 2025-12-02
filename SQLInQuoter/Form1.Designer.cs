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
            this.checkBoxOneLineOutput = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxAddSQLIn = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 70);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(235, 620);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(313, 70);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(235, 620);
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
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
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
            // checkBoxOneLineOutput
            // 
            this.checkBoxOneLineOutput.AllowDrop = true;
            this.checkBoxOneLineOutput.AutoSize = true;
            this.checkBoxOneLineOutput.Location = new System.Drawing.Point(6, 19);
            this.checkBoxOneLineOutput.Name = "checkBoxOneLineOutput";
            this.checkBoxOneLineOutput.Size = new System.Drawing.Size(113, 17);
            this.checkBoxOneLineOutput.TabIndex = 7;
            this.checkBoxOneLineOutput.Text = "Output on one line";
            this.checkBoxOneLineOutput.UseMnemonic = false;
            this.checkBoxOneLineOutput.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxAddSQLIn);
            this.groupBoxOptions.Controls.Add(this.checkBoxOneLineOutput);
            this.groupBoxOptions.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(535, 51);
            this.groupBoxOptions.TabIndex = 8;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // checkBoxAddSQLIn
            // 
            this.checkBoxAddSQLIn.AllowDrop = true;
            this.checkBoxAddSQLIn.AutoSize = true;
            this.checkBoxAddSQLIn.Location = new System.Drawing.Point(125, 19);
            this.checkBoxAddSQLIn.Name = "checkBoxAddSQLIn";
            this.checkBoxAddSQLIn.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAddSQLIn.TabIndex = 8;
            this.checkBoxAddSQLIn.Text = "Add SQL IN ()";
            this.checkBoxAddSQLIn.UseMnemonic = false;
            this.checkBoxAddSQLIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 738);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonClearInput);
            this.Controls.Add(this.buttonClearOutput);
            this.Controls.Add(this.buttonCopyOutput);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "SQLInQuoter";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxOneLineOutput;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxAddSQLIn;
    }
}

