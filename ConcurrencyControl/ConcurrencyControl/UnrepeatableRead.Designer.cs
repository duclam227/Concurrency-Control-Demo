
namespace ConcurrencyControl
{
    partial class UnrepeatableRead
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangeToSellButton = new System.Windows.Forms.Button();
            this.Tran2InputHouseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountSellingHousesButton = new System.Windows.Forms.Button();
            this.Tran1DataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CountSellingHousesFixedButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trường hợp 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangeToSellButton);
            this.groupBox2.Controls.Add(this.Tran2InputHouseID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao tác 2";
            // 
            // ChangeToSellButton
            // 
            this.ChangeToSellButton.Location = new System.Drawing.Point(832, 21);
            this.ChangeToSellButton.Name = "ChangeToSellButton";
            this.ChangeToSellButton.Size = new System.Drawing.Size(100, 50);
            this.ChangeToSellButton.TabIndex = 8;
            this.ChangeToSellButton.Text = "Chuyển đổi";
            this.ChangeToSellButton.UseVisualStyleBackColor = true;
            this.ChangeToSellButton.Click += new System.EventHandler(this.ChangeToRentButton_Click);
            // 
            // Tran2InputHouseID
            // 
            this.Tran2InputHouseID.Location = new System.Drawing.Point(144, 43);
            this.Tran2InputHouseID.Name = "Tran2InputHouseID";
            this.Tran2InputHouseID.Size = new System.Drawing.Size(244, 22);
            this.Tran2InputHouseID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã nhà cần đổi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CountSellingHousesFixedButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.AmountLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CountSellingHousesButton);
            this.groupBox1.Controls.Add(this.Tran1DataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giao tác 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn ngày hết hạn:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(144, 457);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(75, 427);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(16, 17);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê số lượng nhà bán:";
            // 
            // CountSellingHousesButton
            // 
            this.CountSellingHousesButton.Location = new System.Drawing.Point(832, 440);
            this.CountSellingHousesButton.Name = "CountSellingHousesButton";
            this.CountSellingHousesButton.Size = new System.Drawing.Size(100, 50);
            this.CountSellingHousesButton.TabIndex = 1;
            this.CountSellingHousesButton.Text = "Thống kê";
            this.CountSellingHousesButton.UseVisualStyleBackColor = true;
            this.CountSellingHousesButton.Click += new System.EventHandler(this.CountSellingHousesButton_Click);
            // 
            // Tran1DataGridView
            // 
            this.Tran1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tran1DataGridView.Location = new System.Drawing.Point(6, 38);
            this.Tran1DataGridView.Name = "Tran1DataGridView";
            this.Tran1DataGridView.RowHeadersWidth = 51;
            this.Tran1DataGridView.RowTemplate.Height = 24;
            this.Tran1DataGridView.Size = new System.Drawing.Size(926, 385);
            this.Tran1DataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trường hợp 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trường hợp 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CountSellingHousesFixedButton
            // 
            this.CountSellingHousesFixedButton.Location = new System.Drawing.Point(726, 440);
            this.CountSellingHousesFixedButton.Name = "CountSellingHousesFixedButton";
            this.CountSellingHousesFixedButton.Size = new System.Drawing.Size(100, 50);
            this.CountSellingHousesFixedButton.TabIndex = 8;
            this.CountSellingHousesFixedButton.Text = "Thống kê (đã sửa lỗi)";
            this.CountSellingHousesFixedButton.UseVisualStyleBackColor = true;
            this.CountSellingHousesFixedButton.Click += new System.EventHandler(this.CountSellingHousesFixedButton_Click);
            // 
            // UnrepeatableRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "UnrepeatableRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UnrepeatableRead";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran1DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CountSellingHousesButton;
        private System.Windows.Forms.DataGridView Tran1DataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button ChangeToSellButton;
        private System.Windows.Forms.TextBox Tran2InputHouseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CountSellingHousesFixedButton;
    }
}