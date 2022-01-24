namespace Calculator
{
    partial class FormCalculator
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
            this.Button1 = new System.Windows.Forms.Button();
            this.labelNumberDisplay = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonCe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(22, 691);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 71);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelNumberDisplay
            // 
            this.labelNumberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberDisplay.Location = new System.Drawing.Point(12, 9);
            this.labelNumberDisplay.Name = "labelNumberDisplay";
            this.labelNumberDisplay.Size = new System.Drawing.Size(424, 102);
            this.labelNumberDisplay.TabIndex = 1;
            this.labelNumberDisplay.Text = "0";
            this.labelNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(114, 691);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 71);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.Location = new System.Drawing.Point(330, 777);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(75, 71);
            this.ButtonEquals.TabIndex = 4;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.Location = new System.Drawing.Point(330, 691);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 71);
            this.ButtonPlus.TabIndex = 3;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonCe
            // 
            this.ButtonCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCe.Location = new System.Drawing.Point(22, 390);
            this.ButtonCe.Name = "ButtonCe";
            this.ButtonCe.Size = new System.Drawing.Size(109, 71);
            this.ButtonCe.TabIndex = 5;
            this.ButtonCe.Text = "CE";
            this.ButtonCe.UseVisualStyleBackColor = true;
            this.ButtonCe.Click += new System.EventHandler(this.ButtonCe_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 858);
            this.Controls.Add(this.ButtonCe);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.labelNumberDisplay);
            this.Controls.Add(this.Button1);
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label labelNumberDisplay;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonCe;
    }
}