namespace FileConverter
{
    partial class Frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.Btn_SelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Details = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Cmb_Output = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.Enabled = false;
            this.Btn_Convert.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Convert.ForeColor = System.Drawing.Color.White;
            this.Btn_Convert.Location = new System.Drawing.Point(158, 487);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(129, 30);
            this.Btn_Convert.TabIndex = 0;
            this.Btn_Convert.Text = "Convert";
            this.Btn_Convert.UseVisualStyleBackColor = true;
            this.Btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // Btn_SelectFile
            // 
            this.Btn_SelectFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelectFile.ForeColor = System.Drawing.Color.White;
            this.Btn_SelectFile.Location = new System.Drawing.Point(16, 487);
            this.Btn_SelectFile.Name = "Btn_SelectFile";
            this.Btn_SelectFile.Size = new System.Drawing.Size(136, 30);
            this.Btn_SelectFile.TabIndex = 6;
            this.Btn_SelectFile.Text = "Select File";
            this.Btn_SelectFile.UseVisualStyleBackColor = true;
            this.Btn_SelectFile.Click += new System.EventHandler(this.Btn_SelectFile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Created By: Rocky John Bantolo";
            // 
            // Dgv_Details
            // 
            this.Dgv_Details.AllowUserToAddRows = false;
            this.Dgv_Details.AllowUserToDeleteRows = false;
            this.Dgv_Details.AllowUserToResizeColumns = false;
            this.Dgv_Details.AllowUserToResizeRows = false;
            this.Dgv_Details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Dgv_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dgv_Details.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_Details.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Details.ColumnHeadersHeight = 30;
            this.Dgv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Details.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv_Details.Location = new System.Drawing.Point(16, 64);
            this.Dgv_Details.Margin = new System.Windows.Forms.Padding(10, 5, 10, 9);
            this.Dgv_Details.Name = "Dgv_Details";
            this.Dgv_Details.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Details.RowHeadersVisible = false;
            this.Dgv_Details.RowHeadersWidth = 35;
            this.Dgv_Details.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Details.RowTemplate.Height = 35;
            this.Dgv_Details.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Details.Size = new System.Drawing.Size(887, 411);
            this.Dgv_Details.TabIndex = 8;
            this.Dgv_Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Details_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "File Path";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "File Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 230;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "File Location";
            this.Column4.Name = "Column4";
            this.Column4.Width = 255;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Progress";
            this.Column3.Name = "Column3";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Location = new System.Drawing.Point(428, 487);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(129, 30);
            this.Btn_Clear.TabIndex = 9;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Remove.ForeColor = System.Drawing.Color.White;
            this.Btn_Remove.Location = new System.Drawing.Point(293, 487);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(129, 30);
            this.Btn_Remove.TabIndex = 10;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Cmb_Output
            // 
            this.Cmb_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Cmb_Output.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_Output.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Output.ForeColor = System.Drawing.Color.White;
            this.Cmb_Output.FormattingEnabled = true;
            this.Cmb_Output.Items.AddRange(new object[] {
            "CSV",
            "EXCEL",
            "TEXT"});
            this.Cmb_Output.Location = new System.Drawing.Point(16, 24);
            this.Cmb_Output.Name = "Cmb_Output";
            this.Cmb_Output.Size = new System.Drawing.Size(885, 26);
            this.Cmb_Output.TabIndex = 11;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(920, 574);
            this.Controls.Add(this.Cmb_Output);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Dgv_Details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_SelectFile);
            this.Controls.Add(this.Btn_Convert);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Conventer";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Convert;
        private System.Windows.Forms.Button Btn_SelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Details;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.ComboBox Cmb_Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

