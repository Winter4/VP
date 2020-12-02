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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // closeFormButton
            // 
            this.closeFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeFormButton.Location = new System.Drawing.Point(318, 23);
            this.closeFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(92, 34);
            this.closeFormButton.TabIndex = 0;
            this.closeFormButton.Text = "Close form";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // createMatrixButton
            // 
            this.createMatrixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createMatrixButton.Location = new System.Drawing.Point(318, 89);
            this.createMatrixButton.Margin = new System.Windows.Forms.Padding(2);
            this.createMatrixButton.Name = "createMatrixButton";
            this.createMatrixButton.Size = new System.Drawing.Size(92, 35);
            this.createMatrixButton.TabIndex = 1;
            this.createMatrixButton.Text = "New matrix";
            this.createMatrixButton.UseVisualStyleBackColor = true;
            this.createMatrixButton.Click += new System.EventHandler(this.createMatrixButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 291);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(385, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(338, 291);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Visible = false;
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pLabel.Location = new System.Drawing.Point(57, 152);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(85, 24);
            this.pLabel.TabIndex = 4;
            this.pLabel.Text = "LABEL P";
            this.pLabel.Visible = false;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLabel.Location = new System.Drawing.Point(427, 79);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(86, 24);
            this.aLabel.TabIndex = 5;
            this.aLabel.Text = "LABEL A";
            this.aLabel.Visible = false;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLabel.Location = new System.Drawing.Point(427, 115);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(85, 24);
            this.bLabel.TabIndex = 6;
            this.bLabel.Text = "LABEL B";
            this.bLabel.Visible = false;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cLabel.Location = new System.Drawing.Point(427, 152);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(86, 24);
            this.cLabel.TabIndex = 7;
            this.cLabel.Text = "LABEL C";
            this.cLabel.Visible = false;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minLabel.Location = new System.Drawing.Point(427, 27);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(107, 24);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "LABEL MIN";
            this.minLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 607);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.createMatrixButton);
            this.Controls.Add(this.closeFormButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Karpovich V. D. Lab 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Button createMatrixButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label minLabel;
    }
}

