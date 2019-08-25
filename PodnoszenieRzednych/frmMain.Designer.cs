namespace PodnoszenieRzednych
{
    partial class frmMain
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
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gboxSelect = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnPrecise = new System.Windows.Forms.RadioButton();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.stsMain.SuspendLayout();
            this.gboxSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "DXF|*.dxf";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(13, 13);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(267, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "Wybierz plik...";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 40);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Otwórz";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(205, 175);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabel});
            this.stsMain.Location = new System.Drawing.Point(0, 213);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(292, 22);
            this.stsMain.TabIndex = 3;
            // 
            // stsLabel
            // 
            this.stsLabel.Name = "stsLabel";
            this.stsLabel.Size = new System.Drawing.Size(49, 17);
            this.stsLabel.Text = "stsLabel";
            // 
            // gboxSelect
            // 
            this.gboxSelect.Controls.Add(this.rbtnPrecise);
            this.gboxSelect.Controls.Add(this.rbtnAll);
            this.gboxSelect.Location = new System.Drawing.Point(13, 69);
            this.gboxSelect.Name = "gboxSelect";
            this.gboxSelect.Size = new System.Drawing.Size(267, 70);
            this.gboxSelect.TabIndex = 4;
            this.gboxSelect.TabStop = false;
            this.gboxSelect.Text = "Wersja";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(7, 20);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(144, 17);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Podnoś wszystkie rzędne";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnPrecise
            // 
            this.rbtnPrecise.AutoSize = true;
            this.rbtnPrecise.Location = new System.Drawing.Point(7, 44);
            this.rbtnPrecise.Name = "rbtnPrecise";
            this.rbtnPrecise.Size = new System.Drawing.Size(195, 17);
            this.rbtnPrecise.TabIndex = 1;
            this.rbtnPrecise.TabStop = true;
            this.rbtnPrecise.Text = "Podnoś tylko rzędne z precyzją 0.00";
            this.rbtnPrecise.UseVisualStyleBackColor = true;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(13, 146);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(75, 20);
            this.txtLevel.TabIndex = 5;
            this.txtLevel.Text = "0.00";
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(91, 150);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(137, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Wartość przesunięcia w cm";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 235);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.gboxSelect);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFileName);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Podnoszenie Rzednych";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.gboxSelect.ResumeLayout(false);
            this.gboxSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stsLabel;
        private System.Windows.Forms.GroupBox gboxSelect;
        private System.Windows.Forms.RadioButton rbtnPrecise;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}

