namespace ApplicationModBus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblValueHR = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblValueIR = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStatus = new Label();
            label4 = new Label();
            lblCoil = new Label();
            btnSR = new Button();
            txtRegVal = new TextBox();
            chbWSC = new CheckBox();
            label5 = new Label();
            txtGraficStatus = new TextBox();
            txtGrafficCoil = new TextBox();
            pBarIR = new ProgressBar();
            pBarHR = new ProgressBar();
            SuspendLayout();
            // 
            // lblValueHR
            // 
            lblValueHR.AutoSize = true;
            lblValueHR.Location = new Point(255, 20);
            lblValueHR.Name = "lblValueHR";
            lblValueHR.Size = new Size(17, 20);
            lblValueHR.TabIndex = 1;
            lblValueHR.Text = "0";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 3000;
            timer.Tick += Timer_Tick;
            // 
            // lblValueIR
            // 
            lblValueIR.AutoSize = true;
            lblValueIR.Location = new Point(255, 53);
            lblValueIR.Name = "lblValueIR";
            lblValueIR.Size = new Size(17, 20);
            lblValueIR.TabIndex = 2;
            lblValueIR.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 3;
            label1.Text = "Holding Register Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 4;
            label2.Text = "Input Register Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 5;
            label3.Text = "Input Status Value";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(255, 88);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(17, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Coil Value";
            // 
            // lblCoil
            // 
            lblCoil.AutoSize = true;
            lblCoil.Location = new Point(255, 121);
            lblCoil.Name = "lblCoil";
            lblCoil.Size = new Size(17, 20);
            lblCoil.TabIndex = 8;
            lblCoil.Text = "0";
            // 
            // btnSR
            // 
            btnSR.Location = new Point(12, 168);
            btnSR.Name = "btnSR";
            btnSR.Size = new Size(205, 29);
            btnSR.TabIndex = 9;
            btnSR.Text = "Write Single Register";
            btnSR.UseVisualStyleBackColor = true;
            btnSR.Click += btnSR_Click;
            // 
            // txtRegVal
            // 
            txtRegVal.BorderStyle = BorderStyle.None;
            txtRegVal.Location = new Point(255, 169);
            txtRegVal.Name = "txtRegVal";
            txtRegVal.Size = new Size(78, 20);
            txtRegVal.TabIndex = 10;
            // 
            // chbWSC
            // 
            chbWSC.AutoSize = true;
            chbWSC.Location = new Point(255, 208);
            chbWSC.Name = "chbWSC";
            chbWSC.Size = new Size(18, 17);
            chbWSC.TabIndex = 13;
            chbWSC.UseVisualStyleBackColor = true;
            chbWSC.CheckedChanged += chbWSC_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 208);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 14;
            label5.Text = "Write Single Coil";
            // 
            // txtGraficStatus
            // 
            txtGraficStatus.AcceptsTab = true;
            txtGraficStatus.Location = new Point(308, 88);
            txtGraficStatus.Name = "txtGraficStatus";
            txtGraficStatus.Size = new Size(99, 27);
            txtGraficStatus.TabIndex = 15;
            // 
            // txtGrafficCoil
            // 
            txtGrafficCoil.Location = new Point(308, 121);
            txtGrafficCoil.Name = "txtGrafficCoil";
            txtGrafficCoil.Size = new Size(99, 27);
            txtGrafficCoil.TabIndex = 16;
            // 
            // pBarIR
            // 
            pBarIR.Location = new Point(308, 53);
            pBarIR.Name = "pBarIR";
            pBarIR.Size = new Size(99, 27);
            pBarIR.TabIndex = 17;
            // 
            // pBarHR
            // 
            pBarHR.Location = new Point(308, 20);
            pBarHR.Name = "pBarHR";
            pBarHR.Size = new Size(99, 27);
            pBarHR.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 448);
            Controls.Add(pBarHR);
            Controls.Add(pBarIR);
            Controls.Add(txtGrafficCoil);
            Controls.Add(txtGraficStatus);
            Controls.Add(label5);
            Controls.Add(chbWSC);
            Controls.Add(txtRegVal);
            Controls.Add(btnSR);
            Controls.Add(lblCoil);
            Controls.Add(label4);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValueIR);
            Controls.Add(lblValueHR);
            Name = "Form1";
            Text = "Tests using EasyModbus Library";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblValueHR;
        private System.Windows.Forms.Timer timer;
        private Label lblValueIR;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStatus;
        private Label label4;
        private Label lblCoil;
        private Button btnSR;
        private TextBox txtRegVal;
        private CheckBox chbWSC;
        private Label label5;
        private TextBox txtGraficStatus;
        private TextBox txtGrafficCoil;
        private ProgressBar pBarIR;
        private ProgressBar pBarHR;
    }
}