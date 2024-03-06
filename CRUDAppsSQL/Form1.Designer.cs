namespace CRUDAppsSQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegNo_tx = new System.Windows.Forms.TextBox();
            this.Name_tx = new System.Windows.Forms.TextBox();
            this.Address_tx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Update_tx = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_tx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(145, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(147, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(147, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RegNo_tx
            // 
            this.RegNo_tx.Location = new System.Drawing.Point(417, 413);
            this.RegNo_tx.Name = "RegNo_tx";
            this.RegNo_tx.Size = new System.Drawing.Size(232, 37);
            this.RegNo_tx.TabIndex = 3;
            this.RegNo_tx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name_tx
            // 
            this.Name_tx.Location = new System.Drawing.Point(417, 459);
            this.Name_tx.Name = "Name_tx";
            this.Name_tx.Size = new System.Drawing.Size(232, 37);
            this.Name_tx.TabIndex = 4;
            // 
            // Address_tx
            // 
            this.Address_tx.Location = new System.Drawing.Point(417, 502);
            this.Address_tx.Name = "Address_tx";
            this.Address_tx.Size = new System.Drawing.Size(232, 37);
            this.Address_tx.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewGird_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(620, 269);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Update_tx
            // 
            this.Update_tx.Location = new System.Drawing.Point(451, 580);
            this.Update_tx.Name = "Update_tx";
            this.Update_tx.Size = new System.Drawing.Size(125, 70);
            this.Update_tx.TabIndex = 9;
            this.Update_tx.Text = "Update";
            this.Update_tx.UseVisualStyleBackColor = true;
            this.Update_tx.Click += new System.EventHandler(this.Update_tx_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.Location = new System.Drawing.Point(620, 580);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(131, 70);
            this.delete_bt.TabIndex = 10;
            this.delete_bt.Text = "Delete";
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Portal";
            // 
            // exit_tx
            // 
            this.exit_tx.Location = new System.Drawing.Point(644, 57);
            this.exit_tx.Name = "exit_tx";
            this.exit_tx.Size = new System.Drawing.Size(110, 31);
            this.exit_tx.TabIndex = 12;
            this.exit_tx.Text = "Exit";
            this.exit_tx.UseVisualStyleBackColor = true;
            this.exit_tx.Click += new System.EventHandler(this.exit_tx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 712);
            this.Controls.Add(this.exit_tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.Update_tx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Address_tx);
            this.Controls.Add(this.Name_tx);
            this.Controls.Add(this.RegNo_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Employee Portal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegNo_tx;
        private System.Windows.Forms.TextBox Name_tx;
        private System.Windows.Forms.TextBox Address_tx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Update_tx;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit_tx;
    }
}

