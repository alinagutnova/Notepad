namespace Notepad
{
    partial class FormSettings
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
            labelFontSize = new Label();
            numericUpDownFontSize = new NumericUpDown();
            labelSign = new Label();
            textBoxSign = new TextBox();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).BeginInit();
            SuspendLayout();
            // 
            // labelFontSize
            // 
            labelFontSize.AutoSize = true;
            labelFontSize.Location = new Point(32, 35);
            labelFontSize.Name = "labelFontSize";
            labelFontSize.Size = new Size(95, 15);
            labelFontSize.TabIndex = 0;
            labelFontSize.Text = "Размер шрифта";
            // 
            // numericUpDownFontSize
            // 
            numericUpDownFontSize.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownFontSize.Location = new Point(145, 33);
            numericUpDownFontSize.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            numericUpDownFontSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownFontSize.Name = "numericUpDownFontSize";
            numericUpDownFontSize.Size = new Size(62, 23);
            numericUpDownFontSize.TabIndex = 1;
            numericUpDownFontSize.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // labelSign
            // 
            labelSign.AutoSize = true;
            labelSign.Location = new Point(32, 93);
            labelSign.Name = "labelSign";
            labelSign.Size = new Size(55, 15);
            labelSign.TabIndex = 2;
            labelSign.Text = "Подпись";
            // 
            // textBoxSign
            // 
            textBoxSign.Location = new Point(107, 88);
            textBoxSign.Multiline = true;
            textBoxSign.Name = "textBoxSign";
            textBoxSign.Size = new Size(205, 56);
            textBoxSign.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(114, 179);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(93, 31);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 222);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSign);
            Controls.Add(labelSign);
            Controls.Add(numericUpDownFontSize);
            Controls.Add(labelFontSize);
            Name = "FormSettings";
            Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFontSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFontSize;
        private NumericUpDown numericUpDownFontSize;
        private Label labelSign;
        private TextBox textBoxSign;
        private Button buttonSave;
    }
}