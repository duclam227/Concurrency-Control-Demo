
namespace ConcurrencyControl
{
    partial class LostUpdate
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HouseIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.RichTextBox();
            this.AddWatchButton = new System.Windows.Forms.Button();
            this.HouseIDToShowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HouseDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.AddWatchFixedButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HouseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trường hợp 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trường hợp 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddWatchFixedButton);
            this.groupBox1.Controls.Add(this.AddWatchButton);
            this.groupBox1.Controls.Add(this.CommentTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.CustomerIDTextBox);
            this.groupBox1.Controls.Add(this.HouseIDTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm vào bảng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.HouseDataGridView);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.HouseIDToShowTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 408);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem bảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày xem:";
            // 
            // HouseIDTextBox
            // 
            this.HouseIDTextBox.Location = new System.Drawing.Point(122, 25);
            this.HouseIDTextBox.Name = "HouseIDTextBox";
            this.HouseIDTextBox.Size = new System.Drawing.Size(236, 22);
            this.HouseIDTextBox.TabIndex = 3;
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Enabled = false;
            this.CustomerIDTextBox.Location = new System.Drawing.Point(122, 54);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(236, 22);
            this.CustomerIDTextBox.TabIndex = 4;
            this.CustomerIDTextBox.Text = "02";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(122, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhận xét:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(467, 25);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(465, 78);
            this.CommentTextBox.TabIndex = 8;
            this.CommentTextBox.Text = "";
            // 
            // AddWatchButton
            // 
            this.AddWatchButton.Location = new System.Drawing.Point(812, 109);
            this.AddWatchButton.Name = "AddWatchButton";
            this.AddWatchButton.Size = new System.Drawing.Size(120, 59);
            this.AddWatchButton.TabIndex = 9;
            this.AddWatchButton.Text = "Thêm lượt xem";
            this.AddWatchButton.UseVisualStyleBackColor = true;
            this.AddWatchButton.Click += new System.EventHandler(this.AddWatchButton_Click);
            // 
            // HouseIDToShowTextBox
            // 
            this.HouseIDToShowTextBox.Location = new System.Drawing.Point(122, 21);
            this.HouseIDToShowTextBox.Name = "HouseIDToShowTextBox";
            this.HouseIDToShowTextBox.Size = new System.Drawing.Size(236, 22);
            this.HouseIDToShowTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã nhà:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xem thông tin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HouseDataGridView
            // 
            this.HouseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HouseDataGridView.Location = new System.Drawing.Point(9, 60);
            this.HouseDataGridView.Name = "HouseDataGridView";
            this.HouseDataGridView.RowHeadersWidth = 51;
            this.HouseDataGridView.RowTemplate.Height = 24;
            this.HouseDataGridView.Size = new System.Drawing.Size(923, 342);
            this.HouseDataGridView.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddWatchFixedButton
            // 
            this.AddWatchFixedButton.Location = new System.Drawing.Point(686, 109);
            this.AddWatchFixedButton.Name = "AddWatchFixedButton";
            this.AddWatchFixedButton.Size = new System.Drawing.Size(120, 59);
            this.AddWatchFixedButton.TabIndex = 10;
            this.AddWatchFixedButton.Text = "Thêm lượt xem (đã sửa lỗi)";
            this.AddWatchFixedButton.UseVisualStyleBackColor = true;
            this.AddWatchFixedButton.Click += new System.EventHandler(this.AddWatchFixedButton_Click);
            // 
            // LostUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "LostUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LostUpdate";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HouseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox CommentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox HouseIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddWatchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox HouseIDToShowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView HouseDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddWatchFixedButton;
    }
}