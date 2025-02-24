namespace Nay_Aung_Latt
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
            lblFormTitle = new Label();
            lblGameName = new Label();
            lblGamePrice = new Label();
            txtGameName = new TextBox();
            txtGamePrice = new TextBox();
            btnCalculate = new Button();
            lstOutput = new ListBox();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.ControlText;
            lblFormTitle.Location = new Point(142, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(193, 37);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Random Play";
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameName.Location = new Point(36, 85);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(45, 20);
            lblGameName.TabIndex = 1;
            lblGameName.Text = "Game";
            // 
            // lblGamePrice
            // 
            lblGamePrice.AutoSize = true;
            lblGamePrice.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGamePrice.Location = new Point(27, 117);
            lblGamePrice.Name = "lblGamePrice";
            lblGamePrice.Size = new Size(54, 20);
            lblGamePrice.TabIndex = 2;
            lblGamePrice.Text = "Price";
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(84, 82);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(193, 27);
            txtGameName.TabIndex = 3;
            txtGameName.Enter += txtGameName_Enter;
            txtGameName.Leave += txtGameName_Leave;
            // 
            // txtGamePrice
            // 
            txtGamePrice.Location = new Point(84, 115);
            txtGamePrice.Name = "txtGamePrice";
            txtGamePrice.Size = new Size(193, 27);
            txtGamePrice.TabIndex = 4;
            txtGamePrice.Enter += txtGamePrice_Enter;
            txtGamePrice.Leave += txtGamePrice_Leave;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(84, 148);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(88, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(293, 81);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(168, 64);
            lstOutput.TabIndex = 6;
            lstOutput.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(293, 151);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(60, 29);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.AliceBlue;
            btnExit.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(441, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 233);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(lstOutput);
            Controls.Add(btnCalculate);
            Controls.Add(txtGamePrice);
            Controls.Add(txtGameName);
            Controls.Add(lblGamePrice);
            Controls.Add(lblGameName);
            Controls.Add(lblFormTitle);
            Name = "Form1";
            Text = "ICA 2 - Nay Aung Latt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblGameName;
        private Label lblGamePrice;
        private TextBox txtGameName;
        private TextBox txtGamePrice;
        private Button btnCalculate;
        private ListBox lstOutput;
        private Button btnReset;
        private Button btnExit;
    }
}
