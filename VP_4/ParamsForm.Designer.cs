namespace lab4
{
    partial class ParamsForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.rightRandA_textbox = new System.Windows.Forms.TextBox();
            this.leftRandA_textbox = new System.Windows.Forms.TextBox();
            this.bLen_textbox = new System.Windows.Forms.TextBox();
            this.aLen_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leftRandB_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rightRandB_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancel_button.Location = new System.Drawing.Point(415, 292);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(141, 34);
            this.cancel_button.TabIndex = 25;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Location = new System.Drawing.Point(204, 292);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(132, 34);
            this.ok_button.TabIndex = 24;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // rightRandA_textbox
            // 
            this.rightRandA_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightRandA_textbox.Location = new System.Drawing.Point(540, 52);
            this.rightRandA_textbox.Name = "rightRandA_textbox";
            this.rightRandA_textbox.Size = new System.Drawing.Size(100, 26);
            this.rightRandA_textbox.TabIndex = 17;
            this.rightRandA_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightRandA_textbox_KeyPress);
            // 
            // leftRandA_textbox
            // 
            this.leftRandA_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftRandA_textbox.Location = new System.Drawing.Point(540, 19);
            this.leftRandA_textbox.Name = "leftRandA_textbox";
            this.leftRandA_textbox.Size = new System.Drawing.Size(100, 26);
            this.leftRandA_textbox.TabIndex = 16;
            this.leftRandA_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftRandA_textbox_KeyPress);
            // 
            // bLen_textbox
            // 
            this.bLen_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLen_textbox.Location = new System.Drawing.Point(194, 124);
            this.bLen_textbox.Name = "bLen_textbox";
            this.bLen_textbox.Size = new System.Drawing.Size(100, 26);
            this.bLen_textbox.TabIndex = 15;
            this.bLen_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bLen_textbox_KeyPress);
            // 
            // aLen_textbox
            // 
            this.aLen_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLen_textbox.Location = new System.Drawing.Point(194, 38);
            this.aLen_textbox.Name = "aLen_textbox";
            this.aLen_textbox.Size = new System.Drawing.Size(100, 26);
            this.aLen_textbox.TabIndex = 14;
            this.aLen_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aLen_textbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(358, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Рандом до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(358, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Рандом от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Длина массива В";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Длина массива А";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(361, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Рандом от";
            // 
            // leftRandB_textbox
            // 
            this.leftRandB_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftRandB_textbox.Location = new System.Drawing.Point(540, 104);
            this.leftRandB_textbox.Name = "leftRandB_textbox";
            this.leftRandB_textbox.Size = new System.Drawing.Size(100, 26);
            this.leftRandB_textbox.TabIndex = 21;
            this.leftRandB_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftRandB_textbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(361, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Рандом до";
            // 
            // rightRandB_textbox
            // 
            this.rightRandB_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightRandB_textbox.Location = new System.Drawing.Point(540, 140);
            this.rightRandB_textbox.Name = "rightRandB_textbox";
            this.rightRandB_textbox.Size = new System.Drawing.Size(100, 26);
            this.rightRandB_textbox.TabIndex = 23;
            this.rightRandB_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightRandB_textbox_KeyPress);
            // 
            // ParamsForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 396);
            this.ControlBox = false;
            this.Controls.Add(this.rightRandB_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leftRandB_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.rightRandA_textbox);
            this.Controls.Add(this.leftRandA_textbox);
            this.Controls.Add(this.bLen_textbox);
            this.Controls.Add(this.aLen_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ParamsForm";
            this.Text = "Параметры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        public System.Windows.Forms.TextBox rightRandA_textbox;
        public System.Windows.Forms.TextBox leftRandA_textbox;
        public System.Windows.Forms.TextBox bLen_textbox;
        public System.Windows.Forms.TextBox aLen_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox leftRandB_textbox;
        public System.Windows.Forms.TextBox rightRandB_textbox;
    }
}