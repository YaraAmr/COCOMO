namespace MetricsProject
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SizeOfProject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Mode = new System.Windows.Forms.Label();
            this.CalculateEffort = new System.Windows.Forms.Button();
            this.CalculateTDEV = new System.Windows.Forms.Button();
            this.CalculateActualEffort = new System.Windows.Forms.Button();
            this.ResultEffort = new System.Windows.Forms.TextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ExtraHighRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.VeryHighRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.HighRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.NominalRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.LowRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.VeryLowRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.CostDrivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.EAFvalue = new MetroFramework.Controls.MetroLabel();
            this.ResultActualEffort = new System.Windows.Forms.TextBox();
            this.ResultTDEV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeOfProject
            // 
            this.SizeOfProject.AutoSize = true;
            this.SizeOfProject.Location = new System.Drawing.Point(29, 79);
            this.SizeOfProject.Name = "SizeOfProject";
            this.SizeOfProject.Size = new System.Drawing.Size(102, 17);
            this.SizeOfProject.TabIndex = 0;
            this.SizeOfProject.Text = "Size Of Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(177, 79);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(212, 22);
            this.Size.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Basic ",
            "Intermediate ",
            "Detailed "});
            this.comboBox1.Location = new System.Drawing.Point(177, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Location = new System.Drawing.Point(29, 119);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(46, 17);
            this.Mode.TabIndex = 4;
            this.Mode.Text = "Model";
            // 
            // CalculateEffort
            // 
            this.CalculateEffort.Location = new System.Drawing.Point(598, 178);
            this.CalculateEffort.Name = "CalculateEffort";
            this.CalculateEffort.Size = new System.Drawing.Size(165, 30);
            this.CalculateEffort.TabIndex = 5;
            this.CalculateEffort.Text = "Calculate Effort";
            this.CalculateEffort.UseVisualStyleBackColor = true;
            this.CalculateEffort.Click += new System.EventHandler(this.CalculateEffort_Click);
            // 
            // CalculateTDEV
            // 
            this.CalculateTDEV.Location = new System.Drawing.Point(598, 123);
            this.CalculateTDEV.Name = "CalculateTDEV";
            this.CalculateTDEV.Size = new System.Drawing.Size(165, 30);
            this.CalculateTDEV.TabIndex = 6;
            this.CalculateTDEV.Text = "Calculate TDEV";
            this.CalculateTDEV.UseVisualStyleBackColor = true;
            this.CalculateTDEV.Click += new System.EventHandler(this.CalculateTDEV_Click);
            // 
            // CalculateActualEffort
            // 
            this.CalculateActualEffort.Location = new System.Drawing.Point(598, 66);
            this.CalculateActualEffort.Name = "CalculateActualEffort";
            this.CalculateActualEffort.Size = new System.Drawing.Size(165, 30);
            this.CalculateActualEffort.TabIndex = 7;
            this.CalculateActualEffort.Text = "Calculate Actual Effort";
            this.CalculateActualEffort.UseVisualStyleBackColor = true;
            this.CalculateActualEffort.Click += new System.EventHandler(this.CalculateActualEffort_Click);
            // 
            // ResultEffort
            // 
            this.ResultEffort.Location = new System.Drawing.Point(915, 186);
            this.ResultEffort.Name = "ResultEffort";
            this.ResultEffort.Size = new System.Drawing.Size(134, 22);
            this.ResultEffort.TabIndex = 8;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(31, 162);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(386, 30);
            this.metroComboBox1.TabIndex = 9;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.ExtraHighRadioButton);
            this.groupBox1.Controls.Add(this.VeryHighRadioButton);
            this.groupBox1.Controls.Add(this.HighRadioButton);
            this.groupBox1.Controls.Add(this.NominalRadioButton);
            this.groupBox1.Controls.Add(this.LowRadioButton);
            this.groupBox1.Controls.Add(this.VeryLowRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(31, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 137);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ratings";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(205, 108);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Add Item";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(397, 33);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 20);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Extra High";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(305, 33);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 20);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Very High";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(242, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "High";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(158, 34);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Nominal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(100, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Low";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Very Low";
            // 
            // ExtraHighRadioButton
            // 
            this.ExtraHighRadioButton.AutoSize = true;
            this.ExtraHighRadioButton.Location = new System.Drawing.Point(418, 59);
            this.ExtraHighRadioButton.Name = "ExtraHighRadioButton";
            this.ExtraHighRadioButton.Size = new System.Drawing.Size(41, 17);
            this.ExtraHighRadioButton.TabIndex = 5;
            this.ExtraHighRadioButton.Text = "2.5";
            this.ExtraHighRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExtraHighRadioButton.UseSelectable = true;
            // 
            // VeryHighRadioButton
            // 
            this.VeryHighRadioButton.AutoSize = true;
            this.VeryHighRadioButton.Location = new System.Drawing.Point(329, 59);
            this.VeryHighRadioButton.Name = "VeryHighRadioButton";
            this.VeryHighRadioButton.Size = new System.Drawing.Size(41, 17);
            this.VeryHighRadioButton.TabIndex = 4;
            this.VeryHighRadioButton.Text = "2.5";
            this.VeryHighRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VeryHighRadioButton.UseSelectable = true;
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(240, 60);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(41, 17);
            this.HighRadioButton.TabIndex = 3;
            this.HighRadioButton.Text = "2.5";
            this.HighRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HighRadioButton.UseSelectable = true;
            // 
            // NominalRadioButton
            // 
            this.NominalRadioButton.AutoSize = true;
            this.NominalRadioButton.Location = new System.Drawing.Point(169, 60);
            this.NominalRadioButton.Name = "NominalRadioButton";
            this.NominalRadioButton.Size = new System.Drawing.Size(41, 17);
            this.NominalRadioButton.TabIndex = 2;
            this.NominalRadioButton.Text = "2.5";
            this.NominalRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NominalRadioButton.UseSelectable = true;
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(100, 60);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(41, 17);
            this.LowRadioButton.TabIndex = 1;
            this.LowRadioButton.Text = "2.5";
            this.LowRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LowRadioButton.UseSelectable = true;
            // 
            // VeryLowRadioButton
            // 
            this.VeryLowRadioButton.AutoSize = true;
            this.VeryLowRadioButton.Location = new System.Drawing.Point(27, 60);
            this.VeryLowRadioButton.Name = "VeryLowRadioButton";
            this.VeryLowRadioButton.Size = new System.Drawing.Size(41, 17);
            this.VeryLowRadioButton.TabIndex = 0;
            this.VeryLowRadioButton.Text = "2.5";
            this.VeryLowRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VeryLowRadioButton.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostDrivers,
            this.Value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(32, 384);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(489, 165);
            this.metroGrid1.TabIndex = 11;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // CostDrivers
            // 
            this.CostDrivers.HeaderText = "Cost Drivers";
            this.CostDrivers.MinimumWidth = 6;
            this.CostDrivers.Name = "CostDrivers";
            this.CostDrivers.ReadOnly = true;
            this.CostDrivers.Width = 125;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 125;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(598, 245);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 20);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "EAF =";
            // 
            // EAFvalue
            // 
            this.EAFvalue.AutoSize = true;
            this.EAFvalue.Location = new System.Drawing.Point(915, 246);
            this.EAFvalue.Name = "EAFvalue";
            this.EAFvalue.Size = new System.Drawing.Size(87, 20);
            this.EAFvalue.TabIndex = 13;
            this.EAFvalue.Text = "metroLabel8";
            this.EAFvalue.Visible = false;
            // 
            // ResultActualEffort
            // 
            this.ResultActualEffort.Location = new System.Drawing.Point(915, 70);
            this.ResultActualEffort.Name = "ResultActualEffort";
            this.ResultActualEffort.Size = new System.Drawing.Size(134, 22);
            this.ResultActualEffort.TabIndex = 14;
            // 
            // ResultTDEV
            // 
            this.ResultTDEV.Location = new System.Drawing.Point(915, 131);
            this.ResultTDEV.Name = "ResultTDEV";
            this.ResultTDEV.Size = new System.Drawing.Size(134, 22);
            this.ResultTDEV.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 593);
            this.Controls.Add(this.ResultTDEV);
            this.Controls.Add(this.ResultActualEffort);
            this.Controls.Add(this.EAFvalue);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.ResultEffort);
            this.Controls.Add(this.CalculateActualEffort);
            this.Controls.Add(this.CalculateTDEV);
            this.Controls.Add(this.CalculateEffort);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeOfProject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SizeOfProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Button CalculateEffort;
        private System.Windows.Forms.Button CalculateTDEV;
        private System.Windows.Forms.Button CalculateActualEffort;
        private System.Windows.Forms.TextBox ResultEffort;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton LowRadioButton;
        private MetroFramework.Controls.MetroRadioButton VeryLowRadioButton;
        private MetroFramework.Controls.MetroRadioButton VeryHighRadioButton;
        private MetroFramework.Controls.MetroRadioButton HighRadioButton;
        private MetroFramework.Controls.MetroRadioButton NominalRadioButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton ExtraHighRadioButton;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel EAFvalue;
        private System.Windows.Forms.TextBox ResultActualEffort;
        private System.Windows.Forms.TextBox ResultTDEV;
    }
}

