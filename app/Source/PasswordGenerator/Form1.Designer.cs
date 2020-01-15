namespace PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbSymbols = new System.Windows.Forms.CheckBox();
            this.ckbNums = new System.Windows.Forms.CheckBox();
            this.ckbLowercase = new System.Windows.Forms.CheckBox();
            this.ckbUppercase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.numLength);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 315);
            this.panel1.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnCopy.Image = global::PasswordGenerator.Properties.Resources.copyicon;
            this.btnCopy.Location = new System.Drawing.Point(306, 12);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(33, 33);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // numLength
            // 
            this.numLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLength.Location = new System.Drawing.Point(292, 59);
            this.numLength.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(47, 29);
            this.numLength.TabIndex = 5;
            this.numLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(22, 261);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(317, 40);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbSymbols);
            this.groupBox1.Controls.Add(this.ckbNums);
            this.groupBox1.Controls.Add(this.ckbLowercase);
            this.groupBox1.Controls.Add(this.ckbUppercase);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ckbSymbols
            // 
            this.ckbSymbols.AutoSize = true;
            this.ckbSymbols.Checked = true;
            this.ckbSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSymbols.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSymbols.Location = new System.Drawing.Point(6, 118);
            this.ckbSymbols.Name = "ckbSymbols";
            this.ckbSymbols.Size = new System.Drawing.Size(169, 29);
            this.ckbSymbols.TabIndex = 6;
            this.ckbSymbols.Text = "Include symbols";
            this.ckbSymbols.UseVisualStyleBackColor = true;
            // 
            // ckbNums
            // 
            this.ckbNums.AutoSize = true;
            this.ckbNums.Checked = true;
            this.ckbNums.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNums.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNums.Location = new System.Drawing.Point(6, 85);
            this.ckbNums.Name = "ckbNums";
            this.ckbNums.Size = new System.Drawing.Size(171, 29);
            this.ckbNums.TabIndex = 5;
            this.ckbNums.Text = "Include numbers";
            this.ckbNums.UseVisualStyleBackColor = true;
            // 
            // ckbLowercase
            // 
            this.ckbLowercase.AutoSize = true;
            this.ckbLowercase.Checked = true;
            this.ckbLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLowercase.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLowercase.Location = new System.Drawing.Point(6, 52);
            this.ckbLowercase.Name = "ckbLowercase";
            this.ckbLowercase.Size = new System.Drawing.Size(242, 29);
            this.ckbLowercase.TabIndex = 4;
            this.ckbLowercase.Text = "Include lowercase letters";
            this.ckbLowercase.UseVisualStyleBackColor = true;
            // 
            // ckbUppercase
            // 
            this.ckbUppercase.AutoSize = true;
            this.ckbUppercase.Checked = true;
            this.ckbUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUppercase.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUppercase.Location = new System.Drawing.Point(6, 19);
            this.ckbUppercase.Name = "ckbUppercase";
            this.ckbUppercase.Size = new System.Drawing.Size(245, 29);
            this.ckbUppercase.TabIndex = 3;
            this.ckbUppercase.Text = "Include uppercase letters";
            this.ckbUppercase.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password length";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(22, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(278, 33);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 339);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox ckbSymbols;
        private System.Windows.Forms.CheckBox ckbNums;
        private System.Windows.Forms.CheckBox ckbLowercase;
        private System.Windows.Forms.CheckBox ckbUppercase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Button btnCopy;
    }
}

