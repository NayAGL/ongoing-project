namespace Nay_Aung_Latt
{
    partial class Form2
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
            lblForm2Title = new Label();
            lblPC = new Label();
            txtPC = new TextBox();
            txtPlayStation = new TextBox();
            lblPlayStation = new Label();
            txtXbox = new TextBox();
            lblXbox = new Label();
            btnReturnSave = new Button();
            SuspendLayout();
            // 
            // lblForm2Title
            // 
            lblForm2Title.AutoSize = true;
            lblForm2Title.Font = new Font("Cascadia Mono SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForm2Title.Location = new Point(27, 7);
            lblForm2Title.Margin = new Padding(2, 0, 2, 0);
            lblForm2Title.Name = "lblForm2Title";
            lblForm2Title.Size = new Size(351, 35);
            lblForm2Title.TabIndex = 0;
            lblForm2Title.Text = "Platform Markup Rates";
            // 
            // lblPC
            // 
            lblPC.AutoSize = true;
            lblPC.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPC.Location = new Point(42, 70);
            lblPC.Margin = new Padding(2, 0, 2, 0);
            lblPC.Name = "lblPC";
            lblPC.Size = new Size(27, 20);
            lblPC.TabIndex = 1;
            lblPC.Text = "PC";
            // 
            // txtPC
            // 
            txtPC.Location = new Point(151, 70);
            txtPC.Margin = new Padding(2, 2, 2, 2);
            txtPC.Name = "txtPC";
            txtPC.Size = new Size(121, 27);
            txtPC.TabIndex = 2;
            // 
            // txtPlayStation
            // 
            txtPlayStation.Location = new Point(151, 100);
            txtPlayStation.Margin = new Padding(2, 2, 2, 2);
            txtPlayStation.Name = "txtPlayStation";
            txtPlayStation.Size = new Size(121, 27);
            txtPlayStation.TabIndex = 4;
            // 
            // lblPlayStation
            // 
            lblPlayStation.AutoSize = true;
            lblPlayStation.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayStation.Location = new Point(42, 100);
            lblPlayStation.Margin = new Padding(2, 0, 2, 0);
            lblPlayStation.Name = "lblPlayStation";
            lblPlayStation.Size = new Size(108, 20);
            lblPlayStation.TabIndex = 3;
            lblPlayStation.Text = "PlayStation";
            // 
            // txtXbox
            // 
            txtXbox.Location = new Point(151, 131);
            txtXbox.Margin = new Padding(2, 2, 2, 2);
            txtXbox.Name = "txtXbox";
            txtXbox.Size = new Size(121, 27);
            txtXbox.TabIndex = 6;
            // 
            // lblXbox
            // 
            lblXbox.AutoSize = true;
            lblXbox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXbox.Location = new Point(42, 131);
            lblXbox.Margin = new Padding(2, 0, 2, 0);
            lblXbox.Name = "lblXbox";
            lblXbox.Size = new Size(45, 20);
            lblXbox.TabIndex = 5;
            lblXbox.Text = "Xbox";
            // 
            // btnReturnSave
            // 
            btnReturnSave.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnSave.Location = new Point(68, 168);
            btnReturnSave.Margin = new Padding(2, 2, 2, 2);
            btnReturnSave.Name = "btnReturnSave";
            btnReturnSave.Size = new Size(149, 27);
            btnReturnSave.TabIndex = 7;
            btnReturnSave.Text = "Return && Save";
            btnReturnSave.UseVisualStyleBackColor = true;
            btnReturnSave.Click += btnReturnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 227);
            Controls.Add(btnReturnSave);
            Controls.Add(txtXbox);
            Controls.Add(lblXbox);
            Controls.Add(txtPlayStation);
            Controls.Add(lblPlayStation);
            Controls.Add(txtPC);
            Controls.Add(lblPC);
            Controls.Add(lblForm2Title);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
            Text = "Markup Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForm2Title;
        private Label lblPC;
        private Label lblPlayStation;
        private Label lblXbox;
        private Button btnReturnSave;
        internal TextBox txtPC;
        internal TextBox txtPlayStation;
        internal TextBox txtXbox;
    }
}