namespace FormsBar
{
    partial class FrmData
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
            dgvMeses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMeses).BeginInit();
            SuspendLayout();
            // 
            // dgvMeses
            // 
            dgvMeses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeses.Location = new Point(12, 12);
            dgvMeses.Name = "dgvMeses";
            dgvMeses.ReadOnly = true;
            dgvMeses.RowTemplate.Height = 25;
            dgvMeses.Size = new Size(272, 334);
            dgvMeses.TabIndex = 0;
            // 
            // FrmData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 358);
            Controls.Add(dgvMeses);
            Name = "FrmData";
            Text = "FrmData";
            Load += FrmData_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMeses;
    }
}