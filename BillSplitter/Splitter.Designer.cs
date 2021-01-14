namespace BillSplitter
{
    partial class Splitter
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
            this.gbxPerson = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxBills = new System.Windows.Forms.ListBox();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbxPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.txtTotal);
            this.gbxPerson.Controls.Add(this.label1);
            this.gbxPerson.Controls.Add(this.lbxBills);
            this.gbxPerson.Location = new System.Drawing.Point(170, 12);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(137, 293);
            this.gbxPerson.TabIndex = 9;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "persoon";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(6, 252);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(125, 22);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Totaal:";
            // 
            // lbxBills
            // 
            this.lbxBills.BackColor = System.Drawing.Color.Ivory;
            this.lbxBills.FormattingEnabled = true;
            this.lbxBills.Location = new System.Drawing.Point(6, 46);
            this.lbxBills.Name = "lbxBills";
            this.lbxBills.Size = new System.Drawing.Size(125, 160);
            this.lbxBills.TabIndex = 4;
            // 
            // lbxNames
            // 
            this.lbxNames.BackColor = System.Drawing.Color.Ivory;
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.Location = new System.Drawing.Point(35, 178);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(119, 108);
            this.lbxNames.TabIndex = 3;
            this.lbxNames.SelectedIndexChanged += new System.EventHandler(this.lbxNames_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(12, 337);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(289, 45);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Bereken";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntry.Location = new System.Drawing.Point(35, 70);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEntry.Size = new System.Drawing.Size(119, 22);
            this.txtEntry.TabIndex = 1;
            this.txtEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(35, 99);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Splitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 413);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.gbxPerson);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.btnCalc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Splitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BillSplitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPerson.ResumeLayout(false);
            this.gbxPerson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.ListBox lbxBills;
        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnEnter;
    }
}

