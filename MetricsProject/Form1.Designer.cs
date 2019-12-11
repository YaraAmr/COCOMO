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
            this.SuspendLayout();
            // 
            // SizeOfProject
            // 
            this.SizeOfProject.AutoSize = true;
            this.SizeOfProject.Location = new System.Drawing.Point(29, 53);
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
            this.Size.Location = new System.Drawing.Point(177, 53);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(100, 22);
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
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Location = new System.Drawing.Point(29, 119);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(43, 17);
            this.Mode.TabIndex = 4;
            this.Mode.Text = "Mode";
            // 
            // CalculateEffort
            // 
            this.CalculateEffort.Location = new System.Drawing.Point(202, 176);
            this.CalculateEffort.Name = "CalculateEffort";
            this.CalculateEffort.Size = new System.Drawing.Size(165, 30);
            this.CalculateEffort.TabIndex = 5;
            this.CalculateEffort.Text = "Calculate Effort";
            this.CalculateEffort.UseVisualStyleBackColor = true;
            this.CalculateEffort.Click += new System.EventHandler(this.CalculateEffort_Click);
            // 
            // CalculateTDEV
            // 
            this.CalculateTDEV.Location = new System.Drawing.Point(202, 222);
            this.CalculateTDEV.Name = "CalculateTDEV";
            this.CalculateTDEV.Size = new System.Drawing.Size(165, 30);
            this.CalculateTDEV.TabIndex = 6;
            this.CalculateTDEV.Text = "Calculate TDEV";
            this.CalculateTDEV.UseVisualStyleBackColor = true;
            this.CalculateTDEV.Click += new System.EventHandler(this.CalculateTDEV_Click);
            // 
            // CalculateActualEffort
            // 
            this.CalculateActualEffort.Location = new System.Drawing.Point(202, 267);
            this.CalculateActualEffort.Name = "CalculateActualEffort";
            this.CalculateActualEffort.Size = new System.Drawing.Size(165, 30);
            this.CalculateActualEffort.TabIndex = 7;
            this.CalculateActualEffort.Text = "Calculate Actual Effort";
            this.CalculateActualEffort.UseVisualStyleBackColor = true;
            this.CalculateActualEffort.Click += new System.EventHandler(this.CalculateActualEffort_Click);
            // 
            // ResultEffort
            // 
            this.ResultEffort.Location = new System.Drawing.Point(432, 180);
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
            this.metroComboBox1.Location = new System.Drawing.Point(23, 317);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(378, 30);
            this.metroComboBox1.TabIndex = 9;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

