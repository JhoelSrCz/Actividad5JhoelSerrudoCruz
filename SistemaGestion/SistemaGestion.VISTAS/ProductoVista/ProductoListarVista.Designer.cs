﻿namespace SistemaGestion.VISTAS.ProductoVista
{
    partial class ProductoListarVista
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(574, 358);
            dataGridView1.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 9);
            label2.Name = "label2";
            label2.Size = new Size(291, 35);
            label2.TabIndex = 54;
            label2.Text = "LISTA DE PRODUCTO";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(417, 411);
            button1.Name = "button1";
            button1.Size = new Size(126, 33);
            button1.TabIndex = 53;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(161, 411);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 52;
            button3.Text = "EDITAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.OK;
            button4.Location = new Point(289, 411);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 51;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(33, 411);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 50;
            button2.Text = "AGREGAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProductoListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Name = "ProductoListarVista";
            Text = "ProductoListarVista";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
    }
}