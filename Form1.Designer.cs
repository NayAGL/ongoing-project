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
            OFD = new OpenFileDialog();
            mnuStripSettings = new MenuStrip();
            mnuSettings = new ToolStripMenuItem();
            showLogsToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            gpbPlatforms.SuspendLayout();
            mnuStripSettings.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.ForeColor = SystemColors.ControlText;
            lblFormTitle.Location = new Point(349, 11);
            lblFormTitle.Margin = new Padding(4, 0, 4, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(228, 44);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Random Play";
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameName.Location = new Point(22, 202);
            lblGameName.Margin = new Padding(4, 0, 4, 0);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(54, 24);
            lblGameName.TabIndex = 1;
            lblGameName.Text = "Game";
            // 
            // lblGamePrice
            // 
            lblGamePrice.AutoSize = true;
            lblGamePrice.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGamePrice.Location = new Point(11, 242);
            lblGamePrice.Margin = new Padding(4, 0, 4, 0);
            lblGamePrice.Name = "lblGamePrice";
            lblGamePrice.Size = new Size(65, 24);
            lblGamePrice.TabIndex = 2;
            lblGamePrice.Text = "Price";
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(82, 199);
            txtGameName.Margin = new Padding(4);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(222, 31);
            txtGameName.TabIndex = 3;
            txtGameName.Enter += txtGameName_Enter;
            txtGameName.Leave += txtGameName_Leave;
            // 
            // txtGamePrice
            // 
            txtGamePrice.Location = new Point(82, 240);
            txtGamePrice.Margin = new Padding(4);
            txtGamePrice.Name = "txtGamePrice";
            txtGamePrice.Size = new Size(222, 31);
            txtGamePrice.TabIndex = 4;
            txtGamePrice.Enter += txtGamePrice_Enter;
            txtGamePrice.Leave += txtGamePrice_Leave;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(82, 331);
            btnCalculate.Margin = new Padding(4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(110, 36);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(312, 178);
            lstOutput.Margin = new Padding(4);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(583, 196);
            lstOutput.TabIndex = 6;
            lstOutput.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(230, 331);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 36);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.AliceBlue;
            btnExit.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(821, 431);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 36);
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
            gpbPlatforms.Location = new Point(11, 61);
            gpbPlatforms.Margin = new Padding(4);
            gpbPlatforms.Name = "gpbPlatforms";
            gpbPlatforms.Padding = new Padding(4);
            gpbPlatforms.Size = new Size(885, 96);
            gpbPlatforms.TabIndex = 9;
            gpbPlatforms.TabStop = false;
            gpbPlatforms.Text = "Platforms";
            // 
            // rdoXbox
            // 
            rdoXbox.AutoSize = true;
            rdoXbox.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoXbox.Location = new Point(764, 39);
            rdoXbox.Margin = new Padding(4);
            rdoXbox.Name = "rdoXbox";
            rdoXbox.Size = new Size(79, 28);
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
            rdoPlayStation.Location = new Point(371, 39);
            rdoPlayStation.Margin = new Padding(4);
            rdoPlayStation.Name = "rdoPlayStation";
            rdoPlayStation.Size = new Size(156, 28);
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
            rdoPC.Location = new Point(42, 39);
            rdoPC.Margin = new Padding(4);
            rdoPC.Name = "rdoPC";
            rdoPC.Size = new Size(57, 28);
            rdoPC.TabIndex = 0;
            rdoPC.TabStop = true;
            rdoPC.Text = "PC";
            rdoPC.UseVisualStyleBackColor = true;
            rdoPC.CheckedChanged += rdoPC_CheckedChanged;
            // 
            // OFD
            // 
            OFD.FileName = "OFD";
            // 
            // mnuStripSettings
            // 
            mnuStripSettings.ImageScalingSize = new Size(24, 24);
            mnuStripSettings.Items.AddRange(new ToolStripItem[] { mnuSettings, showLogsToolStripMenuItem, quitToolStripMenuItem });
            mnuStripSettings.Location = new Point(0, 0);
            mnuStripSettings.Name = "mnuStripSettings";
            mnuStripSettings.Size = new Size(905, 33);
            mnuStripSettings.TabIndex = 10;
            mnuStripSettings.Text = "menuStrip1";
            // 
            // mnuSettings
            // 
            mnuSettings.Name = "mnuSettings";
            mnuSettings.Size = new Size(92, 29);
            mnuSettings.Text = "Settings";
            mnuSettings.Click += mnuSettings_Click;
            // 
            // showLogsToolStripMenuItem
            // 
            showLogsToolStripMenuItem.Name = "showLogsToolStripMenuItem";
            showLogsToolStripMenuItem.Size = new Size(115, 29);
            showLogsToolStripMenuItem.Text = "Show Logs";
            showLogsToolStripMenuItem.Click += showLogsToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(62, 29);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 478);
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
            Controls.Add(mnuStripSettings);
            MainMenuStrip = mnuStripSettings;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "ICA 11 - Nay Aung Latt";
            Load += Form1_Load;
            gpbPlatforms.ResumeLayout(false);
            gpbPlatforms.PerformLayout();
            mnuStripSettings.ResumeLayout(false);
            mnuStripSettings.PerformLayout();
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
        private OpenFileDialog OFD;
        private MenuStrip mnuStripSettings;
        private ToolStripMenuItem mnuSettings;
        private ToolStripMenuItem showLogsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}