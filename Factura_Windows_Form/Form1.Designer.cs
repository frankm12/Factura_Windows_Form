namespace Factura_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ITEM = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            PU = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            btnguardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ITEM, CANTIDAD, DESCRIPCION, PU });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(553, 188);
            dataGridView1.TabIndex = 0;
            // 
            // ITEM
            // 
            ITEM.HeaderText = "ITEM";
            ITEM.MinimumWidth = 6;
            ITEM.Name = "ITEM";
            ITEM.Width = 125;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 125;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 6;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Width = 125;
            // 
            // PU
            // 
            PU.HeaderText = "PU";
            PU.MinimumWidth = 6;
            PU.Name = "PU";
            PU.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 253);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(562, 188);
            dataGridView2.TabIndex = 1;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(629, 521);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(94, 29);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 619);
            Controls.Add(btnguardar);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ITEM;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn PU;
        private DataGridView dataGridView2;
        private Button btnguardar;
    }
}
