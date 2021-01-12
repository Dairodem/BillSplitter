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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gbxPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPerson
            // 
            this.gbxPerson.Controls.Add(this.listBox2);
            this.gbxPerson.Location = new System.Drawing.Point(170, 12);
            this.gbxPerson.Name = "gbxPerson";
            this.gbxPerson.Size = new System.Drawing.Size(137, 293);
            this.gbxPerson.TabIndex = 9;
            this.gbxPerson.TabStop = false;
            this.gbxPerson.Text = "persoon";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Ivory;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(125, 238);
            this.listBox2.TabIndex = 6;
            // 
            // lbxNames
            // 
            this.lbxNames.BackColor = System.Drawing.Color.Ivory;
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.Location = new System.Drawing.Point(12, 59);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(126, 108);
            this.lbxNames.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCalc.Location = new System.Drawing.Point(158, 355);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(289, 45);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Bereken";
            this.btnCalc.UseVisualStyleBackColor = false;
            // 
            // Splitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 413);
            this.Controls.Add(this.gbxPerson);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.btnCalc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Splitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BillSplitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPerson.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPerson;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.Button btnCalc;
    }
}

