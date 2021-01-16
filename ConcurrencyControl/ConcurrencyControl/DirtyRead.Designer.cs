
namespace ConcurrencyControl
{
    partial class DirtyRead
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
            this.ShowContract = new System.Windows.Forms.Button();
            this.Tran2DataGridView = new System.Windows.Forms.DataGridView();
            this.ShowContract_Fixed = new System.Windows.Forms.Button();
            this.inputIDTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputIDTextBox1 = new System.Windows.Forms.TextBox();
            this.Tran1DataGridView = new System.Windows.Forms.DataGridView();
            this.DateUpdateButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DR_TH2_GT2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Update_DR_TH2_GT1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DR_TH2_GT1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran2DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran1DataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DR_TH2_GT2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DR_TH2_GT1)).BeginInit();
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
            this.groupBox2.Controls.Add(this.ShowContract);
            this.groupBox2.Controls.Add(this.Tran2DataGridView);
            this.groupBox2.Controls.Add(this.ShowContract_Fixed);
            this.groupBox2.Controls.Add(this.inputIDTextBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 212);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao tác 2";
            // 
            // ShowContract
            // 
            this.ShowContract.Location = new System.Drawing.Point(646, 167);
            this.ShowContract.Name = "ShowContract";
            this.ShowContract.Size = new System.Drawing.Size(140, 39);
            this.ShowContract.TabIndex = 9;
            this.ShowContract.Text = "Xem";
            this.ShowContract.UseVisualStyleBackColor = true;
            this.ShowContract.Click += new System.EventHandler(this.ShowContract_Click);
            // 
            // Tran2DataGridView
            // 
            this.Tran2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tran2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tran2DataGridView.Location = new System.Drawing.Point(9, 54);
            this.Tran2DataGridView.Name = "Tran2DataGridView";
            this.Tran2DataGridView.RowHeadersWidth = 51;
            this.Tran2DataGridView.RowTemplate.Height = 24;
            this.Tran2DataGridView.Size = new System.Drawing.Size(923, 107);
            this.Tran2DataGridView.TabIndex = 7;
            // 
            // ShowContract_Fixed
            // 
            this.ShowContract_Fixed.Location = new System.Drawing.Point(792, 167);
            this.ShowContract_Fixed.Name = "ShowContract_Fixed";
            this.ShowContract_Fixed.Size = new System.Drawing.Size(140, 39);
            this.ShowContract_Fixed.TabIndex = 7;
            this.ShowContract_Fixed.Text = "Xem (đã sửa lỗi)";
            this.ShowContract_Fixed.UseVisualStyleBackColor = true;
            this.ShowContract_Fixed.Click += new System.EventHandler(this.ShowContractFixed_Click);
            // 
            // inputIDTextBox2
            // 
            this.inputIDTextBox2.Location = new System.Drawing.Point(206, 26);
            this.inputIDTextBox2.Name = "inputIDTextBox2";
            this.inputIDTextBox2.Size = new System.Drawing.Size(200, 22);
            this.inputIDTextBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn mã hợp đồng muốn xem:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputIDTextBox1);
            this.groupBox1.Controls.Add(this.Tran1DataGridView);
            this.groupBox1.Controls.Add(this.DateUpdateButton);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 370);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giao tác 1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(646, 301);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(140, 52);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Làm mới";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn ngày hết hạn mới:";
            // 
            // inputIDTextBox1
            // 
            this.inputIDTextBox1.Location = new System.Drawing.Point(206, 307);
            this.inputIDTextBox1.Name = "inputIDTextBox1";
            this.inputIDTextBox1.Size = new System.Drawing.Size(200, 22);
            this.inputIDTextBox1.TabIndex = 5;
            // 
            // Tran1DataGridView
            // 
            this.Tran1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tran1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tran1DataGridView.Location = new System.Drawing.Point(9, 21);
            this.Tran1DataGridView.Name = "Tran1DataGridView";
            this.Tran1DataGridView.RowHeadersWidth = 51;
            this.Tran1DataGridView.RowTemplate.Height = 24;
            this.Tran1DataGridView.Size = new System.Drawing.Size(923, 274);
            this.Tran1DataGridView.TabIndex = 0;
            // 
            // DateUpdateButton
            // 
            this.DateUpdateButton.Location = new System.Drawing.Point(792, 301);
            this.DateUpdateButton.Name = "DateUpdateButton";
            this.DateUpdateButton.Size = new System.Drawing.Size(140, 52);
            this.DateUpdateButton.TabIndex = 1;
            this.DateUpdateButton.Text = "Thay đổi";
            this.DateUpdateButton.UseVisualStyleBackColor = true;
            this.DateUpdateButton.Click += new System.EventHandler(this.DateUpdateButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(206, 336);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn mã hợp đồng muốn đổi:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trường hợp 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.DR_TH2_GT2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 332);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(937, 267);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giao tác 2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(605, 213);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Xem (đã sửa lỗi)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 213);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DR_TH2_GT2
            // 
            this.DR_TH2_GT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DR_TH2_GT2.Location = new System.Drawing.Point(9, 56);
            this.DR_TH2_GT2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DR_TH2_GT2.Name = "DR_TH2_GT2";
            this.DR_TH2_GT2.RowHeadersWidth = 62;
            this.DR_TH2_GT2.RowTemplate.Height = 28;
            this.DR_TH2_GT2.Size = new System.Drawing.Size(922, 153);
            this.DR_TH2_GT2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn mã nhà muốn xem:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Update_DR_TH2_GT1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.DR_TH2_GT1);
            this.groupBox3.Location = new System.Drawing.Point(6, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(937, 325);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giao tác 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem danh sách nhà";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập ngày hết hạn mới:";
            // 
            // Update_DR_TH2_GT1
            // 
            this.Update_DR_TH2_GT1.Location = new System.Drawing.Point(605, 260);
            this.Update_DR_TH2_GT1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_DR_TH2_GT1.Name = "Update_DR_TH2_GT1";
            this.Update_DR_TH2_GT1.Size = new System.Drawing.Size(160, 50);
            this.Update_DR_TH2_GT1.TabIndex = 2;
            this.Update_DR_TH2_GT1.Text = "Thay đổi";
            this.Update_DR_TH2_GT1.UseVisualStyleBackColor = true;
            this.Update_DR_TH2_GT1.Click += new System.EventHandler(this.Update_DR_TH2_GT1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn mã nhà cần gia hạn:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 283);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // DR_TH2_GT1
            // 
            this.DR_TH2_GT1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DR_TH2_GT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DR_TH2_GT1.Location = new System.Drawing.Point(9, 19);
            this.DR_TH2_GT1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DR_TH2_GT1.Name = "DR_TH2_GT1";
            this.DR_TH2_GT1.RowHeadersWidth = 62;
            this.DR_TH2_GT1.RowTemplate.Height = 28;
            this.DR_TH2_GT1.Size = new System.Drawing.Size(922, 230);
            this.DR_TH2_GT1.TabIndex = 0;
            // 
            // DirtyRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "DirtyRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirtyRead";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran2DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran1DataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DR_TH2_GT2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DR_TH2_GT1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DateUpdateButton;
        private System.Windows.Forms.DataGridView Tran1DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputIDTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Tran2DataGridView;
        private System.Windows.Forms.Button ShowContract_Fixed;
        private System.Windows.Forms.TextBox inputIDTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowContract;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DR_TH2_GT2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Update_DR_TH2_GT1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DR_TH2_GT1;
    }
}