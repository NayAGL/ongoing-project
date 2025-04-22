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
            lblForm2Title.Location = new Point(34, 9);
            lblForm2Title.Name = "lblForm2Title";
            lblForm2Title.Size = new Size(418, 43);
            lblForm2Title.TabIndex = 0;
            lblForm2Title.Text = "Platform Markup Rates";
            // 
            // lblPC
            // 
            lblPC.AutoSize = true;
            lblPC.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPC.Location = new Point(52, 88);
            lblPC.Name = "lblPC";
            lblPC.Size = new Size(32, 24);
            lblPC.TabIndex = 1;
            lblPC.Text = "PC";
            // 
            // txtPC
            // 
            txtPC.Location = new Point(189, 88);
            txtPC.Name = "txtPC";
            txtPC.Size = new Size(150, 31);
            txtPC.TabIndex = 2;
            // 
            // txtPlayStation
            // 
            txtPlayStation.Location = new Point(189, 125);
            txtPlayStation.Name = "txtPlayStation";
            txtPlayStation.Size = new Size(150, 31);
            txtPlayStation.TabIndex = 4;
            // 
            // lblPlayStation
            // 
            lblPlayStation.AutoSize = true;
            lblPlayStation.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayStation.Location = new Point(52, 125);
            lblPlayStation.Name = "lblPlayStation";
            lblPlayStation.Size = new Size(131, 24);
            lblPlayStation.TabIndex = 3;
            lblPlayStation.Text = "PlayStation";
            // 
            // txtXbox
            // 
            txtXbox.Location = new Point(189, 164);
            txtXbox.Name = "txtXbox";
            txtXbox.Size = new Size(150, 31);
            txtXbox.TabIndex = 6;
            // 
            // lblXbox
            // 
            lblXbox.AutoSize = true;
            lblXbox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXbox.Location = new Point(52, 164);
            lblXbox.Name = "lblXbox";
            lblXbox.Size = new Size(54, 24);
            lblXbox.TabIndex = 5;
            lblXbox.Text = "Xbox";
            // 
            // btnReturnSave
            // 
            btnReturnSave.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnSave.Location = new Point(85, 210);
            btnReturnSave.Name = "btnReturnSave";
            btnReturnSave.Size = new Size(161, 34);
            btnReturnSave.TabIndex = 7;
            btnReturnSave.Text = "Return && Save";
            btnReturnSave.UseVisualStyleBackColor = true;
            btnReturnSave.Click += btnReturnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 284);
            Controls.Add(btnReturnSave);
            Controls.Add(txtXbox);
            Controls.Add(lblXbox);
            Controls.Add(txtPlayStation);
            Controls.Add(lblPlayStation);
            Controls.Add(txtPC);
            Controls.Add(lblPC);
            Controls.Add(lblForm2Title);
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