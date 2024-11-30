namespace Programming_Puzzles_2__PP2_
{
    partial class Menu
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
            this.btnCurrencyConverter = new System.Windows.Forms.Button();
            this.btnTempConverter = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnAverageCalc = new System.Windows.Forms.Button();
            this.btnVATCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCurrencyConverter
            // 
            this.btnCurrencyConverter.BackColor = System.Drawing.Color.Sienna;
            this.btnCurrencyConverter.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencyConverter.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnCurrencyConverter.Location = new System.Drawing.Point(190, 76);
            this.btnCurrencyConverter.Name = "btnCurrencyConverter";
            this.btnCurrencyConverter.Size = new System.Drawing.Size(375, 40);
            this.btnCurrencyConverter.TabIndex = 0;
            this.btnCurrencyConverter.Text = "Currency Converter";
            this.btnCurrencyConverter.UseVisualStyleBackColor = false;
            this.btnCurrencyConverter.Click += new System.EventHandler(this.btnCurrencyConverter_Click);
            // 
            // btnTempConverter
            // 
            this.btnTempConverter.BackColor = System.Drawing.Color.Sienna;
            this.btnTempConverter.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempConverter.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnTempConverter.Location = new System.Drawing.Point(190, 122);
            this.btnTempConverter.Name = "btnTempConverter";
            this.btnTempConverter.Size = new System.Drawing.Size(375, 40);
            this.btnTempConverter.TabIndex = 1;
            this.btnTempConverter.Text = "Temperature Converter";
            this.btnTempConverter.UseVisualStyleBackColor = false;
            this.btnTempConverter.Click += new System.EventHandler(this.btnTempConverter_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Sienna;
            this.lblMenu.Location = new System.Drawing.Point(330, 37);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(103, 36);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            // 
            // btnAverageCalc
            // 
            this.btnAverageCalc.BackColor = System.Drawing.Color.Sienna;
            this.btnAverageCalc.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageCalc.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnAverageCalc.Location = new System.Drawing.Point(190, 169);
            this.btnAverageCalc.Name = "btnAverageCalc";
            this.btnAverageCalc.Size = new System.Drawing.Size(375, 40);
            this.btnAverageCalc.TabIndex = 3;
            this.btnAverageCalc.Text = "Average Calculator";
            this.btnAverageCalc.UseVisualStyleBackColor = false;
            this.btnAverageCalc.Click += new System.EventHandler(this.btnAverageCalc_Click);
            // 
            // btnVATCalc
            // 
            this.btnVATCalc.BackColor = System.Drawing.Color.Sienna;
            this.btnVATCalc.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVATCalc.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnVATCalc.Location = new System.Drawing.Point(190, 216);
            this.btnVATCalc.Name = "btnVATCalc";
            this.btnVATCalc.Size = new System.Drawing.Size(375, 40);
            this.btnVATCalc.TabIndex = 4;
            this.btnVATCalc.Text = "VAT Calculator";
            this.btnVATCalc.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVATCalc);
            this.Controls.Add(this.btnAverageCalc);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnTempConverter);
            this.Controls.Add(this.btnCurrencyConverter);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCurrencyConverter;
        private System.Windows.Forms.Button btnTempConverter;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnAverageCalc;
        private System.Windows.Forms.Button btnVATCalc;
    }
}