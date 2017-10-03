namespace TranslateGui
{
    partial class Main
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
            this.EnterTextLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterTextLabel
            // 
            this.EnterTextLabel.AutoSize = true;
            this.EnterTextLabel.Location = new System.Drawing.Point(25, 23);
            this.EnterTextLabel.Name = "EnterTextLabel";
            this.EnterTextLabel.Size = new System.Drawing.Size(52, 13);
            this.EnterTextLabel.TabIndex = 0;
            this.EnterTextLabel.Text = "Enter text";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(790, 176);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "af",
            "ar",
            "bs-Latn",
            "bg",
            "ca",
            "zh-CHS",
            "zh-CHT",
            "hr",
            "cs",
            "da",
            "nl",
            "en",
            "et",
            "fi",
            "fr",
            "de",
            "el",
            "ht",
            "he",
            "hi",
            "mww",
            "hu",
            "id",
            "it",
            "ja",
            "sw",
            "tlh",
            "tlh-Qaak",
            "ko",
            "lv",
            "lt",
            "ms",
            "mt",
            "no",
            "fa",
            "pl",
            "pt",
            "otq",
            "ro",
            "ru",
            "sr-Cyrl",
            "sr-Latn",
            "sk",
            "sl",
            "es",
            "sv",
            "th",
            "tr",
            "uk",
            "ur",
            "vi",
            "cy",
            "yua"});
            this.comboBox1.Location = new System.Drawing.Point(169, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(25, 274);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(122, 13);
            this.LanguageLabel.TabIndex = 3;
            this.LanguageLabel.Text = "Language to translate to";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 325);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(790, 236);
            this.textBox2.TabIndex = 4;
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(37, 592);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(123, 23);
            this.Translate.TabIndex = 5;
            this.Translate.Text = "Microsoft Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Google Translate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EnterTextLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterTextLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button button1;
    }
}