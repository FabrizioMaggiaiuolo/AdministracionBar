namespace FormsBar
{
    partial class FrmOperaciones
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
            btnAddOrder = new Button();
            btnViewOrder = new Button();
            btnClose = new Button();
            btnAddCar = new Button();
            SuspendLayout();
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(121, 147);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(112, 36);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "Add to the order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.Location = new Point(121, 79);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(112, 36);
            btnViewOrder.TabIndex = 1;
            btnViewOrder.Text = "View order";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(121, 417);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 36);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(121, 206);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(112, 36);
            btnAddCar.TabIndex = 3;
            btnAddCar.Text = "Add car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // FrmOperaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 519);
            Controls.Add(btnAddCar);
            Controls.Add(btnClose);
            Controls.Add(btnViewOrder);
            Controls.Add(btnAddOrder);
            Name = "FrmOperaciones";
            Text = "FrmOperaciones";
            Load += FrmOperaciones_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddOrder;
        private Button btnViewOrder;
        private Button btnClose;
        private Button btnAddCar;
    }
}