namespace EncoderForms
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxEncodingAlgorithm = new System.Windows.Forms.ComboBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.button4buttonDecode = new System.Windows.Forms.Button();
            this.checkBoxCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Введите строку";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(20, 220);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(255, 80);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Кодированая строка";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(312, 21);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(374, 45);
            this.textBoxInput.TabIndex = 3;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 319);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(674, 30);
            this.textBoxOutput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Загрузить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 20F);
            this.button2.Location = new System.Drawing.Point(12, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить файл";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxEncodingAlgorithm
            // 
            this.comboBoxEncodingAlgorithm.Font = new System.Drawing.Font("Consolas", 20F);
            this.comboBoxEncodingAlgorithm.FormattingEnabled = true;
            this.comboBoxEncodingAlgorithm.Location = new System.Drawing.Point(562, 160);
            this.comboBoxEncodingAlgorithm.Name = "comboBoxEncodingAlgorithm";
            this.comboBoxEncodingAlgorithm.Size = new System.Drawing.Size(134, 40);
            this.comboBoxEncodingAlgorithm.TabIndex = 7;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(422, 206);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(172, 32);
            this.buttonEncode.TabIndex = 8;
            this.buttonEncode.Text = "Кодировать";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // button4buttonDecode
            // 
            this.button4buttonDecode.Location = new System.Drawing.Point(519, 265);
            this.button4buttonDecode.Name = "button4buttonDecode";
            this.button4buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.button4buttonDecode.TabIndex = 9;
            this.button4buttonDecode.Text = "Декодировать";
            this.button4buttonDecode.UseVisualStyleBackColor = true;
            this.button4buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // checkBoxCopyToClipboard
            // 
            this.checkBoxCopyToClipboard.AutoSize = true;
            this.checkBoxCopyToClipboard.Location = new System.Drawing.Point(487, 138);
            this.checkBoxCopyToClipboard.Name = "checkBoxCopyToClipboard";
            this.checkBoxCopyToClipboard.Size = new System.Drawing.Size(163, 17);
            this.checkBoxCopyToClipboard.TabIndex = 10;
            this.checkBoxCopyToClipboard.Text = "Сохранить в буфер обмена";
            this.checkBoxCopyToClipboard.UseVisualStyleBackColor = true;
            this.checkBoxCopyToClipboard.CheckedChanged += new System.EventHandler(this.checkBoxCopyToClipboard_CheckedChanged_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 376);
            this.Controls.Add(this.checkBoxCopyToClipboard);
            this.Controls.Add(this.button4buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.comboBoxEncodingAlgorithm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "Encoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxEncodingAlgorithm;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button button4buttonDecode;
        private System.Windows.Forms.CheckBox checkBoxCopyToClipboard;
    }
}

