namespace TrabajoPracticoTED
{
    partial class Menu
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
            this.btn_sistMateriales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sistMateriales
            // 
            this.btn_sistMateriales.Location = new System.Drawing.Point(123, 138);
            this.btn_sistMateriales.Name = "btn_sistMateriales";
            this.btn_sistMateriales.Size = new System.Drawing.Size(132, 23);
            this.btn_sistMateriales.TabIndex = 0;
            this.btn_sistMateriales.Text = "Sistemas Materiales";
            this.btn_sistMateriales.UseVisualStyleBackColor = true;
            this.btn_sistMateriales.Click += new System.EventHandler(this.btn_sistMateriales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sistema Nervioso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_sistNervioso_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(677, 290);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 3;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija una opcion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sistMateriales);
            this.Name = "Menu";
            this.Text = "Tabajo Practico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sistMateriales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Label label1;
    }
}