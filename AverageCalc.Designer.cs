namespace Programming_Puzzles_2__PP2_
{
    partial class AverageCalc
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
            this.components = new System.ComponentModel.Container();
            this.lblAverageCalc = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAverageCalc
            // 
            this.lblAverageCalc.AutoSize = true;
            this.lblAverageCalc.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblAverageCalc.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageCalc.ForeColor = System.Drawing.Color.Sienna;
            this.lblAverageCalc.Location = new System.Drawing.Point(222, 59);
            this.lblAverageCalc.Name = "lblAverageCalc";
            this.lblAverageCalc.Size = new System.Drawing.Size(328, 36);
            this.lblAverageCalc.TabIndex = 0;
            this.lblAverageCalc.Text = "Average Calculator";
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue1.ForeColor = System.Drawing.Color.Sienna;
            this.lblValue1.Location = new System.Drawing.Point(228, 113);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(90, 30);
            this.lblValue1.TabIndex = 1;
            this.lblValue1.Text = "Value 1";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue2.ForeColor = System.Drawing.Color.Sienna;
            this.lblValue2.Location = new System.Drawing.Point(228, 153);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(90, 30);
            this.lblValue2.TabIndex = 2;
            this.lblValue2.Text = "Value 2";
            this.lblValue2.Click += new System.EventHandler(this.lblValue2_Click);
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue3.ForeColor = System.Drawing.Color.Sienna;
            this.lblValue3.Location = new System.Drawing.Point(228, 193);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(90, 30);
            this.lblValue3.TabIndex = 3;
            this.lblValue3.Text = "Value 3";
            // 
            // txtValue1
            // 
            this.txtValue1.BackColor = System.Drawing.SystemColors.Window;
            this.txtValue1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue1.Location = new System.Drawing.Point(324, 105);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 38);
            this.txtValue1.TabIndex = 4;
            this.txtValue1.Text = "0";
            // 
            // txtValue2
            // 
            this.txtValue2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue2.Location = new System.Drawing.Point(324, 150);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 38);
            this.txtValue2.TabIndex = 5;
            this.txtValue2.Text = "0";
            // 
            // txtValue3
            // 
            this.txtValue3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue3.Location = new System.Drawing.Point(324, 193);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(100, 38);
            this.txtValue3.TabIndex = 6;
            this.txtValue3.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Sienna;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnCalculate.Location = new System.Drawing.Point(431, 105);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 38);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Sienna;
            this.btnClear.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnClear.Location = new System.Drawing.Point(431, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Sienna;
            this.btnMenu.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnMenu.Location = new System.Drawing.Point(324, 310);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 38);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.ForeColor = System.Drawing.Color.Sienna;
            this.lblAverage.Location = new System.Drawing.Point(228, 260);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(93, 30);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.Text = "Average";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.SystemColors.Window;
            this.txtAverage.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(324, 257);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 38);
            this.txtAverage.TabIndex = 12;
            this.txtAverage.Text = "0";
            this.txtAverage.TextChanged += new System.EventHandler(this.txtAverage_TextChanged);
            // 
            // AverageCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.lblAverageCalc);
            this.Name = "AverageCalc";
            this.Text = "AverageCalc";
            this.Load += new System.EventHandler(this.AverageCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAverageCalc;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblValue3;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAverage;
    }
}