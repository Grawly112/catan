namespace Catan
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
            this.label1 = new System.Windows.Forms.Label();
            this.basicbtn = new System.Windows.Forms.Button();
            this.seabtn = new System.Windows.Forms.Button();
            this.citiesbtn = new System.Windows.Forms.Button();
            this.traderbtn = new System.Windows.Forms.Button();
            this.explorersbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catan Card System";
            // 
            // basicbtn
            // 
            this.basicbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicbtn.Location = new System.Drawing.Point(454, 241);
            this.basicbtn.Name = "basicbtn";
            this.basicbtn.Size = new System.Drawing.Size(370, 49);
            this.basicbtn.TabIndex = 1;
            this.basicbtn.Text = "Basic Game";
            this.basicbtn.UseVisualStyleBackColor = true;
            this.basicbtn.Click += new System.EventHandler(this.basicbtn_Click);
            // 
            // seabtn
            // 
            this.seabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seabtn.Location = new System.Drawing.Point(454, 296);
            this.seabtn.Name = "seabtn";
            this.seabtn.Size = new System.Drawing.Size(370, 49);
            this.seabtn.TabIndex = 2;
            this.seabtn.Text = "Seafares";
            this.seabtn.UseVisualStyleBackColor = true;
            // 
            // citiesbtn
            // 
            this.citiesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citiesbtn.Location = new System.Drawing.Point(454, 351);
            this.citiesbtn.Name = "citiesbtn";
            this.citiesbtn.Size = new System.Drawing.Size(370, 49);
            this.citiesbtn.TabIndex = 3;
            this.citiesbtn.Text = "Cities & Knights";
            this.citiesbtn.UseVisualStyleBackColor = true;
            // 
            // traderbtn
            // 
            this.traderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traderbtn.Location = new System.Drawing.Point(454, 406);
            this.traderbtn.Name = "traderbtn";
            this.traderbtn.Size = new System.Drawing.Size(370, 49);
            this.traderbtn.TabIndex = 4;
            this.traderbtn.Text = "Traders and Barbarians";
            this.traderbtn.UseVisualStyleBackColor = true;
            // 
            // explorersbtn
            // 
            this.explorersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorersbtn.Location = new System.Drawing.Point(454, 461);
            this.explorersbtn.Name = "explorersbtn";
            this.explorersbtn.Size = new System.Drawing.Size(370, 49);
            this.explorersbtn.TabIndex = 5;
            this.explorersbtn.Text = "Explorers and Pirates";
            this.explorersbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 724);
            this.Controls.Add(this.explorersbtn);
            this.Controls.Add(this.traderbtn);
            this.Controls.Add(this.citiesbtn);
            this.Controls.Add(this.seabtn);
            this.Controls.Add(this.basicbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button basicbtn;
        private System.Windows.Forms.Button seabtn;
        private System.Windows.Forms.Button citiesbtn;
        private System.Windows.Forms.Button traderbtn;
        private System.Windows.Forms.Button explorersbtn;
    }
}

