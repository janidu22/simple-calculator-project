namespace my_calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn0 = new Button();
            btnFloat = new Button();
            btnAssignment = new Button();
            btnAdd = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnSubstract = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiply = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            txtDisplay = new TextBox();
            btnDevide = new Button();
            btnPercentage = new Button();
            btnCE = new Button();
            btnC = new Button();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Location = new Point(22, 449);
            btn0.Name = "btn0";
            btn0.Size = new Size(144, 68);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Button_click;
            // 
            // btnFloat
            // 
            btnFloat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFloat.Location = new Point(172, 449);
            btnFloat.Name = "btnFloat";
            btnFloat.Size = new Size(69, 68);
            btnFloat.TabIndex = 2;
            btnFloat.Text = ".";
            btnFloat.UseVisualStyleBackColor = true;
            btnFloat.Click += Button_click;
            // 
            // btnAssignment
            // 
            btnAssignment.BackColor = Color.FromArgb(255, 128, 0);
            btnAssignment.Font = new Font("Segoe UI", 15F);
            btnAssignment.Location = new Point(247, 449);
            btnAssignment.Name = "btnAssignment";
            btnAssignment.Size = new Size(69, 68);
            btnAssignment.TabIndex = 3;
            btnAssignment.Text = "=";
            btnAssignment.UseVisualStyleBackColor = false;
            btnAssignment.Click += Btn_assignment_click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 0);
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(247, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 68);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Button_click;
            // 
            // btn3
            // 
            btn3.Location = new Point(172, 375);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 68);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Button_click;
            // 
            // btn2
            // 
            btn2.Location = new Point(97, 375);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 68);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Button_click;
            // 
            // btn1
            // 
            btn1.Location = new Point(22, 375);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 68);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Button_click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = Color.FromArgb(255, 128, 0);
            btnSubstract.Font = new Font("Segoe UI", 20F);
            btnSubstract.Location = new Point(247, 301);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(69, 68);
            btnSubstract.TabIndex = 11;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = false;
            btnSubstract.Click += Button_click;
            // 
            // btn6
            // 
            btn6.Location = new Point(172, 301);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 68);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Button_click;
            // 
            // btn5
            // 
            btn5.Location = new Point(97, 301);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 68);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Button_click;
            // 
            // btn4
            // 
            btn4.Location = new Point(22, 301);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 68);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Button_click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 15F);
            btnMultiply.Location = new Point(247, 227);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(69, 68);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += Button_click;
            // 
            // btn9
            // 
            btn9.Location = new Point(172, 227);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 68);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Button_click;
            // 
            // btn8
            // 
            btn8.Location = new Point(97, 227);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 68);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Button_click;
            // 
            // btn7
            // 
            btn7.Location = new Point(22, 227);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 68);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Button_click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20F);
            txtDisplay.Location = new Point(25, 41);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(294, 69);
            txtDisplay.TabIndex = 16;
            // 
            // btnDevide
            // 
            btnDevide.BackColor = Color.FromArgb(255, 128, 0);
            btnDevide.Font = new Font("Segoe UI", 15F);
            btnDevide.Location = new Point(247, 153);
            btnDevide.Name = "btnDevide";
            btnDevide.Size = new Size(69, 68);
            btnDevide.TabIndex = 20;
            btnDevide.Text = "/";
            btnDevide.UseVisualStyleBackColor = false;
            btnDevide.Click += Button_click;
            // 
            // btnPercentage
            // 
            btnPercentage.Location = new Point(172, 153);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(69, 68);
            btnPercentage.TabIndex = 19;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += Button_click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(97, 153);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(69, 68);
            btnCE.TabIndex = 18;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(22, 153);
            btnC.Name = "btnC";
            btnC.Size = new Size(69, 68);
            btnC.TabIndex = 17;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += Clear_button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(342, 553);
            Controls.Add(btnDevide);
            Controls.Add(btnPercentage);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(txtDisplay);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSubstract);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnAssignment);
            Controls.Add(btnFloat);
            Controls.Add(btn0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Simple Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button btnFloat;
        private Button btnAssignment;
        private Button btnAdd;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnSubstract;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMultiply;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private TextBox txtDisplay;
        private Button btnDevide;
        private Button btnPercentage;
        private Button btnCE;
        private Button btnC;
    }
}
