namespace k_means
{
    partial class MainForm
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Status = new Label();
            label4 = new Label();
            WCSSLabel = new Label();
            label3 = new Label();
            ClustersCountLabel = new Label();
            label2 = new Label();
            PointsCountLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            RunButton = new Button();
            RunStepButton = new Button();
            ClearClustersButton = new Button();
            ClearPointsButton = new Button();
            label6 = new Label();
            label5 = new Label();
            SetClustersAutomatically = new Button();
            SetPoinstAutomaticallyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1284, 994);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(WCSSLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ClustersCountLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PointsCountLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1597, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 993);
            panel1.TabIndex = 1;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(42, 124);
            Status.Name = "Status";
            Status.Size = new Size(171, 15);
            Status.TabIndex = 9;
            Status.Text = "Ожидание запуска алгоритма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 124);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Шаг - ";
            // 
            // WCSSLabel
            // 
            WCSSLabel.AutoSize = true;
            WCSSLabel.Location = new Point(63, 94);
            WCSSLabel.Name = "WCSSLabel";
            WCSSLabel.Size = new Size(13, 15);
            WCSSLabel.TabIndex = 7;
            WCSSLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 94);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "WCSS = ";
            // 
            // ClustersCountLabel
            // 
            ClustersCountLabel.AutoSize = true;
            ClustersCountLabel.Location = new Point(97, 63);
            ClustersCountLabel.Name = "ClustersCountLabel";
            ClustersCountLabel.Size = new Size(13, 15);
            ClustersCountLabel.TabIndex = 5;
            ClustersCountLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 63);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "N кластеров =";
            // 
            // PointsCountLabel
            // 
            PointsCountLabel.AutoSize = true;
            PointsCountLabel.Location = new Point(72, 33);
            PointsCountLabel.Name = "PointsCountLabel";
            PointsCountLabel.Size = new Size(13, 15);
            PointsCountLabel.TabIndex = 3;
            PointsCountLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "N точек =";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(RunButton);
            panel2.Controls.Add(RunStepButton);
            panel2.Controls.Add(ClearClustersButton);
            panel2.Controls.Add(ClearPointsButton);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(SetClustersAutomatically);
            panel2.Controls.Add(SetPoinstAutomaticallyButton);
            panel2.Location = new Point(1302, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 993);
            panel2.TabIndex = 0;
            // 
            // RunButton
            // 
            RunButton.Location = new Point(38, 460);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(207, 55);
            RunButton.TabIndex = 9;
            RunButton.Text = "Выполнить без остановок";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // RunStepButton
            // 
            RunStepButton.Location = new Point(38, 389);
            RunStepButton.Name = "RunStepButton";
            RunStepButton.Size = new Size(207, 55);
            RunStepButton.TabIndex = 8;
            RunStepButton.Text = "Выполнить шаг алгоритма";
            RunStepButton.UseVisualStyleBackColor = true;
            RunStepButton.Click += RunStepButton_Click;
            // 
            // ClearClustersButton
            // 
            ClearClustersButton.Location = new Point(38, 294);
            ClearClustersButton.Name = "ClearClustersButton";
            ClearClustersButton.Size = new Size(207, 55);
            ClearClustersButton.TabIndex = 7;
            ClearClustersButton.Text = "Удалить все кластеры";
            ClearClustersButton.UseVisualStyleBackColor = true;
            ClearClustersButton.Click += ClearClustersButton_Click;
            // 
            // ClearPointsButton
            // 
            ClearPointsButton.Location = new Point(39, 222);
            ClearPointsButton.Name = "ClearPointsButton";
            ClearPointsButton.Size = new Size(207, 55);
            ClearPointsButton.TabIndex = 6;
            ClearPointsButton.Text = "Удалить все точки";
            ClearPointsButton.UseVisualStyleBackColor = true;
            ClearPointsButton.Click += ClearPointsButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 190);
            label6.Name = "label6";
            label6.Size = new Size(146, 15);
            label6.TabIndex = 5;
            label6.Text = "ПКМ - поставить кластер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 166);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 4;
            label5.Text = "ЛКМ - поставить точку";
            // 
            // SetClustersAutomatically
            // 
            SetClustersAutomatically.Location = new Point(38, 94);
            SetClustersAutomatically.Name = "SetClustersAutomatically";
            SetClustersAutomatically.Size = new Size(207, 55);
            SetClustersAutomatically.TabIndex = 3;
            SetClustersAutomatically.Text = "Выставить кластеры автоматически";
            SetClustersAutomatically.UseVisualStyleBackColor = true;
            SetClustersAutomatically.Click += SetClustersAutomatically_Click;
            // 
            // SetPoinstAutomaticallyButton
            // 
            SetPoinstAutomaticallyButton.Location = new Point(38, 23);
            SetPoinstAutomaticallyButton.Name = "SetPoinstAutomaticallyButton";
            SetPoinstAutomaticallyButton.Size = new Size(207, 55);
            SetPoinstAutomaticallyButton.TabIndex = 2;
            SetPoinstAutomaticallyButton.Text = "Выставить точки автоматически";
            SetPoinstAutomaticallyButton.UseVisualStyleBackColor = true;
            SetPoinstAutomaticallyButton.Click += SetPoinstAutomaticallyButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1013);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "k-means by Evstratov Aleksei";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label Status;
        private Label label4;
        private Label WCSSLabel;
        private Label label3;
        private Label ClustersCountLabel;
        private Label label2;
        private Label PointsCountLabel;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button SetClustersAutomatically;
        private Button SetPoinstAutomaticallyButton;
        private Button RunButton;
        private Button RunStepButton;
        private Button ClearClustersButton;
        private Button ClearPointsButton;
    }
}