namespace Windowform1
{
    partial class renteform
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
            this.label2 = new System.Windows.Forms.Label();
            this.bedragbox = new System.Windows.Forms.TextBox();
            this.rentebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bedrag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rentepercentage:";
            // 
            // bedragbox
            // 
            this.bedragbox.Location = new System.Drawing.Point(192, 34);
            this.bedragbox.Name = "bedragbox";
            this.bedragbox.Size = new System.Drawing.Size(100, 20);
            this.bedragbox.TabIndex = 2;
            // 
            // rentebox
            // 
            this.rentebox.Location = new System.Drawing.Point(192, 85);
            this.rentebox.Name = "rentebox";
            this.rentebox.Size = new System.Drawing.Size(100, 20);
            this.rentebox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Location = new System.Drawing.Point(386, 42);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 13);
            this.text.TabIndex = 5;
            // 
            // renteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 392);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rentebox);
            this.Controls.Add(this.bedragbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "renteform";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bedragbox;
        private System.Windows.Forms.TextBox rentebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label text;
    }
}

