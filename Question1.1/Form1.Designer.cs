namespace MobileStockApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtQuantity;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblOutput
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(40, 20);
            this.lblOutput.Size = new System.Drawing.Size(250, 30);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Text = "Mobile Code";

            // txtCode
            this.txtCode.Location = new System.Drawing.Point(150, 80);
            this.txtCode.Size = new System.Drawing.Size(120, 23);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Text = "Make";

            // txtMake
            this.txtMake.Location = new System.Drawing.Point(150, 120);
            this.txtMake.Size = new System.Drawing.Size(120, 23);

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Text = "Quantity";

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(150, 160);
            this.txtQuantity.Size = new System.Drawing.Size(120, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(30, 220);
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(130, 220);
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnFind
            this.btnFind.Location = new System.Drawing.Point(230, 220);
            this.btnFind.Size = new System.Drawing.Size(75, 30);
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);

            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);

            this.Name = "Form1";
            this.Text = "Mobile Stock App";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}