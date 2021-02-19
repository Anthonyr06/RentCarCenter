
namespace RentCarCenter.Forms.Bussiness
{
    partial class InspectionForm
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
            this.cbFuelQuantity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rentDataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.inspectionDataGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.cbHasSpareTire = new System.Windows.Forms.CheckBox();
            this.cbHasBrokenMirror = new System.Windows.Forms.CheckBox();
            this.cbIsGrated = new System.Windows.Forms.CheckBox();
            this.cbHasHydraulicCat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(643, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condiciones:";
            // 
            // cbFuelQuantity
            // 
            this.cbFuelQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelQuantity.FormattingEnabled = true;
            this.cbFuelQuantity.Items.AddRange(new object[] {
            "1",
            "1/2",
            "1/4"});
            this.cbFuelQuantity.Location = new System.Drawing.Point(85, 365);
            this.cbFuelQuantity.Name = "cbFuelQuantity";
            this.cbFuelQuantity.Size = new System.Drawing.Size(218, 28);
            this.cbFuelQuantity.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(75, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cantidad de Combustible:";
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(85, 428);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(218, 27);
            this.dpDate.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(75, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(331, 365);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(218, 28);
            this.cbStatus.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(321, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 41);
            this.label3.TabIndex = 52;
            this.label3.Text = "Rentas cerradas:";
            // 
            // rentDataGrid
            // 
            this.rentDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentDataGrid.Location = new System.Drawing.Point(12, 54);
            this.rentDataGrid.MultiSelect = false;
            this.rentDataGrid.Name = "rentDataGrid";
            this.rentDataGrid.RowHeadersWidth = 51;
            this.rentDataGrid.RowTemplate.Height = 29;
            this.rentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentDataGrid.Size = new System.Drawing.Size(482, 229);
            this.rentDataGrid.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(539, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 41);
            this.label9.TabIndex = 50;
            this.label9.Text = "Inspecciones:";
            // 
            // inspectionDataGrid
            // 
            this.inspectionDataGrid.AllowUserToAddRows = false;
            this.inspectionDataGrid.AllowUserToDeleteRows = false;
            this.inspectionDataGrid.AllowUserToOrderColumns = true;
            this.inspectionDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inspectionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionDataGrid.Location = new System.Drawing.Point(539, 54);
            this.inspectionDataGrid.MultiSelect = false;
            this.inspectionDataGrid.Name = "inspectionDataGrid";
            this.inspectionDataGrid.ReadOnly = true;
            this.inspectionDataGrid.RowHeadersWidth = 51;
            this.inspectionDataGrid.RowTemplate.Height = 29;
            this.inspectionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inspectionDataGrid.Size = new System.Drawing.Size(503, 229);
            this.inspectionDataGrid.TabIndex = 49;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(192, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(799, 510);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 54;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(469, 510);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 29);
            this.EditBtn.TabIndex = 53;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // cbHasSpareTire
            // 
            this.cbHasSpareTire.AutoSize = true;
            this.cbHasSpareTire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHasSpareTire.Location = new System.Drawing.Point(653, 401);
            this.cbHasSpareTire.Name = "cbHasSpareTire";
            this.cbHasSpareTire.Size = new System.Drawing.Size(157, 24);
            this.cbHasSpareTire.TabIndex = 56;
            this.cbHasSpareTire.Text = "Goma de Repuesta";
            this.cbHasSpareTire.UseVisualStyleBackColor = true;
            // 
            // cbHasBrokenMirror
            // 
            this.cbHasBrokenMirror.AutoSize = true;
            this.cbHasBrokenMirror.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHasBrokenMirror.Location = new System.Drawing.Point(653, 431);
            this.cbHasBrokenMirror.Name = "cbHasBrokenMirror";
            this.cbHasBrokenMirror.Size = new System.Drawing.Size(128, 24);
            this.cbHasBrokenMirror.TabIndex = 57;
            this.cbHasBrokenMirror.Text = "Cristales Rotos";
            this.cbHasBrokenMirror.UseVisualStyleBackColor = true;
            // 
            // cbIsGrated
            // 
            this.cbIsGrated.AutoSize = true;
            this.cbIsGrated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbIsGrated.Location = new System.Drawing.Point(653, 461);
            this.cbIsGrated.Name = "cbIsGrated";
            this.cbIsGrated.Size = new System.Drawing.Size(82, 24);
            this.cbIsGrated.TabIndex = 58;
            this.cbIsGrated.Text = "Rallado";
            this.cbIsGrated.UseVisualStyleBackColor = true;
            // 
            // cbHasHydraulicCat
            // 
            this.cbHasHydraulicCat.AutoSize = true;
            this.cbHasHydraulicCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbHasHydraulicCat.Location = new System.Drawing.Point(653, 371);
            this.cbHasHydraulicCat.Name = "cbHasHydraulicCat";
            this.cbHasHydraulicCat.Size = new System.Drawing.Size(136, 24);
            this.cbHasHydraulicCat.TabIndex = 59;
            this.cbHasHydraulicCat.Text = "Gato Hidraulico";
            this.cbHasHydraulicCat.UseVisualStyleBackColor = true;
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.cbHasHydraulicCat);
            this.Controls.Add(this.cbIsGrated);
            this.Controls.Add(this.cbHasBrokenMirror);
            this.Controls.Add(this.cbHasSpareTire);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rentDataGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inspectionDataGrid);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFuelQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "InspectionForm";
            this.Text = "Rentas e inspecciones";
            this.Load += new System.EventHandler(this.InspectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFuelQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView rentDataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView inspectionDataGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.CheckBox cbHasSpareTire;
        private System.Windows.Forms.CheckBox cbHasBrokenMirror;
        private System.Windows.Forms.CheckBox cbIsGrated;
        private System.Windows.Forms.CheckBox cbHasHydraulicCat;
    }
}