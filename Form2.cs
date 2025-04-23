using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tennis_2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }
        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            string firstPlayerName = textBox1.Text.Trim();
            int firstPlayerPoints = (int)numericUpDown1.Value;

            string secondPlayerName = textBox2.Text.Trim();
            int secondPlayerPoints = (int)numericUpDown2.Value;

            if (!CheckIfInputsAreValid())
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;

            }


        }

        private bool CheckIfInputsAreValid()
           => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private bool CheckIfPlayerNamesAreSame()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);
        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }
        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if (textBox == this.textBox1)
            {
                this.errorProvider1.SetError(textBox, errorText);
                this.Error.Text = "First " + errorText;
            }
            else if (textBox == this.textBox2)
            {
                this.errorProvider2.SetError(textBox, errorText);
                this.labelError.Text = "Second " + errorText;
            }
        }
        private void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == this.textBox1)
            {
                this.errorProvider1.SetError(textBox, "");
                this.Error.Text = string.Empty;
            }
            else if (textBox == this.textBox2)
            {
                this.errorProvider2.SetError(textBox, "");
                this.labelError.Text = string.Empty;
            }
        }
        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.Error.Text = "First Player name should not be same as Second Player name!";
            }
            else
            {
                this.labelError.Text = string.Empty;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Error_Click(object sender, EventArgs e)
        {

        }
    }
}
