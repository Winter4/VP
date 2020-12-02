namespace VP_3
{
    partial class CreateNewMatrixForm
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
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.colsTextBox = new System.Windows.Forms.TextBox();
            this.randLeftBorderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randRightBorderTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsTextBox.Location = new System.Drawing.Point(179, 31);
            this.rowsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(76, 26);
            this.rowsTextBox.TabIndex = 0;
            this.rowsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowsTextBox_KeyPress);
            // 
            // colsTextBox
            // 
            this.colsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colsTextBox.Location = new System.Drawing.Point(179, 63);
            this.colsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.colsTextBox.Name = "colsTextBox";
            this.colsTextBox.Size = new System.Drawing.Size(76, 26);
            this.colsTextBox.TabIndex = 1;
            this.colsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colsTextBox_KeyPress);
            // 
            // randLeftBorderTextBox
            // 
            this.randLeftBorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randLeftBorderTextBox.Location = new System.Drawing.Point(179, 100);
            this.randLeftBorderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.randLeftBorderTextBox.Name = "randLeftBorderTextBox";
            this.randLeftBorderTextBox.Size = new System.Drawing.Size(30, 26);
            this.randLeftBorderTextBox.TabIndex = 2;
            this.randLeftBorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.randLeftBorderTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "N (Rows)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "M (Cols)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Random from - to";
            // 
            // randRightBorderTextBox
            // 
            this.randRightBorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randRightBorderTextBox.Location = new System.Drawing.Point(224, 100);
            this.randRightBorderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.randRightBorderTextBox.Name = "randRightBorderTextBox";
            this.randRightBorderTextBox.Size = new System.Drawing.Size(31, 26);
            this.randRightBorderTextBox.TabIndex = 6;
            this.randRightBorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.randRightBorderTextBox_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(78, 136);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 27);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(179, 136);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 27);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 173);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.randRightBorderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randLeftBorderTextBox);
            this.Controls.Add(this.colsTextBox);
            this.Controls.Add(this.rowsTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateNewMatrixForm";
            this.Text = "New matrix";
            this.Load += new System.EventHandler(this.createNewMatrixForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.TextBox colsTextBox;
        private System.Windows.Forms.TextBox randLeftBorderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox randRightBorderTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}