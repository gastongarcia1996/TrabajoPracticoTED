﻿namespace TrabajoPracticoTED
{
    partial class RegistroUsuarioForm
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_nombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_repetirContraseña = new System.Windows.Forms.Label();
            this.txt_repetirContraseña = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ver2 = new System.Windows.Forms.Button();
            this.btn_ver1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(43, 45);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(143, 16);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Nombre de Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.Location = new System.Drawing.Point(99, 94);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(87, 16);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // txt_nombreDeUsuario
            // 
            this.txt_nombreDeUsuario.Location = new System.Drawing.Point(218, 41);
            this.txt_nombreDeUsuario.Name = "txt_nombreDeUsuario";
            this.txt_nombreDeUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreDeUsuario.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(218, 90);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // lbl_repetirContraseña
            // 
            this.lbl_repetirContraseña.AutoSize = true;
            this.lbl_repetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repetirContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_repetirContraseña.Location = new System.Drawing.Point(46, 142);
            this.lbl_repetirContraseña.Name = "lbl_repetirContraseña";
            this.lbl_repetirContraseña.Size = new System.Drawing.Size(140, 16);
            this.lbl_repetirContraseña.TabIndex = 4;
            this.lbl_repetirContraseña.Text = "Repetir contraseña";
            // 
            // txt_repetirContraseña
            // 
            this.txt_repetirContraseña.Location = new System.Drawing.Point(218, 138);
            this.txt_repetirContraseña.Name = "txt_repetirContraseña";
            this.txt_repetirContraseña.PasswordChar = '*';
            this.txt_repetirContraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_repetirContraseña.TabIndex = 5;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(91, 255);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(281, 255);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ver2
            // 
            this.btn_ver2.Location = new System.Drawing.Point(324, 136);
            this.btn_ver2.Name = "btn_ver2";
            this.btn_ver2.Size = new System.Drawing.Size(32, 23);
            this.btn_ver2.TabIndex = 9;
            this.btn_ver2.Text = "Ver";
            this.btn_ver2.UseVisualStyleBackColor = true;
            this.btn_ver2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down_btn2);
            this.btn_ver2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up_btn2);
            // 
            // btn_ver1
            // 
            this.btn_ver1.Location = new System.Drawing.Point(324, 88);
            this.btn_ver1.Name = "btn_ver1";
            this.btn_ver1.Size = new System.Drawing.Size(32, 23);
            this.btn_ver1.TabIndex = 10;
            this.btn_ver1.Text = "Ver";
            this.btn_ver1.UseVisualStyleBackColor = true;
            this.btn_ver1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.btn_ver1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_up);
            // 
            // RegistroUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPracticoTED.Properties.Resources.crear_cuenta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 300);
            this.Controls.Add(this.btn_ver1);
            this.Controls.Add(this.btn_ver2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_repetirContraseña);
            this.Controls.Add(this.lbl_repetirContraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombreDeUsuario);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usuario);
            this.Name = "RegistroUsuarioForm";
            this.Text = "RegistroUsuarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_nombreDeUsuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_repetirContraseña;
        private System.Windows.Forms.TextBox txt_repetirContraseña;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ver2;
        private System.Windows.Forms.Button btn_ver1;
    }
}