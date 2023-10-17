namespace ProductWinApp
{
    partial class frmProduct
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
            dataGridView1 = new DataGridView();
            btnProducts = new Button();
            btnCategories = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(239, 251);
            dataGridView1.TabIndex = 0;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(75, 304);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(130, 23);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "View Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(75, 348);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(130, 23);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "View Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(75, 391);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 450);
            Controls.Add(btnClose);
            Controls.Add(btnCategories);
            Controls.Add(btnProducts);
            Controls.Add(dataGridView1);
            Name = "frmProduct";
            Text = "Form1";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnClose;
    }
}