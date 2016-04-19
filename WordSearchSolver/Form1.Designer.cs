namespace WordSearchSolver {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb_gridenter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textgrid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tb_gridenter
            // 
            this.tb_gridenter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_gridenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gridenter.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gridenter.Location = new System.Drawing.Point(12, 381);
            this.tb_gridenter.Multiline = true;
            this.tb_gridenter.Name = "tb_gridenter";
            this.tb_gridenter.Size = new System.Drawing.Size(387, 132);
            this.tb_gridenter.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.Location = new System.Drawing.Point(405, 355);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 3;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Text";
            // 
            // textgrid
            // 
            this.textgrid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textgrid.Location = new System.Drawing.Point(12, 12);
            this.textgrid.Name = "textgrid";
            this.textgrid.Size = new System.Drawing.Size(387, 358);
            this.textgrid.TabIndex = 5;
            this.textgrid.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintTextbox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(619, 527);
            this.Controls.Add(this.textgrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_gridenter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_gridenter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel textgrid;
    }
}

