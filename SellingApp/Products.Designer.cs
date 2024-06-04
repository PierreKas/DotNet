namespace SellingApp
{
    partial class Products
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
            this.prodRegButt = new System.Windows.Forms.Button();
            this.prodCanButt = new System.Windows.Forms.Button();
            this.prodDelButt = new System.Windows.Forms.Button();
            this.prodUpdButt = new System.Windows.Forms.Button();
            this.prodSearchButt = new System.Windows.Forms.Button();
            this.prodSearchText = new System.Windows.Forms.TextBox();
            this.prodExpDate = new System.Windows.Forms.DateTimePicker();
            this.prodNameText = new System.Windows.Forms.TextBox();
            this.prodUPtxt = new System.Windows.Forms.TextBox();
            this.prodQuText = new System.Windows.Forms.TextBox();
            this.prodIdText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productsInfo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.printReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.prodRegButt);
            this.groupBox1.Controls.Add(this.prodCanButt);
            this.groupBox1.Controls.Add(this.prodDelButt);
            this.groupBox1.Controls.Add(this.prodUpdButt);
            this.groupBox1.Controls.Add(this.prodSearchButt);
            this.groupBox1.Controls.Add(this.prodSearchText);
            this.groupBox1.Controls.Add(this.prodExpDate);
            this.groupBox1.Controls.Add(this.prodNameText);
            this.groupBox1.Controls.Add(this.prodUPtxt);
            this.groupBox1.Controls.Add(this.prodQuText);
            this.groupBox1.Controls.Add(this.prodIdText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // prodRegButt
            // 
            this.prodRegButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodRegButt.Location = new System.Drawing.Point(889, 170);
            this.prodRegButt.Name = "prodRegButt";
            this.prodRegButt.Size = new System.Drawing.Size(129, 52);
            this.prodRegButt.TabIndex = 16;
            this.prodRegButt.Text = "Register";
            this.prodRegButt.UseVisualStyleBackColor = true;
            this.prodRegButt.Click += new System.EventHandler(this.prodRegButt_Click);
            // 
            // prodCanButt
            // 
            this.prodCanButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCanButt.Location = new System.Drawing.Point(889, 233);
            this.prodCanButt.Name = "prodCanButt";
            this.prodCanButt.Size = new System.Drawing.Size(129, 44);
            this.prodCanButt.TabIndex = 15;
            this.prodCanButt.Text = "Cancel";
            this.prodCanButt.UseVisualStyleBackColor = true;
            this.prodCanButt.Click += new System.EventHandler(this.prodCanButt_Click);
            // 
            // prodDelButt
            // 
            this.prodDelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDelButt.Location = new System.Drawing.Point(684, 233);
            this.prodDelButt.Name = "prodDelButt";
            this.prodDelButt.Size = new System.Drawing.Size(120, 44);
            this.prodDelButt.TabIndex = 14;
            this.prodDelButt.Text = "Delete";
            this.prodDelButt.UseVisualStyleBackColor = true;
            this.prodDelButt.Click += new System.EventHandler(this.prodDelButt_Click);
            // 
            // prodUpdButt
            // 
            this.prodUpdButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodUpdButt.Location = new System.Drawing.Point(684, 170);
            this.prodUpdButt.Name = "prodUpdButt";
            this.prodUpdButt.Size = new System.Drawing.Size(120, 52);
            this.prodUpdButt.TabIndex = 13;
            this.prodUpdButt.Text = "Update";
            this.prodUpdButt.UseVisualStyleBackColor = true;
            this.prodUpdButt.Click += new System.EventHandler(this.prodUpdButt_Click);
            // 
            // prodSearchButt
            // 
            this.prodSearchButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodSearchButt.Location = new System.Drawing.Point(898, 49);
            this.prodSearchButt.Name = "prodSearchButt";
            this.prodSearchButt.Size = new System.Drawing.Size(120, 38);
            this.prodSearchButt.TabIndex = 12;
            this.prodSearchButt.Text = "Search";
            this.prodSearchButt.UseVisualStyleBackColor = true;
            this.prodSearchButt.Click += new System.EventHandler(this.prodSearchButt_Click);
            // 
            // prodSearchText
            // 
            this.prodSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodSearchText.Location = new System.Drawing.Point(684, 49);
            this.prodSearchText.Multiline = true;
            this.prodSearchText.Name = "prodSearchText";
            this.prodSearchText.Size = new System.Drawing.Size(208, 38);
            this.prodSearchText.TabIndex = 11;
            // 
            // prodExpDate
            // 
            this.prodExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.prodExpDate.Location = new System.Drawing.Point(261, 241);
            this.prodExpDate.Name = "prodExpDate";
            this.prodExpDate.Size = new System.Drawing.Size(265, 35);
            this.prodExpDate.TabIndex = 10;
            // 
            // prodNameText
            // 
            this.prodNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameText.Location = new System.Drawing.Point(261, 103);
            this.prodNameText.Name = "prodNameText";
            this.prodNameText.Size = new System.Drawing.Size(265, 35);
            this.prodNameText.TabIndex = 9;
            // 
            // prodUPtxt
            // 
            this.prodUPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodUPtxt.Location = new System.Drawing.Point(261, 155);
            this.prodUPtxt.Name = "prodUPtxt";
            this.prodUPtxt.Size = new System.Drawing.Size(265, 35);
            this.prodUPtxt.TabIndex = 8;
            this.prodUPtxt.TextChanged += new System.EventHandler(this.proUPtxt_TextChanged);
            // 
            // prodQuText
            // 
            this.prodQuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodQuText.Location = new System.Drawing.Point(261, 200);
            this.prodQuText.Name = "prodQuText";
            this.prodQuText.Size = new System.Drawing.Size(265, 35);
            this.prodQuText.TabIndex = 7;
            // 
            // prodIdText
            // 
            this.prodIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodIdText.Location = new System.Drawing.Point(261, 52);
            this.prodIdText.Name = "prodIdText";
            this.prodIdText.Size = new System.Drawing.Size(265, 35);
            this.prodIdText.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Product name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Unit price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Expiry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products Details";
            // 
            // productsInfo
            // 
            this.productsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsInfo.Location = new System.Drawing.Point(129, 419);
            this.productsInfo.Name = "productsInfo";
            this.productsInfo.RowHeadersWidth = 62;
            this.productsInfo.RowTemplate.Height = 28;
            this.productsInfo.Size = new System.Drawing.Size(885, 181);
            this.productsInfo.TabIndex = 3;
            this.productsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsInfo_CellClick);
            this.productsInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsInfo_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products view";
            // 
            // printReport
            // 
            this.printReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReport.Location = new System.Drawing.Point(700, -2);
            this.printReport.Name = "printReport";
            this.printReport.Size = new System.Drawing.Size(185, 46);
            this.printReport.TabIndex = 17;
            this.printReport.Text = "Print report";
            this.printReport.UseVisualStyleBackColor = true;
            this.printReport.Click += new System.EventHandler(this.printReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.printReport);
            this.panel1.Location = new System.Drawing.Point(129, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 47);
            this.panel1.TabIndex = 5;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1129, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productsInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker prodExpDate;
        private System.Windows.Forms.TextBox prodNameText;
        private System.Windows.Forms.TextBox prodUPtxt;
        private System.Windows.Forms.TextBox prodQuText;
        private System.Windows.Forms.TextBox prodIdText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prodRegButt;
        private System.Windows.Forms.Button prodCanButt;
        private System.Windows.Forms.Button prodDelButt;
        private System.Windows.Forms.Button prodUpdButt;
        private System.Windows.Forms.Button prodSearchButt;
        private System.Windows.Forms.TextBox prodSearchText;
        private System.Windows.Forms.DataGridView productsInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printReport;
        private System.Windows.Forms.Panel panel1;
    }
}