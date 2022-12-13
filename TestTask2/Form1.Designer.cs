namespace TestTask2
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
            this.LocationsList = new System.Windows.Forms.ComboBox();
            this.GetAvailableCar = new System.Windows.Forms.Button();
            this.AvailableCarList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.rentButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.confirmNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationsList
            // 
            this.LocationsList.FormattingEnabled = true;
            this.LocationsList.Location = new System.Drawing.Point(12, 12);
            this.LocationsList.Name = "LocationsList";
            this.LocationsList.Size = new System.Drawing.Size(325, 23);
            this.LocationsList.TabIndex = 0;
            // 
            // GetAvailableCar
            // 
            this.GetAvailableCar.Location = new System.Drawing.Point(12, 41);
            this.GetAvailableCar.Name = "GetAvailableCar";
            this.GetAvailableCar.Size = new System.Drawing.Size(131, 35);
            this.GetAvailableCar.TabIndex = 1;
            this.GetAvailableCar.Text = "Show available car";
            this.GetAvailableCar.UseVisualStyleBackColor = true;
            this.GetAvailableCar.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // AvailableCarList
            // 
            this.AvailableCarList.FormattingEnabled = true;
            this.AvailableCarList.ItemHeight = 15;
            this.AvailableCarList.Location = new System.Drawing.Point(12, 82);
            this.AvailableCarList.Name = "AvailableCarList";
            this.AvailableCarList.Size = new System.Drawing.Size(210, 229);
            this.AvailableCarList.TabIndex = 2;
            this.AvailableCarList.SelectedIndexChanged += new System.EventHandler(this.AvailableCarList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(353, 82);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(19, 15);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Location = new System.Drawing.Point(353, 106);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(19, 15);
            this.modelNameLabel.TabIndex = 5;
            this.modelNameLabel.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendor:";
            // 
            // vendorNameLabel
            // 
            this.vendorNameLabel.AutoSize = true;
            this.vendorNameLabel.Location = new System.Drawing.Point(353, 131);
            this.vendorNameLabel.Name = "vendorNameLabel";
            this.vendorNameLabel.Size = new System.Drawing.Size(19, 15);
            this.vendorNameLabel.TabIndex = 5;
            this.vendorNameLabel.Text = "    ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(353, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 208);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(601, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 208);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(419, 363);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname:";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(419, 392);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(176, 23);
            this.surnameText.TabIndex = 8;
            // 
            // rentButton
            // 
            this.rentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rentButton.Location = new System.Drawing.Point(419, 421);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(107, 23);
            this.rentButton.TabIndex = 9;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(419, 447);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(133, 15);
            this.Label.TabIndex = 4;
            this.Label.Text = "Confirmation number: ";
            // 
            // confirmNumberLabel
            // 
            this.confirmNumberLabel.AutoSize = true;
            this.confirmNumberLabel.Location = new System.Drawing.Point(558, 447);
            this.confirmNumberLabel.Name = "confirmNumberLabel";
            this.confirmNumberLabel.Size = new System.Drawing.Size(25, 15);
            this.confirmNumberLabel.TabIndex = 4;
            this.confirmNumberLabel.Text = "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 629);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vendorNameLabel);
            this.Controls.Add(this.modelNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.confirmNumberLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableCarList);
            this.Controls.Add(this.GetAvailableCar);
            this.Controls.Add(this.LocationsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox LocationsList;
        private Button GetAvailableCar;
        private ListBox AvailableCarList;
        private Label label1;
        private Label amountLabel;
        private Label label2;
        private Label modelNameLabel;
        private Label label3;
        private Label vendorNameLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox nameTextBox;
        private Label label4;
        private Label label5;
        private TextBox surnameText;
        private Button rentButton;
        private Label Label;
        private Label confirmNumberLabel;
    }
}