namespace WindowsFormsApp1
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_item = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.detail_item_name = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalItem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.detail_price = new System.Windows.Forms.ListBox();
            this.total_item_list = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_save.Location = new System.Drawing.Point(2578, 1299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(245, 83);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Simpan";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search_item
            // 
            this.search_item.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_item.Location = new System.Drawing.Point(78, 104);
            this.search_item.Multiline = true;
            this.search_item.Name = "search_item";
            this.search_item.Size = new System.Drawing.Size(1452, 74);
            this.search_item.TabIndex = 2;
            this.search_item.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_search.Location = new System.Drawing.Point(1544, 104);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(182, 74);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Cari";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.total_item_list);
            this.panel1.Controls.Add(this.detail_price);
            this.panel1.Controls.Add(this.detail_item_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1768, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 1041);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detail Pembelian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.totalPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.totalItem);
            this.panel2.Location = new System.Drawing.Point(1768, 1159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 103);
            this.panel2.TabIndex = 6;
            // 
            // detail_item_name
            // 
            this.detail_item_name.FormattingEnabled = true;
            this.detail_item_name.ItemHeight = 25;
            this.detail_item_name.Location = new System.Drawing.Point(10, 99);
            this.detail_item_name.Name = "detail_item_name";
            this.detail_item_name.Size = new System.Drawing.Size(425, 929);
            this.detail_item_name.TabIndex = 0;
            this.detail_item_name.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Item";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalItem
            // 
            this.totalItem.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItem.Location = new System.Drawing.Point(269, 15);
            this.totalItem.Multiline = true;
            this.totalItem.Name = "totalItem";
            this.totalItem.Size = new System.Drawing.Size(146, 74);
            this.totalItem.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1638, 1043);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Harga";
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(712, 15);
            this.totalPrice.Multiline = true;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(296, 74);
            this.totalPrice.TabIndex = 10;
            // 
            // detail_price
            // 
            this.detail_price.FormattingEnabled = true;
            this.detail_price.ItemHeight = 25;
            this.detail_price.Location = new System.Drawing.Point(698, 99);
            this.detail_price.Name = "detail_price";
            this.detail_price.Size = new System.Drawing.Size(310, 929);
            this.detail_price.TabIndex = 7;
            // 
            // total_item_list
            // 
            this.total_item_list.FormattingEnabled = true;
            this.total_item_list.ItemHeight = 25;
            this.total_item_list.Location = new System.Drawing.Point(457, 99);
            this.total_item_list.Name = "total_item_list";
            this.total_item_list.Size = new System.Drawing.Size(221, 929);
            this.total_item_list.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2895, 1605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.search_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_item;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox detail_item_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.ListBox detail_price;
        private System.Windows.Forms.ListBox total_item_list;
    }
}

