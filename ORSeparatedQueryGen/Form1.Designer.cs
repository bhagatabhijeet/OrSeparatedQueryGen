namespace OrSeparatedQueryGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brnGenerate = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnCpy = new System.Windows.Forms.Button();
            this.btnClearSrc = new System.Windows.Forms.Button();
            this.btnDestClear = new System.Windows.Forms.Button();
            this.btnGenerateList = new System.Windows.Forms.Button();
            this.btnCpySrc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(34, 52);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(282, 574);
            this.txtSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.MaximumSize = new System.Drawing.Size(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter / Paste the ALM Test IDs Copied from SpreadSheet ( Please Enter 1 ID Per Li" +
    "ne)";
            // 
            // brnGenerate
            // 
            this.brnGenerate.Location = new System.Drawing.Point(333, 252);
            this.brnGenerate.Name = "brnGenerate";
            this.brnGenerate.Size = new System.Drawing.Size(75, 51);
            this.brnGenerate.TabIndex = 2;
            this.brnGenerate.Text = "Generate \'Or\' Query >>";
            this.brnGenerate.UseVisualStyleBackColor = true;
            this.brnGenerate.Click += new System.EventHandler(this.brnGenerate_Click);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(426, 52);
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDest.Size = new System.Drawing.Size(583, 574);
            this.txtDest.TabIndex = 3;
            // 
            // btnCpy
            // 
            this.btnCpy.Location = new System.Drawing.Point(657, 632);
            this.btnCpy.Name = "btnCpy";
            this.btnCpy.Size = new System.Drawing.Size(90, 40);
            this.btnCpy.TabIndex = 4;
            this.btnCpy.Text = "Copy To Clipboard";
            this.btnCpy.UseVisualStyleBackColor = true;
            this.btnCpy.Click += new System.EventHandler(this.btnCpy_Click);
            // 
            // btnClearSrc
            // 
            this.btnClearSrc.Location = new System.Drawing.Point(57, 632);
            this.btnClearSrc.Name = "btnClearSrc";
            this.btnClearSrc.Size = new System.Drawing.Size(84, 40);
            this.btnClearSrc.TabIndex = 5;
            this.btnClearSrc.Text = "Clear";
            this.btnClearSrc.UseVisualStyleBackColor = true;
            this.btnClearSrc.Click += new System.EventHandler(this.btnClearSrc_Click);
            // 
            // btnDestClear
            // 
            this.btnDestClear.Location = new System.Drawing.Point(551, 632);
            this.btnDestClear.Name = "btnDestClear";
            this.btnDestClear.Size = new System.Drawing.Size(84, 40);
            this.btnDestClear.TabIndex = 6;
            this.btnDestClear.Text = "Clear";
            this.btnDestClear.UseVisualStyleBackColor = true;
            this.btnDestClear.Click += new System.EventHandler(this.btnDestClear_Click);
            // 
            // btnGenerateList
            // 
            this.btnGenerateList.Location = new System.Drawing.Point(333, 321);
            this.btnGenerateList.Name = "btnGenerateList";
            this.btnGenerateList.Size = new System.Drawing.Size(75, 51);
            this.btnGenerateList.TabIndex = 7;
            this.btnGenerateList.Text = "<< Generate List";
            this.btnGenerateList.UseVisualStyleBackColor = true;
            this.btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);
            // 
            // btnCpySrc
            // 
            this.btnCpySrc.Location = new System.Drawing.Point(163, 632);
            this.btnCpySrc.Name = "btnCpySrc";
            this.btnCpySrc.Size = new System.Drawing.Size(90, 40);
            this.btnCpySrc.TabIndex = 8;
            this.btnCpySrc.Text = "Copy To Clipboard";
            this.btnCpySrc.UseVisualStyleBackColor = true;
            this.btnCpySrc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.MaximumSize = new System.Drawing.Size(265, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter / Paste the  ALM IDs \'OR\' Separated.";
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(333, 175);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(75, 62);
            this.btnCSV.TabIndex = 10;
            this.btnCSV.Text = "Generate  Comma Separated  >>";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 684);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCpySrc);
            this.Controls.Add(this.btnGenerateList);
            this.Controls.Add(this.btnDestClear);
            this.Controls.Add(this.btnClearSrc);
            this.Controls.Add(this.btnCpy);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.brnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "OR Separated Query Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnGenerate;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnCpy;
        private System.Windows.Forms.Button btnClearSrc;
        private System.Windows.Forms.Button btnDestClear;
        private System.Windows.Forms.Button btnGenerateList;
        private System.Windows.Forms.Button btnCpySrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCSV;
    }
}

