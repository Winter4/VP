namespace lab4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_source = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_source_fromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_source_random = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_handling = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_handling_task1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_handling_task2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_handling_task3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save_saveHow = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_params = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.aVector_dataGridView = new System.Windows.Forms.DataGridView();
            this.bVector_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answer_label = new System.Windows.Forms.Label();
            this.answer_dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aVector_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bVector_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_source,
            this.menu_handling,
            this.menu_save,
            this.menu_params,
            this.menu_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_source
            // 
            this.menu_source.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_source_fromFile,
            this.menu_source_random});
            this.menu_source.Name = "menu_source";
            this.menu_source.Size = new System.Drawing.Size(118, 20);
            this.menu_source.Text = "Исходные данные";
            // 
            // menu_source_fromFile
            // 
            this.menu_source_fromFile.Name = "menu_source_fromFile";
            this.menu_source_fromFile.Size = new System.Drawing.Size(223, 22);
            this.menu_source_fromFile.Text = "Ввод массива из файла";
            this.menu_source_fromFile.Click += new System.EventHandler(this.menu_source_fromFile_Click);
            // 
            // menu_source_random
            // 
            this.menu_source_random.Enabled = false;
            this.menu_source_random.Name = "menu_source_random";
            this.menu_source_random.Size = new System.Drawing.Size(223, 22);
            this.menu_source_random.Text = "Случайное формирование";
            this.menu_source_random.Click += new System.EventHandler(this.menu_source_random_Click);
            // 
            // menu_handling
            // 
            this.menu_handling.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_handling_task1,
            this.menu_handling_task2,
            this.menu_handling_task3});
            this.menu_handling.Enabled = false;
            this.menu_handling.Name = "menu_handling";
            this.menu_handling.Size = new System.Drawing.Size(79, 20);
            this.menu_handling.Text = "Обработка";
            // 
            // menu_handling_task1
            // 
            this.menu_handling_task1.Name = "menu_handling_task1";
            this.menu_handling_task1.Size = new System.Drawing.Size(180, 22);
            this.menu_handling_task1.Text = "Задание 1";
            this.menu_handling_task1.Click += new System.EventHandler(this.menu_handling_task1_Click);
            // 
            // menu_handling_task2
            // 
            this.menu_handling_task2.Name = "menu_handling_task2";
            this.menu_handling_task2.Size = new System.Drawing.Size(180, 22);
            this.menu_handling_task2.Text = "Задание 2";
            this.menu_handling_task2.Click += new System.EventHandler(this.menu_handling_task2_Click);
            // 
            // menu_handling_task3
            // 
            this.menu_handling_task3.Name = "menu_handling_task3";
            this.menu_handling_task3.Size = new System.Drawing.Size(180, 22);
            this.menu_handling_task3.Text = "Задание 3";
            this.menu_handling_task3.Click += new System.EventHandler(this.menu_handling_task3_Click);
            // 
            // menu_save
            // 
            this.menu_save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_save_saveHow});
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(77, 20);
            this.menu_save.Text = "Сохранить";
            // 
            // menu_save_saveHow
            // 
            this.menu_save_saveHow.Name = "menu_save_saveHow";
            this.menu_save_saveHow.Size = new System.Drawing.Size(162, 22);
            this.menu_save_saveHow.Text = "Сохранить как...";
            this.menu_save_saveHow.Click += new System.EventHandler(this.menu_save_saveHow_Click);
            // 
            // menu_params
            // 
            this.menu_params.Name = "menu_params";
            this.menu_params.Size = new System.Drawing.Size(83, 20);
            this.menu_params.Text = "Параметры";
            this.menu_params.Click += new System.EventHandler(this.menu_params_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(53, 20);
            this.menu_exit.Text = "Выход";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // aVector_dataGridView
            // 
            this.aVector_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aVector_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aVector_dataGridView.Location = new System.Drawing.Point(17, 61);
            this.aVector_dataGridView.Name = "aVector_dataGridView";
            this.aVector_dataGridView.Size = new System.Drawing.Size(507, 136);
            this.aVector_dataGridView.TabIndex = 1;
            // 
            // bVector_dataGridView
            // 
            this.bVector_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bVector_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bVector_dataGridView.Location = new System.Drawing.Point(561, 61);
            this.bVector_dataGridView.Name = "bVector_dataGridView";
            this.bVector_dataGridView.Size = new System.Drawing.Size(474, 136);
            this.bVector_dataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(556, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(489, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результаты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer_label
            // 
            this.answer_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_label.Location = new System.Drawing.Point(489, 285);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(116, 38);
            this.answer_label.TabIndex = 6;
            this.answer_label.Text = "absent";
            this.answer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answer_label.Visible = false;
            // 
            // answer_dataGridView
            // 
            this.answer_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answer_dataGridView.Location = new System.Drawing.Point(285, 338);
            this.answer_dataGridView.Name = "answer_dataGridView";
            this.answer_dataGridView.Size = new System.Drawing.Size(507, 161);
            this.answer_dataGridView.TabIndex = 7;
            this.answer_dataGridView.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 679);
            this.Controls.Add(this.answer_dataGridView);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVector_dataGridView);
            this.Controls.Add(this.aVector_dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aVector_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bVector_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_source;
        private System.Windows.Forms.ToolStripMenuItem menu_source_fromFile;
        private System.Windows.Forms.ToolStripMenuItem menu_source_random;
        private System.Windows.Forms.ToolStripMenuItem menu_handling;
        private System.Windows.Forms.ToolStripMenuItem menu_save;
        private System.Windows.Forms.ToolStripMenuItem menu_save_saveHow;
        private System.Windows.Forms.ToolStripMenuItem menu_params;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_handling_task1;
        private System.Windows.Forms.ToolStripMenuItem menu_handling_task2;
        private System.Windows.Forms.ToolStripMenuItem menu_handling_task3;
        private System.Windows.Forms.DataGridView aVector_dataGridView;
        private System.Windows.Forms.DataGridView bVector_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.DataGridView answer_dataGridView;
    }
}

