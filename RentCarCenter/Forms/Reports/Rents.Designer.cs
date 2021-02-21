
namespace RentCarCenter
{
    partial class Rents
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
            this.GridRents = new System.Windows.Forms.DataGridView();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpSince = new System.Windows.Forms.DateTimePicker();
            this.tpTo = new System.Windows.Forms.DateTimePicker();
            this.btnDateFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridRents)).BeginInit();
            this.SuspendLayout();
            // 
            // GridRents
            // 
            this.GridRents.AllowUserToAddRows = false;
            this.GridRents.AllowUserToDeleteRows = false;
            this.GridRents.AllowUserToOrderColumns = true;
            this.GridRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridRents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRents.Location = new System.Drawing.Point(293, 131);
            this.GridRents.Name = "GridRents";
            this.GridRents.ReadOnly = true;
            this.GridRents.RowHeadersVisible = false;
            this.GridRents.RowHeadersWidth = 51;
            this.GridRents.RowTemplate.Height = 29;
            this.GridRents.Size = new System.Drawing.Size(759, 444);
            this.GridRents.TabIndex = 1;
            // 
            // PrintBtn
            // 
            this.PrintBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PrintBtn.Location = new System.Drawing.Point(954, 19);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(88, 29);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "Exportar";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PdfBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 141);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PlaceholderText = "Buscar cliente por cedula o nombre";
            this.SearchTextBox.Size = new System.Drawing.Size(251, 27);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(362, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rentas y devoluciones";
            // 
            // tpSince
            // 
            this.tpSince.Location = new System.Drawing.Point(89, 193);
            this.tpSince.Name = "tpSince";
            this.tpSince.Size = new System.Drawing.Size(174, 27);
            this.tpSince.TabIndex = 10;
            // 
            // tpTo
            // 
            this.tpTo.Location = new System.Drawing.Point(89, 251);
            this.tpTo.Name = "tpTo";
            this.tpTo.Size = new System.Drawing.Size(174, 27);
            this.tpTo.TabIndex = 11;
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Location = new System.Drawing.Point(102, 330);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(94, 29);
            this.btnDateFilter.TabIndex = 12;
            this.btnDateFilter.Text = "Filtrar";
            this.btnDateFilter.UseVisualStyleBackColor = true;
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desde: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta:";
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDateFilter);
            this.Controls.Add(this.tpTo);
            this.Controls.Add(this.tpSince);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.GridRents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Rents";
            this.Text = "Rentas";
            this.Load += new System.EventHandler(this.Rents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridRents;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tpSince;
        private System.Windows.Forms.DateTimePicker tpTo;
        private System.Windows.Forms.Button btnDateFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}