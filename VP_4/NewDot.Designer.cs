namespace lab4
{
    partial class NewDot
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
            this.label1 = new System.Windows.Forms.Label();
            this.x_textbox = new System.Windows.Forms.TextBox();
            this.y_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.r2_textbox = new System.Windows.Forms.TextBox();
            this.r1_textbox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите X Y";
            // 
            // x_textbox
            // 
            this.x_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_textbox.Location = new System.Drawing.Point(131, 82);
            this.x_textbox.Name = "x_textbox";
            this.x_textbox.Size = new System.Drawing.Size(34, 29);
            this.x_textbox.TabIndex = 1;
            this.x_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_textbox_KeyPress);
            // 
            // y_textbox
            // 
            this.y_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y_textbox.Location = new System.Drawing.Point(189, 82);
            this.y_textbox.Name = "y_textbox";
            this.y_textbox.Size = new System.Drawing.Size(34, 29);
            this.y_textbox.TabIndex = 2;
            this.y_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_textbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(237, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(107, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите R1 R2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(235, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "R2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(96, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "R1";
            // 
            // r2_textbox
            // 
            this.r2_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r2_textbox.Location = new System.Drawing.Point(189, 186);
            this.r2_textbox.Name = "r2_textbox";
            this.r2_textbox.Size = new System.Drawing.Size(34, 29);
            this.r2_textbox.TabIndex = 7;
            this.r2_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r2_textbox_KeyPress);
            // 
            // r1_textbox
            // 
            this.r1_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r1_textbox.Location = new System.Drawing.Point(131, 186);
            this.r1_textbox.Name = "r1_textbox";
            this.r1_textbox.Size = new System.Drawing.Size(34, 29);
            this.r1_textbox.TabIndex = 6;
            this.r1_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r1_textbox_KeyPress);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancel_button.Location = new System.Drawing.Point(191, 257);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(77, 34);
            this.cancel_button.TabIndex = 27;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(87, 257);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(78, 34);
            this.ok_button.TabIndex = 26;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            // 
            // NewDot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 337);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.r2_textbox);
            this.Controls.Add(this.r1_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y_textbox);
            this.Controls.Add(this.x_textbox);
            this.Controls.Add(this.label1);
            this.Name = "NewDot";
            this.Text = "NewDot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        public System.Windows.Forms.TextBox x_textbox;
        public System.Windows.Forms.TextBox y_textbox;
        public System.Windows.Forms.TextBox r2_textbox;
        public System.Windows.Forms.TextBox r1_textbox;
    }
}