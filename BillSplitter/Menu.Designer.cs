namespace BillSplitter
{
    partial class BillSplitter
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxNames = new System.Windows.Forms.GroupBox();
            this.txtName6 = new System.Windows.Forms.TextBox();
            this.txtName5 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbxNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(6, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(188, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(147, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName1.Location = new System.Drawing.Point(6, 40);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(188, 29);
            this.txtName1.TabIndex = 4;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(6, 21);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(47, 39);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(90, 29);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(18, 20);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aantal";
            // 
            // gbxNames
            // 
            this.gbxNames.BackColor = System.Drawing.Color.Silver;
            this.gbxNames.Controls.Add(this.txtName6);
            this.gbxNames.Controls.Add(this.txtName5);
            this.gbxNames.Controls.Add(this.txtName4);
            this.gbxNames.Controls.Add(this.txtName3);
            this.gbxNames.Controls.Add(this.txtName2);
            this.gbxNames.Controls.Add(this.txtName1);
            this.gbxNames.Controls.Add(this.btnStart);
            this.gbxNames.Location = new System.Drawing.Point(12, 99);
            this.gbxNames.Name = "gbxNames";
            this.gbxNames.Size = new System.Drawing.Size(200, 175);
            this.gbxNames.TabIndex = 9;
            this.gbxNames.TabStop = false;
            this.gbxNames.Text = "Namen";
            // 
            // txtName6
            // 
            this.txtName6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName6.Location = new System.Drawing.Point(6, 240);
            this.txtName6.Name = "txtName6";
            this.txtName6.Size = new System.Drawing.Size(188, 29);
            this.txtName6.TabIndex = 9;
            this.txtName6.Visible = false;
            // 
            // txtName5
            // 
            this.txtName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName5.Location = new System.Drawing.Point(6, 200);
            this.txtName5.Name = "txtName5";
            this.txtName5.Size = new System.Drawing.Size(188, 29);
            this.txtName5.TabIndex = 8;
            this.txtName5.Visible = false;
            // 
            // txtName4
            // 
            this.txtName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName4.Location = new System.Drawing.Point(6, 160);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(188, 29);
            this.txtName4.TabIndex = 7;
            this.txtName4.Visible = false;
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName3.Location = new System.Drawing.Point(6, 120);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(188, 29);
            this.txtName3.TabIndex = 6;
            this.txtName3.Visible = false;
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName2.Location = new System.Drawing.Point(6, 80);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(188, 29);
            this.txtName2.TabIndex = 5;
            // 
            // BillSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(224, 287);
            this.Controls.Add(this.gbxNames);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BillSplitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillSplitter";
            this.Load += new System.EventHandler(this.BillSplitter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxNames.ResumeLayout(false);
            this.gbxNames.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxNames;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName6;
        private System.Windows.Forms.TextBox txtName5;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.TextBox txtName3;
    }
}