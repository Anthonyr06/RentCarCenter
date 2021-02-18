
namespace RentCarCenter.Forms.Bussiness
{
    partial class ReturnDetailForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.returnDataGrid = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rentDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(537, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(340, 41);
            this.label9.TabIndex = 45;
            this.label9.Text = "Detalles de Devolución:";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(783, 499);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 44;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(489, 499);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 29);
            this.EditBtn.TabIndex = 43;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // returnDataGrid
            // 
            this.returnDataGrid.AllowUserToAddRows = false;
            this.returnDataGrid.AllowUserToDeleteRows = false;
            this.returnDataGrid.AllowUserToOrderColumns = true;
            this.returnDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnDataGrid.Location = new System.Drawing.Point(537, 56);
            this.returnDataGrid.MultiSelect = false;
            this.returnDataGrid.Name = "returnDataGrid";
            this.returnDataGrid.ReadOnly = true;
            this.returnDataGrid.RowHeadersWidth = 51;
            this.returnDataGrid.RowTemplate.Height = 29;
            this.returnDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnDataGrid.Size = new System.Drawing.Size(491, 229);
            this.returnDataGrid.TabIndex = 42;
            this.returnDataGrid.SelectionChanged += new System.EventHandler(this.returnDataGrid_SelectionChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(757, 362);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 28);
            this.cbStatus.TabIndex = 41;
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(123, 360);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(228, 63);
            this.commentTxt.TabIndex = 40;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(437, 362);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(245, 27);
            this.dpDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(743, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(423, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha de Devolución:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(109, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Comentario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 41);
            this.label2.TabIndex = 48;
            this.label2.Text = "Rentas:";
            // 
            // rentDataGrid
            // 
            this.rentDataGrid.AllowUserToAddRows = false;
            this.rentDataGrid.AllowUserToDeleteRows = false;
            this.rentDataGrid.AllowUserToOrderColumns = true;
            this.rentDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentDataGrid.Location = new System.Drawing.Point(12, 56);
            this.rentDataGrid.MultiSelect = false;
            this.rentDataGrid.Name = "rentDataGrid";
            this.rentDataGrid.ReadOnly = true;
            this.rentDataGrid.RowHeadersWidth = 51;
            this.rentDataGrid.RowTemplate.Height = 29;
            this.rentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentDataGrid.Size = new System.Drawing.Size(491, 229);
            this.rentDataGrid.TabIndex = 47;
            this.rentDataGrid.SelectionChanged += new System.EventHandler(this.rentDataGrid_SelectionChanged);
            // 
            // ReturnDetailService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rentDataGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.returnDataGrid);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ReturnDetailService";
            this.Text = "Nueva Devolucion";
            this.Load += new System.EventHandler(this.ReturnDetailService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView returnDataGrid;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView rentDataGrid;
    }
}