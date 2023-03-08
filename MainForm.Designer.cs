namespace _102210247_LeVanTienDat
{
    partial class MainForm
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
            this.lop1 = new System.Windows.Forms.ComboBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonsort = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp sinh hoạt";
            // 
            // lop1
            // 
            this.lop1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lop1.AllowDrop = true;
            this.lop1.FormattingEnabled = true;
            this.lop1.ItemHeight = 16;
            this.lop1.Items.AddRange(new object[] {
            "All"});
            this.lop1.Location = new System.Drawing.Point(194, 25);
            this.lop1.Name = "lop1";
            this.lop1.Size = new System.Drawing.Size(162, 24);
            this.lop1.TabIndex = 1;
            this.lop1.SelectedIndex = 0;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsearch.Location = new System.Drawing.Point(512, 20);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(97, 30);
            this.buttonsearch.TabIndex = 2;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(684, 25);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(178, 27);
            this.textsearch.TabIndex = 3;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(47, 94);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(815, 421);
            this.data.TabIndex = 4;
            // 
            // buttonadd
            // 
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(47, 541);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(100, 30);
            this.buttonadd.TabIndex = 5;
            this.buttonadd.Text = "ADD";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonedit.Location = new System.Drawing.Point(220, 541);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(100, 30);
            this.buttonedit.TabIndex = 6;
            this.buttonedit.Text = "EDIT";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.Location = new System.Drawing.Point(431, 541);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(100, 30);
            this.buttondelete.TabIndex = 7;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonsort
            // 
            this.buttonsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsort.Location = new System.Drawing.Point(621, 541);
            this.buttonsort.Name = "buttonsort";
            this.buttonsort.Size = new System.Drawing.Size(100, 30);
            this.buttonsort.TabIndex = 8;
            this.buttonsort.Text = "SORT";
            this.buttonsort.UseVisualStyleBackColor = true;
            this.buttonsort.Click += new System.EventHandler(this.buttonsort_Click);
            // 
            // sort
            // 
            this.sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.FormattingEnabled = true;
            this.sort.Items.AddRange(new object[] {
            "MSSV",
            "Lớp SH",
            "Ngày sinh",
            "Điểm TB"});
            this.sort.Location = new System.Drawing.Point(761, 541);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(101, 28);
            this.sort.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 598);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.buttonsort);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.data);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.lop1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lop1;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonsort;
        private System.Windows.Forms.ComboBox sort;
    }
}



