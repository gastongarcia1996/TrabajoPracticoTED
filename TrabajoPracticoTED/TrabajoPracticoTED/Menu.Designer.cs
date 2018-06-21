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
            this.SuspendLayout();
            // 
            // btn_sistMateriales
            // 
            this.btn_sistMateriales.BackColor = System.Drawing.Color.Transparent;
            this.btn_sistMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sistMateriales.Location = new System.Drawing.Point(270, 174);
            this.btn_sistMateriales.Name = "btn_sistMateriales";
            this.btn_sistMateriales.Size = new System.Drawing.Size(255, 23);
            this.btn_sistMateriales.TabIndex = 0;
            this.btn_sistMateriales.UseVisualStyleBackColor = false;
            this.btn_sistMateriales.Click += new System.EventHandler(this.btn_sistMateriales_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(185, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPracticoTED.Properties.Resources.dexter_tamaño_nuevo_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 325);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sistMateriales);
            this.Name = "Menu";
            this.Text = "Tabajo Practico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sistMateriales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_atras;
    }
}