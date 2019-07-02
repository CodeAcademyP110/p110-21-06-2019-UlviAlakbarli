namespace GaranuMotorsWithEF
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
            this.dataGridViewBrands = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBrands
            // 
            this.dataGridViewBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBrands.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewBrands.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrands.Location = new System.Drawing.Point(-1, 25);
            this.dataGridViewBrands.Name = "dataGridViewBrands";
            this.dataGridViewBrands.Size = new System.Drawing.Size(915, 303);
            this.dataGridViewBrands.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cars";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(15, 344);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(108, 23);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add New Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBrands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBrands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCar;
    }
}

