namespace convertorDeCelcius
{
    partial class frmConvertorDeCelcius
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.txtFahre = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.isCelcius = new System.Windows.Forms.CheckBox();
            this.isFahrenheit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "celcius :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "fahrenheit :";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelcius.Location = new System.Drawing.Point(131, 105);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(281, 30);
            this.txtCelcius.TabIndex = 2;
            // 
            // txtFahre
            // 
            this.txtFahre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahre.Location = new System.Drawing.Point(131, 158);
            this.txtFahre.Name = "txtFahre";
            this.txtFahre.Size = new System.Drawing.Size(281, 30);
            this.txtFahre.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(16, 238);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(122, 30);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Converter";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Enabled = false;
            this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(171, 238);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(241, 30);
            this.txtResponse.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "conversor de medida";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // isCelcius
            // 
            this.isCelcius.AutoSize = true;
            this.isCelcius.Checked = true;
            this.isCelcius.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isCelcius.Location = new System.Drawing.Point(83, 203);
            this.isCelcius.Name = "isCelcius";
            this.isCelcius.Size = new System.Drawing.Size(109, 17);
            this.isCelcius.TabIndex = 7;
            this.isCelcius.Text = "Converter Celcius";
            this.isCelcius.UseVisualStyleBackColor = true;
            // 
            // isFahrenheit
            // 
            this.isFahrenheit.AutoSize = true;
            this.isFahrenheit.Location = new System.Drawing.Point(236, 203);
            this.isFahrenheit.Name = "isFahrenheit";
            this.isFahrenheit.Size = new System.Drawing.Size(125, 17);
            this.isFahrenheit.TabIndex = 8;
            this.isFahrenheit.Text = "Converter Fahrenheit";
            this.isFahrenheit.UseVisualStyleBackColor = true;
            // 
            // frmConvertorDeCelcius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 288);
            this.Controls.Add(this.isFahrenheit);
            this.Controls.Add(this.isCelcius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.txtFahre);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConvertorDeCelcius";
            this.Text = "Convertor de Graus Celcius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.TextBox txtFahre;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isCelcius;
        private System.Windows.Forms.CheckBox isFahrenheit;
    }
}

