
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputIDTextBox1 = new System.Windows.Forms.TextBox();
            this.Tran1DataGridView = new System.Windows.Forms.DataGridView();
            this.DateUpdateButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran2DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tran1DataGridView)).BeginInit();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trường hợp 2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
    }
}