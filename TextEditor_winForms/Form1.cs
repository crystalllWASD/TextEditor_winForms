using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor_winForms
{
    public partial class Form1 : Form
    {
        Font saveFont;
        Color saveColor;

        public Form1()
        {
            InitializeComponent();
            statusText.Text = $"Колличество символов: 0";
            var fontsCollection = new InstalledFontCollection();
            var font = fontsCollection.Families;
            foreach (var f in font)
            {
                fontList.Items.Add(f.Name);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            open.FilterIndex = 2;
            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.WriteLine(richTextBox1.Text);
                writer.Close();
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionFont.Bold != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void underlinedButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            }
        }

        private void SizeTxtIncreaseButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font
                (richTextBox1.SelectionFont.FontFamily,
                richTextBox1.SelectionFont.Size + 1,
                richTextBox1.SelectionFont.Style);
        }

        private void SizeTxtDicreaseButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Size > 1)
            {
                richTextBox1.SelectionFont = new Font
                    (richTextBox1.SelectionFont.FontFamily,
                    richTextBox1.SelectionFont.Size - 1,
                    richTextBox1.SelectionFont.Style);
            }
        }

        private void alignTxtButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCentrButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void formPaintButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "" && formPaintButton.Checked == true)
            {
                saveFont = richTextBox1.SelectionFont;
                saveColor = richTextBox1.SelectionColor;
            }
        }

        private void colorFontButton_Click(object sender, EventArgs e)
        {
            var colorCollection = new ColorDialog();
            if(colorCollection.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorCollection.Color;
            }
        }

        private void fontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font
                ((string)fontList.SelectedItem,
                richTextBox1.SelectionFont.Size,
                richTextBox1.SelectionFont.Style);
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if(formPaintButton.Checked == true)
            {
                richTextBox1.SelectionFont = saveFont;
                richTextBox1.SelectionColor = saveColor;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            statusText.Text = $"Колличество символов: {richTextBox1.TextLength}";
        }
    }
}
