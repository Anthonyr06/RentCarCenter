
namespace RentCarCenter.Forms.Bussiness
{
    partial class RentDetailForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dpRentDate = new System.Windows.Forms.DateTimePicker();
            this.nPriceByDay = new System.Windows.Forms.NumericUpDown();
            this.nRentDays = new System.Windows.Forms.NumericUpDown();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.rentDataGrid = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nPriceByDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRentDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(644, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comentario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(633, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dias Rentado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(316, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio por Dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(310, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Renta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vehiculo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(10, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(365, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estado:";
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(96, 102);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(160, 28);
            this.cbEmployee.TabIndex = 13;
            // 
            // cbVehicle
            // 
            this.cbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(96, 150);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(160, 28);
            this.cbVehicle.TabIndex = 14;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(96, 201);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(160, 28);
            this.cbCustomer.TabIndex = 15;
            // 
            // dpRentDate
            // 
            this.dpRentDate.Location = new System.Drawing.Point(429, 102);
            this.dpRentDate.MinDate = new System.DateTime(2021, 2, 17, 0, 0, 0, 0);
            this.dpRentDate.Name = "dpRentDate";
            this.dpRentDate.Size = new System.Drawing.Size(160, 27);
            this.dpRentDate.TabIndex = 16;
            // 
            // nPriceByDay
            // 
            this.nPriceByDay.Location = new System.Drawing.Point(429, 188);
            this.nPriceByDay.Name = "nPriceByDay";
            this.nPriceByDay.Size = new System.Drawing.Size(160, 27);
            this.nPriceByDay.TabIndex = 17;
            // 
            // nRentDays
            // 
            this.nRentDays.Location = new System.Drawing.Point(740, 110);
            this.nRentDays.Name = "nRentDays";
            this.nRentDays.Size = new System.Drawing.Size(160, 27);
            this.nRentDays.TabIndex = 18;
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(740, 156);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(174, 54);
            this.commentTxt.TabIndex = 19;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(429, 144);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 28);
            this.cbStatus.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(339, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 41);
            this.label9.TabIndex = 24;
            this.label9.Text = "Informacion de la renta";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(740, 253);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 23;
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(453, 253);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 29);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Editar";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // rentDataGrid
            // 
            this.rentDataGrid.AllowUserToAddRows = false;
            this.rentDataGrid.AllowUserToDeleteRows = false;
            this.rentDataGrid.AllowUserToOrderColumns = true;
            this.rentDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentDataGrid.Location = new System.Drawing.Point(-1, 288);
            this.rentDataGrid.MultiSelect = false;
            this.rentDataGrid.Name = "rentDataGrid";
            this.rentDataGrid.ReadOnly = true;
            this.rentDataGrid.RowHeadersWidth = 51;
            this.rentDataGrid.RowTemplate.Height = 29;
            this.rentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentDataGrid.Size = new System.Drawing.Size(1055, 291);
            this.rentDataGrid.TabIndex = 21;
            this.rentDataGrid.SelectionChanged += new System.EventHandler(this.rentDataGrid_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.rentDataGrid);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.nRentDays);
            this.Controls.Add(this.nPriceByDay);
            this.Controls.Add(this.dpRentDate);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentDetailForm";
            this.Text = "Nueva renta";
            this.Load += new System.EventHandler(this.RentDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nPriceByDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRentDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DateTimePicker dpRentDate;
        private System.Windows.Forms.NumericUpDown nPriceByDay;
        private System.Windows.Forms.NumericUpDown nRentDays;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView rentDataGrid;
        private System.Windows.Forms.Button btnSave;
    }
}