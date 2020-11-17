namespace VP_2
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
            this.closeFormButton = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.addTextButton = new System.Windows.Forms.Button();
            this.deleteSelectedTextButton = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.colorChooseList = new System.Windows.Forms.ComboBox();
            this.changeRadioButton = new System.Windows.Forms.RadioButton();
            this.notchangeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeFormButton
            // 
            this.closeFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeFormButton.Location = new System.Drawing.Point(317, 51);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(134, 40);
            this.closeFormButton.TabIndex = 0;
            this.closeFormButton.Text = "Close form";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdd.Location = new System.Drawing.Point(105, 191);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(261, 30);
            this.textBoxAdd.TabIndex = 1;
            // 
            // addTextButton
            // 
            this.addTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTextButton.Location = new System.Drawing.Point(179, 132);
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.Size = new System.Drawing.Size(121, 53);
            this.addTextButton.TabIndex = 2;
            this.addTextButton.Text = "Add text";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // deleteSelectedTextButton
            // 
            this.deleteSelectedTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSelectedTextButton.Location = new System.Drawing.Point(458, 132);
            this.deleteSelectedTextButton.Name = "deleteSelectedTextButton";
            this.deleteSelectedTextButton.Size = new System.Drawing.Size(160, 53);
            this.deleteSelectedTextButton.TabIndex = 3;
            this.deleteSelectedTextButton.Text = "Delete selected text";
            this.deleteSelectedTextButton.UseVisualStyleBackColor = true;
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelete.Location = new System.Drawing.Point(410, 191);
            this.textBoxDelete.Multiline = true;
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(261, 57);
            this.textBoxDelete.TabIndex = 4;
            // 
            // colorChooseList
            // 
            this.colorChooseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colorChooseList.FormattingEnabled = true;
            this.colorChooseList.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colorChooseList.Location = new System.Drawing.Point(179, 243);
            this.colorChooseList.Name = "colorChooseList";
            this.colorChooseList.Size = new System.Drawing.Size(121, 23);
            this.colorChooseList.TabIndex = 5;
            this.colorChooseList.SelectedIndexChanged += new System.EventHandler(this.colorChooseList_SelectedIndexChanged);
            // 
            // changeRadioButton
            // 
            this.changeRadioButton.AutoSize = true;
            this.changeRadioButton.Checked = true;
            this.changeRadioButton.Location = new System.Drawing.Point(27, 21);
            this.changeRadioButton.Name = "changeRadioButton";
            this.changeRadioButton.Size = new System.Drawing.Size(53, 21);
            this.changeRadioButton.TabIndex = 6;
            this.changeRadioButton.TabStop = true;
            this.changeRadioButton.Text = "Yes";
            this.changeRadioButton.UseVisualStyleBackColor = true;
            this.changeRadioButton.Click += new System.EventHandler(this.changeRadioButton_Click);
            // 
            // notchangeRadioButton
            // 
            this.notchangeRadioButton.AutoSize = true;
            this.notchangeRadioButton.Location = new System.Drawing.Point(27, 48);
            this.notchangeRadioButton.Name = "notchangeRadioButton";
            this.notchangeRadioButton.Size = new System.Drawing.Size(47, 21);
            this.notchangeRadioButton.TabIndex = 7;
            this.notchangeRadioButton.Text = "No";
            this.notchangeRadioButton.UseVisualStyleBackColor = true;
            this.notchangeRadioButton.Click += new System.EventHandler(this.notchangeRadioButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeRadioButton);
            this.groupBox1.Controls.Add(this.notchangeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(134, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change TextBoxes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.colorChooseList);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.deleteSelectedTextButton);
            this.Controls.Add(this.addTextButton);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.closeFormButton);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "K.V. Lab 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.Button deleteSelectedTextButton;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.ComboBox colorChooseList;
        private System.Windows.Forms.RadioButton changeRadioButton;
        private System.Windows.Forms.RadioButton notchangeRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

