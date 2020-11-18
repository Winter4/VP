namespace VP_3
{
    partial class Main
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
            this.createMatrixButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeFormButton
            // 
            this.closeFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeFormButton.Location = new System.Drawing.Point(329, 33);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(122, 42);
            this.closeFormButton.TabIndex = 0;
            this.closeFormButton.Text = "Close form";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // createMatrixButton
            // 
            this.createMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createMatrixButton.Location = new System.Drawing.Point(329, 112);
            this.createMatrixButton.Name = "createMatrixButton";
            this.createMatrixButton.Size = new System.Drawing.Size(122, 43);
            this.createMatrixButton.TabIndex = 1;
            this.createMatrixButton.Text = "New matrix";
            this.createMatrixButton.UseVisualStyleBackColor = true;
            this.createMatrixButton.Click += new System.EventHandler(this.createMatrixButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createMatrixButton);
            this.Controls.Add(this.closeFormButton);
            this.Name = "Main";
            this.Text = "Karpovich V. D. Lab 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Button createMatrixButton;
    }
}

