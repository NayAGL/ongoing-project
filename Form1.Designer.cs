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
            gpbPlatforms = new GroupBox();
            rdoXbox = new RadioButton();
            rdoPlayStation = new RadioButton();
            rdoPC = new RadioButton();
            gpbPlatforms.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.ControlText;
            lblFormTitle.Location = new Point(279, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(193, 37);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Random Play";
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameName.Location = new Point(18, 145);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(45, 20);
            lblGameName.TabIndex = 1;
            lblGameName.Text = "Game";
            // 
            // lblGamePrice
            // 
            lblGamePrice.AutoSize = true;
            lblGamePrice.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGamePrice.Location = new Point(9, 177);
            lblGamePrice.Name = "lblGamePrice";
            lblGamePrice.Size = new Size(54, 20);
            lblGamePrice.TabIndex = 2;
            lblGamePrice.Text = "Price";
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(66, 142);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(178, 27);
            txtGameName.TabIndex = 3;
            txtGameName.Enter += txtGameName_Enter;
            txtGameName.Leave += txtGameName_Leave;
            // 
            // txtGamePrice
            // 
            txtGamePrice.Location = new Point(66, 175);
            txtGamePrice.Name = "txtGamePrice";
            txtGamePrice.Size = new Size(178, 27);
            txtGamePrice.TabIndex = 4;
            txtGamePrice.Enter += txtGamePrice_Enter;
            txtGamePrice.Leave += txtGamePrice_Leave;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(66, 219);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(88, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(250, 142);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(467, 104);
            lstOutput.TabIndex = 6;
            lstOutput.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(184, 219);
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
            btnExit.Location = new Point(657, 279);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // gpbPlatforms
            // 
            gpbPlatforms.Controls.Add(rdoXbox);
            gpbPlatforms.Controls.Add(rdoPlayStation);
            gpbPlatforms.Controls.Add(rdoPC);
            gpbPlatforms.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbPlatforms.Location = new Point(9, 49);
            gpbPlatforms.Name = "gpbPlatforms";
            gpbPlatforms.Size = new Size(708, 77);
            gpbPlatforms.TabIndex = 9;
            gpbPlatforms.TabStop = false;
            gpbPlatforms.Text = "Platforms";
            // 
            // rdoXbox
            // 
            rdoXbox.AutoSize = true;
            rdoXbox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoXbox.Location = new Point(611, 31);
            rdoXbox.Name = "rdoXbox";
            rdoXbox.Size = new Size(66, 24);
            rdoXbox.TabIndex = 2;
            rdoXbox.TabStop = true;
            rdoXbox.Text = "Xbox";
            rdoXbox.UseVisualStyleBackColor = true;
            rdoXbox.CheckedChanged += rdoXbox_CheckedChanged;
            // 
            // rdoPlayStation
            // 
            rdoPlayStation.AutoSize = true;
            rdoPlayStation.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoPlayStation.Location = new Point(297, 31);
            rdoPlayStation.Name = "rdoPlayStation";
            rdoPlayStation.Size = new Size(129, 24);
            rdoPlayStation.TabIndex = 1;
            rdoPlayStation.TabStop = true;
            rdoPlayStation.Text = "PlayStation";
            rdoPlayStation.UseVisualStyleBackColor = true;
            rdoPlayStation.CheckedChanged += rdoPlayStation_CheckedChanged;
            // 
            // rdoPC
            // 
            rdoPC.AutoSize = true;
            rdoPC.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoPC.Location = new Point(34, 31);
            rdoPC.Name = "rdoPC";
            rdoPC.Size = new Size(48, 24);
            rdoPC.TabIndex = 0;
            rdoPC.TabStop = true;
            rdoPC.Text = "PC";
            rdoPC.UseVisualStyleBackColor = true;
            rdoPC.CheckedChanged += rdoPC_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 318);
            Controls.Add(gpbPlatforms);
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
            Text = "ICA 5 - Nay Aung Latt";
            Load += Form1_Load;
            gpbPlatforms.ResumeLayout(false);
            gpbPlatforms.PerformLayout();
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
        private GroupBox gpbPlatforms;
        private RadioButton rdoXbox;
        private RadioButton rdoPlayStation;
        private RadioButton rdoPC;
    }
}