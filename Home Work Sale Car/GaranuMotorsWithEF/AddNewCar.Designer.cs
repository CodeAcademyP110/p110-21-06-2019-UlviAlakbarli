namespace GaranuMotorsWithEF
{
    partial class AddNewCar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbModelName = new System.Windows.Forms.ComboBox();
            this.cmbFuelName = new System.Windows.Forms.ComboBox();
            this.cmbTransimission = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.dateProduced = new System.Windows.Forms.DateTimePicker();
            this.numericEngine = new System.Windows.Forms.NumericUpDown();
            this.numericDistance = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transimission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Engine Volume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fuel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Production Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBrand);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAddNewCar);
            this.panel1.Controls.Add(this.numericDistance);
            this.panel1.Controls.Add(this.numericEngine);
            this.panel1.Controls.Add(this.dateProduced);
            this.panel1.Controls.Add(this.cmbColor);
            this.panel1.Controls.Add(this.cmbTransimission);
            this.panel1.Controls.Add(this.cmbFuelName);
            this.panel1.Controls.Add(this.cmbModelName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 401);
            this.panel1.TabIndex = 7;
            // 
            // cmbModelName
            // 
            this.cmbModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelName.FormattingEnabled = true;
            this.cmbModelName.Location = new System.Drawing.Point(238, 70);
            this.cmbModelName.Name = "cmbModelName";
            this.cmbModelName.Size = new System.Drawing.Size(136, 21);
            this.cmbModelName.TabIndex = 7;
            // 
            // cmbFuelName
            // 
            this.cmbFuelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelName.FormattingEnabled = true;
            this.cmbFuelName.Location = new System.Drawing.Point(238, 106);
            this.cmbFuelName.Name = "cmbFuelName";
            this.cmbFuelName.Size = new System.Drawing.Size(136, 21);
            this.cmbFuelName.TabIndex = 8;
            // 
            // cmbTransimission
            // 
            this.cmbTransimission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransimission.FormattingEnabled = true;
            this.cmbTransimission.Location = new System.Drawing.Point(238, 173);
            this.cmbTransimission.Name = "cmbTransimission";
            this.cmbTransimission.Size = new System.Drawing.Size(136, 21);
            this.cmbTransimission.TabIndex = 10;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(238, 286);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(136, 21);
            this.cmbColor.TabIndex = 11;
            // 
            // dateProduced
            // 
            this.dateProduced.Location = new System.Drawing.Point(238, 139);
            this.dateProduced.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dateProduced.MinDate = new System.DateTime(1980, 12, 25, 0, 0, 0, 0);
            this.dateProduced.Name = "dateProduced";
            this.dateProduced.Size = new System.Drawing.Size(136, 20);
            this.dateProduced.TabIndex = 12;
            // 
            // numericEngine
            // 
            this.numericEngine.DecimalPlaces = 2;
            this.numericEngine.Location = new System.Drawing.Point(238, 215);
            this.numericEngine.Name = "numericEngine";
            this.numericEngine.Size = new System.Drawing.Size(136, 20);
            this.numericEngine.TabIndex = 13;
            // 
            // numericDistance
            // 
            this.numericDistance.DecimalPlaces = 2;
            this.numericDistance.Location = new System.Drawing.Point(238, 251);
            this.numericDistance.Name = "numericDistance";
            this.numericDistance.Size = new System.Drawing.Size(136, 20);
            this.numericDistance.TabIndex = 14;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.BackColor = System.Drawing.Color.Lime;
            this.btnAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.Location = new System.Drawing.Point(146, 341);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(146, 27);
            this.btnAddNewCar.TabIndex = 15;
            this.btnAddNewCar.Text = "Add Car";
            this.btnAddNewCar.UseVisualStyleBackColor = false;
            this.btnAddNewCar.Click += new System.EventHandler(this.BtnAddNewCar_Click);
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(238, 32);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(136, 21);
            this.cmbBrand.TabIndex = 17;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.CmbBrand_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Brand";
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 425);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewCar";
            this.Text = "AddNewCar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewCar_FormClosed);
            this.Load += new System.EventHandler(this.AddNewCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.NumericUpDown numericDistance;
        private System.Windows.Forms.NumericUpDown numericEngine;
        private System.Windows.Forms.DateTimePicker dateProduced;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTransimission;
        private System.Windows.Forms.ComboBox cmbFuelName;
        private System.Windows.Forms.ComboBox cmbModelName;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label8;
    }
}