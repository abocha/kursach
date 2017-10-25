namespace KMP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonResult = new System.Windows.Forms.Button();
            this.inpPattern = new System.Windows.Forms.TextBox();
            this.inpText = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.genError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genSubstrLength = new System.Windows.Forms.NumericUpDown();
            this.genLength = new System.Windows.Forms.NumericUpDown();
            this.genSearchType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genSubstrLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genLength)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(32, 17);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "See result";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // inpPattern
            // 
            this.inpPattern.Location = new System.Drawing.Point(6, 19);
            this.inpPattern.Name = "inpPattern";
            this.inpPattern.Size = new System.Drawing.Size(100, 20);
            this.inpPattern.TabIndex = 2;
            this.inpPattern.TextChanged += new System.EventHandler(this.inpPattern_TextChanged);
            // 
            // inpText
            // 
            this.inpText.Location = new System.Drawing.Point(6, 19);
            this.inpText.Name = "inpText";
            this.inpText.Size = new System.Drawing.Size(449, 20);
            this.inpText.TabIndex = 3;
            this.inpText.TextChanged += new System.EventHandler(this.inpText_TextChanged);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(113, 19);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(603, 119);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inpPattern);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Substring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inpText);
            this.groupBox2.Location = new System.Drawing.Point(128, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "String";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonResult);
            this.groupBox3.Controls.Add(this.output);
            this.groupBox3.Location = new System.Drawing.Point(15, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 54);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(282, 58);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.genError);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.genSubstrLength);
            this.groupBox4.Controls.Add(this.genLength);
            this.groupBox4.Controls.Add(this.genSearchType);
            this.groupBox4.Controls.Add(this.buttonGenerate);
            this.groupBox4.Location = new System.Drawing.Point(12, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sequence Generation";
            // 
            // genError
            // 
            this.genError.AutoSize = true;
            this.genError.Location = new System.Drawing.Point(379, 67);
            this.genError.Name = "genError";
            this.genError.Size = new System.Drawing.Size(0, 13);
            this.genError.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sequence Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Substring Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "String Length";
            // 
            // genSubstrLength
            // 
            this.genSubstrLength.Location = new System.Drawing.Point(129, 58);
            this.genSubstrLength.Name = "genSubstrLength";
            this.genSubstrLength.Size = new System.Drawing.Size(120, 20);
            this.genSubstrLength.TabIndex = 16;
            this.genSubstrLength.ValueChanged += new System.EventHandler(this.genSubstrLength_ValueChanged);
            // 
            // genLength
            // 
            this.genLength.Location = new System.Drawing.Point(129, 28);
            this.genLength.Name = "genLength";
            this.genLength.Size = new System.Drawing.Size(120, 20);
            this.genLength.TabIndex = 15;
            this.genLength.ValueChanged += new System.EventHandler(this.genLength_ValueChanged);
            // 
            // genSearchType
            // 
            this.genSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genSearchType.FormattingEnabled = true;
            this.genSearchType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genSearchType.Items.AddRange(new object[] {
            "Alphanumeric",
            "Numeric",
            "A, B, C"});
            this.genSearchType.SelectedIndex = 2;
            this.genSearchType.Location = new System.Drawing.Point(379, 27);
            this.genSearchType.Name = "genSearchType";
            this.genSearchType.Size = new System.Drawing.Size(121, 21);
            this.genSearchType.TabIndex = 13;
            this.genSearchType.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 259);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "KMP";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genSubstrLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox inpPattern;
        private System.Windows.Forms.TextBox inpText;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox genSearchType;
        private System.Windows.Forms.NumericUpDown genLength;
        private System.Windows.Forms.NumericUpDown genSubstrLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label genError;
    }
}

