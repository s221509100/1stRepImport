﻿namespace Project_2
{
    partial class frmPropertyAgent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtaDate = new System.Windows.Forms.DateTimePicker();
            this.dgvPropertyAgent = new System.Windows.Forms.DataGridView();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtaDate);
            this.groupBox1.Controls.Add(this.dgvPropertyAgent);
            this.groupBox1.Controls.Add(this.btnBackTo);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbAgent);
            this.groupBox1.Controls.Add(this.cmbProperty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Agent Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtaDate
            // 
            this.dtaDate.Location = new System.Drawing.Point(192, 111);
            this.dtaDate.Name = "dtaDate";
            this.dtaDate.Size = new System.Drawing.Size(286, 26);
            this.dtaDate.TabIndex = 11;
            // 
            // dgvPropertyAgent
            // 
            this.dgvPropertyAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyAgent.Location = new System.Drawing.Point(26, 199);
            this.dgvPropertyAgent.Name = "dgvPropertyAgent";
            this.dgvPropertyAgent.Size = new System.Drawing.Size(701, 210);
            this.dgvPropertyAgent.TabIndex = 10;
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(470, 157);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(120, 36);
            this.btnBackTo.TabIndex = 9;
            this.btnBackTo.Text = "MENU";
            this.btnBackTo.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(328, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 36);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(181, 157);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(120, 36);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(192, 77);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(212, 28);
            this.cmbAgent.TabIndex = 5;
            // 
            // cmbProperty
            // 
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(192, 32);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(212, 28);
            this.cmbProperty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(607, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmPropertyAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPropertyAgent";
            this.Text = "frmPropertyAgent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPropertyAgent;
        private System.Windows.Forms.Button btnBackTo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.DateTimePicker dtaDate;
        private System.Windows.Forms.Button btnSearch;
    }
}