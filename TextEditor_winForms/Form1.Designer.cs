namespace TextEditor_winForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.underlinedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SizeTxtIncreaseButton = new System.Windows.Forms.ToolStripButton();
            this.SizeTxtDicreaseButton = new System.Windows.Forms.ToolStripButton();
            this.fontList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.alignTxtButton = new System.Windows.Forms.ToolStripButton();
            this.alignCentrButton = new System.Windows.Forms.ToolStripButton();
            this.alignRightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.formPaintButton = new System.Windows.Forms.ToolStripButton();
            this.colorFontButton = new System.Windows.Forms.ToolStripButton();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(10, 55);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(780, 353);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton,
            this.saveButton,
            this.toolStripSeparator1,
            this.copyButton,
            this.cutButton,
            this.pasteButton,
            this.toolStripSeparator2,
            this.boldButton,
            this.italicButton,
            this.underlinedButton,
            this.toolStripSeparator3,
            this.SizeTxtIncreaseButton,
            this.SizeTxtDicreaseButton,
            this.fontList,
            this.toolStripSeparator4,
            this.alignTxtButton,
            this.alignCentrButton,
            this.alignRightButton,
            this.toolStripSeparator5,
            this.formPaintButton,
            this.colorFontButton});
            this.toolStrip1.Location = new System.Drawing.Point(5, 10);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__1_;
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(29, 27);
            this.openButton.Text = "Открыть";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__2_;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(29, 27);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__3_;
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(29, 27);
            this.copyButton.Text = "Копировать";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__4_;
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(29, 27);
            this.cutButton.Text = "Вырезать";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__5_;
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(29, 27);
            this.pasteButton.Text = "Вставить";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__8_;
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(29, 27);
            this.boldButton.Text = "Полужирный";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__6_;
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(29, 27);
            this.italicButton.Text = "Курсивный";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // underlinedButton
            // 
            this.underlinedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlinedButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__7_;
            this.underlinedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlinedButton.Name = "underlinedButton";
            this.underlinedButton.Size = new System.Drawing.Size(29, 27);
            this.underlinedButton.Text = "Подчеркнутый";
            this.underlinedButton.Click += new System.EventHandler(this.underlinedButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // SizeTxtIncreaseButton
            // 
            this.SizeTxtIncreaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SizeTxtIncreaseButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__10_;
            this.SizeTxtIncreaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SizeTxtIncreaseButton.Name = "SizeTxtIncreaseButton";
            this.SizeTxtIncreaseButton.Size = new System.Drawing.Size(29, 27);
            this.SizeTxtIncreaseButton.Text = "Увеличить шрифт";
            this.SizeTxtIncreaseButton.Click += new System.EventHandler(this.SizeTxtIncreaseButton_Click);
            // 
            // SizeTxtDicreaseButton
            // 
            this.SizeTxtDicreaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SizeTxtDicreaseButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__9_;
            this.SizeTxtDicreaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SizeTxtDicreaseButton.Name = "SizeTxtDicreaseButton";
            this.SizeTxtDicreaseButton.Size = new System.Drawing.Size(29, 27);
            this.SizeTxtDicreaseButton.Text = "Уменьшить текст";
            this.SizeTxtDicreaseButton.Click += new System.EventHandler(this.SizeTxtDicreaseButton_Click);
            // 
            // fontList
            // 
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(121, 30);
            this.fontList.SelectedIndexChanged += new System.EventHandler(this.fontList_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // alignTxtButton
            // 
            this.alignTxtButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignTxtButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__11_;
            this.alignTxtButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignTxtButton.Name = "alignTxtButton";
            this.alignTxtButton.Size = new System.Drawing.Size(29, 27);
            this.alignTxtButton.Text = "Выравнивание слева";
            this.alignTxtButton.Click += new System.EventHandler(this.alignTxtButton_Click);
            // 
            // alignCentrButton
            // 
            this.alignCentrButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignCentrButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__13_;
            this.alignCentrButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignCentrButton.Name = "alignCentrButton";
            this.alignCentrButton.Size = new System.Drawing.Size(29, 27);
            this.alignCentrButton.Text = "Выравнивание по центру";
            this.alignCentrButton.Click += new System.EventHandler(this.alignCentrButton_Click);
            // 
            // alignRightButton
            // 
            this.alignRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignRightButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__12_;
            this.alignRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignRightButton.Name = "alignRightButton";
            this.alignRightButton.Size = new System.Drawing.Size(29, 27);
            this.alignRightButton.Text = "Выравнивание справа";
            this.alignRightButton.Click += new System.EventHandler(this.alignRightButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // formPaintButton
            // 
            this.formPaintButton.CheckOnClick = true;
            this.formPaintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.formPaintButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__14_;
            this.formPaintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formPaintButton.Name = "formPaintButton";
            this.formPaintButton.Size = new System.Drawing.Size(29, 27);
            this.formPaintButton.Text = "Формат по образцу";
            this.formPaintButton.Click += new System.EventHandler(this.formPaintButton_Click);
            // 
            // colorFontButton
            // 
            this.colorFontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorFontButton.Image = global::TextEditor_winForms.Properties.Resources.MicrosoftTeams_image__15_;
            this.colorFontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorFontButton.Name = "colorFontButton";
            this.colorFontButton.Size = new System.Drawing.Size(29, 27);
            this.colorFontButton.Text = "Изменить цвет шрифта";
            this.colorFontButton.Click += new System.EventHandler(this.colorFontButton_Click);
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton underlinedButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SizeTxtIncreaseButton;
        private System.Windows.Forms.ToolStripButton SizeTxtDicreaseButton;
        private System.Windows.Forms.ToolStripComboBox fontList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton alignTxtButton;
        private System.Windows.Forms.ToolStripButton alignCentrButton;
        private System.Windows.Forms.ToolStripButton alignRightButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton formPaintButton;
        private System.Windows.Forms.ToolStripButton colorFontButton;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
    }
}

