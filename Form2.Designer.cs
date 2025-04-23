namespace Project_Tennis_2._0
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            Error = new Label();
            labelError = new Label();
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 27);
            label1.Name = "label1";
            label1.Size = new Size(229, 54);
            label1.TabIndex = 0;
            label1.Text = "New Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(90, 104);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 1;
            label2.Text = "First PLayer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(519, 104);
            label3.Name = "label3";
            label3.Size = new Size(186, 36);
            label3.TabIndex = 2;
            label3.Text = "Second Player";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(131, 281);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 31);
            numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(585, 281);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(53, 31);
            numericUpDown2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 31);
            textBox1.TabIndex = 5;
            textBox1.Validating += ValidatePlayerName;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(519, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 31);
            textBox2.TabIndex = 6;
            textBox2.Validating += ValidatePlayerName;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(120, 229);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 7;
            label4.Text = "Score";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(574, 229);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 8;
            label5.Text = "Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(365, 203);
            label6.Name = "label6";
            label6.Size = new Size(72, 54);
            label6.TabIndex = 9;
            label6.Text = "VS";
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(348, 353);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.BackColor = Color.White;
            Error.Location = new Point(90, 203);
            Error.Name = "Error";
            Error.Size = new Size(0, 25);
            Error.TabIndex = 11;
            Error.Click += Error_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = Color.White;
            labelError.Location = new Point(519, 203);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 25);
            labelError.TabIndex = 12;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(820, 468);
            Controls.Add(labelError);
            Controls.Add(Error);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Label labelError;
        private Label Error;
        private ErrorProvider errorProvider2;
    }
}