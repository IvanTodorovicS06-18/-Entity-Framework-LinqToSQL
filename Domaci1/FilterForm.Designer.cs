
namespace Domaci1
{
    partial class FilterForm
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityList = new System.Windows.Forms.TextBox();
            this.gridCityList = new System.Windows.Forms.DataGridView();
            this.btnRefersh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCityList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(97, 86);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(139, 26);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CITY:";
            // 
            // txtCityList
            // 
            this.txtCityList.Location = new System.Drawing.Point(97, 44);
            this.txtCityList.Multiline = true;
            this.txtCityList.Name = "txtCityList";
            this.txtCityList.Size = new System.Drawing.Size(139, 27);
            this.txtCityList.TabIndex = 6;
            // 
            // gridCityList
            // 
            this.gridCityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCityList.Location = new System.Drawing.Point(12, 131);
            this.gridCityList.Name = "gridCityList";
            this.gridCityList.Size = new System.Drawing.Size(1174, 329);
            this.gridCityList.TabIndex = 5;
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(283, 86);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(150, 26);
            this.btnRefersh.TabIndex = 9;
            this.btnRefersh.Text = "REFRESH";
            this.btnRefersh.UseVisualStyleBackColor = true;
            this.btnRefersh.Click += new System.EventHandler(this.btnRefersh_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 495);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCityList);
            this.Controls.Add(this.gridCityList);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityList;
        private System.Windows.Forms.DataGridView gridCityList;
        private System.Windows.Forms.Button btnRefersh;
    }
}