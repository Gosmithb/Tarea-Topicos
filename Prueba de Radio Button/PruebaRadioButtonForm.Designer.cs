
namespace Prueba_de_Radio_Button
{
    partial class PruebaRadioButtonForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tipoBoton_Gbx = new System.Windows.Forms.GroupBox();
            this.reintentarCancelar_Btn = new System.Windows.Forms.RadioButton();
            this.siNo_Btn = new System.Windows.Forms.RadioButton();
            this.siNoCancelar_Btn = new System.Windows.Forms.RadioButton();
            this.abortarReintentarIgnorar_Btn = new System.Windows.Forms.RadioButton();
            this.cancelar_Btn = new System.Windows.Forms.RadioButton();
            this.aceptar_Btn = new System.Windows.Forms.RadioButton();
            this.icono_Gbx = new System.Windows.Forms.GroupBox();
            this.informacion_Btn = new System.Windows.Forms.RadioButton();
            this.pregunta_Btn = new System.Windows.Forms.RadioButton();
            this.alto_Btn = new System.Windows.Forms.RadioButton();
            this.advertencia_Btn = new System.Windows.Forms.RadioButton();
            this.mano_Btn = new System.Windows.Forms.RadioButton();
            this.exclamacion_Btn = new System.Windows.Forms.RadioButton();
            this.error_Btn = new System.Windows.Forms.RadioButton();
            this.asterisco_Btn = new System.Windows.Forms.RadioButton();
            this.mostrar_Btn = new System.Windows.Forms.Button();
            this.mostrar_Lbl = new System.Windows.Forms.Label();
            this.tipoBoton_Gbx.SuspendLayout();
            this.icono_Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoBoton_Gbx
            // 
            this.tipoBoton_Gbx.Controls.Add(this.reintentarCancelar_Btn);
            this.tipoBoton_Gbx.Controls.Add(this.siNo_Btn);
            this.tipoBoton_Gbx.Controls.Add(this.siNoCancelar_Btn);
            this.tipoBoton_Gbx.Controls.Add(this.abortarReintentarIgnorar_Btn);
            this.tipoBoton_Gbx.Controls.Add(this.cancelar_Btn);
            this.tipoBoton_Gbx.Controls.Add(this.aceptar_Btn);
            this.tipoBoton_Gbx.Location = new System.Drawing.Point(12, 39);
            this.tipoBoton_Gbx.Name = "tipoBoton_Gbx";
            this.tipoBoton_Gbx.Size = new System.Drawing.Size(228, 278);
            this.tipoBoton_Gbx.TabIndex = 0;
            this.tipoBoton_Gbx.TabStop = false;
            this.tipoBoton_Gbx.Text = "Tipo de Botón";
            // 
            // reintentarCancelar_Btn
            // 
            this.reintentarCancelar_Btn.AutoSize = true;
            this.reintentarCancelar_Btn.Location = new System.Drawing.Point(6, 143);
            this.reintentarCancelar_Btn.Name = "reintentarCancelar_Btn";
            this.reintentarCancelar_Btn.Size = new System.Drawing.Size(119, 17);
            this.reintentarCancelar_Btn.TabIndex = 5;
            this.reintentarCancelar_Btn.TabStop = true;
            this.reintentarCancelar_Btn.Text = "Reintentar Cancelar";
            this.reintentarCancelar_Btn.UseVisualStyleBackColor = true;
            this.reintentarCancelar_Btn.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckChanged);
            // 
            // siNo_Btn
            // 
            this.siNo_Btn.AutoSize = true;
            this.siNo_Btn.Location = new System.Drawing.Point(6, 120);
            this.siNo_Btn.Name = "siNo_Btn";
            this.siNo_Btn.Size = new System.Drawing.Size(51, 17);
            this.siNo_Btn.TabIndex = 4;
            this.siNo_Btn.TabStop = true;
            this.siNo_Btn.Text = "Si No";
            this.siNo_Btn.UseVisualStyleBackColor = true;
            this.siNo_Btn.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckChanged);
            // 
            // siNoCancelar_Btn
            // 
            this.siNoCancelar_Btn.AutoSize = true;
            this.siNoCancelar_Btn.Location = new System.Drawing.Point(6, 97);
            this.siNoCancelar_Btn.Name = "siNoCancelar_Btn";
            this.siNoCancelar_Btn.Size = new System.Drawing.Size(96, 17);
            this.siNoCancelar_Btn.TabIndex = 3;
            this.siNoCancelar_Btn.TabStop = true;
            this.siNoCancelar_Btn.Text = "Si No Cancelar";
            this.siNoCancelar_Btn.UseVisualStyleBackColor = true;
            this.siNoCancelar_Btn.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckChanged);
            // 
            // abortarReintentarIgnorar_Btn
            // 
            this.abortarReintentarIgnorar_Btn.AutoSize = true;
            this.abortarReintentarIgnorar_Btn.Location = new System.Drawing.Point(6, 74);
            this.abortarReintentarIgnorar_Btn.Name = "abortarReintentarIgnorar_Btn";
            this.abortarReintentarIgnorar_Btn.Size = new System.Drawing.Size(147, 17);
            this.abortarReintentarIgnorar_Btn.TabIndex = 2;
            this.abortarReintentarIgnorar_Btn.TabStop = true;
            this.abortarReintentarIgnorar_Btn.Text = "Abortar Reintentar Ignorar";
            this.abortarReintentarIgnorar_Btn.UseVisualStyleBackColor = true;
            this.abortarReintentarIgnorar_Btn.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckChanged);
            // 
            // cancelar_Btn
            // 
            this.cancelar_Btn.AutoSize = true;
            this.cancelar_Btn.Location = new System.Drawing.Point(6, 51);
            this.cancelar_Btn.Name = "cancelar_Btn";
            this.cancelar_Btn.Size = new System.Drawing.Size(107, 17);
            this.cancelar_Btn.TabIndex = 1;
            this.cancelar_Btn.TabStop = true;
            this.cancelar_Btn.Text = "Aceptar Cancelar";
            this.cancelar_Btn.UseVisualStyleBackColor = true;
            this.cancelar_Btn.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckChanged);
            // 
            // aceptar_Btn
            // 
            this.aceptar_Btn.AutoSize = true;
            this.aceptar_Btn.Location = new System.Drawing.Point(6, 28);
            this.aceptar_Btn.Name = "aceptar_Btn";
            this.aceptar_Btn.Size = new System.Drawing.Size(62, 17);
            this.aceptar_Btn.TabIndex = 0;
            this.aceptar_Btn.TabStop = true;
            this.aceptar_Btn.Text = "Aceptar";
            this.aceptar_Btn.UseVisualStyleBackColor = true;
            this.aceptar_Btn.CheckedChanged += new System.EventHandler(this.tipoBoton_CheckChanged);
            // 
            // icono_Gbx
            // 
            this.icono_Gbx.Controls.Add(this.informacion_Btn);
            this.icono_Gbx.Controls.Add(this.pregunta_Btn);
            this.icono_Gbx.Controls.Add(this.alto_Btn);
            this.icono_Gbx.Controls.Add(this.advertencia_Btn);
            this.icono_Gbx.Controls.Add(this.mano_Btn);
            this.icono_Gbx.Controls.Add(this.exclamacion_Btn);
            this.icono_Gbx.Controls.Add(this.error_Btn);
            this.icono_Gbx.Controls.Add(this.asterisco_Btn);
            this.icono_Gbx.Location = new System.Drawing.Point(251, 39);
            this.icono_Gbx.Name = "icono_Gbx";
            this.icono_Gbx.Size = new System.Drawing.Size(156, 329);
            this.icono_Gbx.TabIndex = 1;
            this.icono_Gbx.TabStop = false;
            this.icono_Gbx.Text = "Icono";
            // 
            // informacion_Btn
            // 
            this.informacion_Btn.AutoSize = true;
            this.informacion_Btn.Location = new System.Drawing.Point(6, 120);
            this.informacion_Btn.Name = "informacion_Btn";
            this.informacion_Btn.Size = new System.Drawing.Size(80, 17);
            this.informacion_Btn.TabIndex = 8;
            this.informacion_Btn.TabStop = true;
            this.informacion_Btn.Text = "Información";
            this.informacion_Btn.UseVisualStyleBackColor = true;
            // 
            // pregunta_Btn
            // 
            this.pregunta_Btn.AutoSize = true;
            this.pregunta_Btn.Location = new System.Drawing.Point(6, 143);
            this.pregunta_Btn.Name = "pregunta_Btn";
            this.pregunta_Btn.Size = new System.Drawing.Size(68, 17);
            this.pregunta_Btn.TabIndex = 7;
            this.pregunta_Btn.TabStop = true;
            this.pregunta_Btn.Text = "Pregunta";
            this.pregunta_Btn.UseVisualStyleBackColor = true;
            // 
            // alto_Btn
            // 
            this.alto_Btn.AutoSize = true;
            this.alto_Btn.Location = new System.Drawing.Point(6, 166);
            this.alto_Btn.Name = "alto_Btn";
            this.alto_Btn.Size = new System.Drawing.Size(43, 17);
            this.alto_Btn.TabIndex = 6;
            this.alto_Btn.TabStop = true;
            this.alto_Btn.Text = "Alto";
            this.alto_Btn.UseVisualStyleBackColor = true;
            // 
            // advertencia_Btn
            // 
            this.advertencia_Btn.AutoSize = true;
            this.advertencia_Btn.Location = new System.Drawing.Point(6, 189);
            this.advertencia_Btn.Name = "advertencia_Btn";
            this.advertencia_Btn.Size = new System.Drawing.Size(82, 17);
            this.advertencia_Btn.TabIndex = 5;
            this.advertencia_Btn.TabStop = true;
            this.advertencia_Btn.Text = "Advertencia";
            this.advertencia_Btn.UseVisualStyleBackColor = true;
            // 
            // mano_Btn
            // 
            this.mano_Btn.AutoSize = true;
            this.mano_Btn.Location = new System.Drawing.Point(6, 97);
            this.mano_Btn.Name = "mano_Btn";
            this.mano_Btn.Size = new System.Drawing.Size(52, 17);
            this.mano_Btn.TabIndex = 4;
            this.mano_Btn.TabStop = true;
            this.mano_Btn.Text = "Mano";
            this.mano_Btn.UseVisualStyleBackColor = true;
            // 
            // exclamacion_Btn
            // 
            this.exclamacion_Btn.AutoSize = true;
            this.exclamacion_Btn.Location = new System.Drawing.Point(6, 74);
            this.exclamacion_Btn.Name = "exclamacion_Btn";
            this.exclamacion_Btn.Size = new System.Drawing.Size(85, 17);
            this.exclamacion_Btn.TabIndex = 3;
            this.exclamacion_Btn.TabStop = true;
            this.exclamacion_Btn.Text = "Exclamación";
            this.exclamacion_Btn.UseVisualStyleBackColor = true;
            // 
            // error_Btn
            // 
            this.error_Btn.AutoSize = true;
            this.error_Btn.Location = new System.Drawing.Point(6, 51);
            this.error_Btn.Name = "error_Btn";
            this.error_Btn.Size = new System.Drawing.Size(47, 17);
            this.error_Btn.TabIndex = 2;
            this.error_Btn.TabStop = true;
            this.error_Btn.Text = "Error";
            this.error_Btn.UseVisualStyleBackColor = true;
            // 
            // asterisco_Btn
            // 
            this.asterisco_Btn.AutoSize = true;
            this.asterisco_Btn.Location = new System.Drawing.Point(6, 28);
            this.asterisco_Btn.Name = "asterisco_Btn";
            this.asterisco_Btn.Size = new System.Drawing.Size(68, 17);
            this.asterisco_Btn.TabIndex = 1;
            this.asterisco_Btn.TabStop = true;
            this.asterisco_Btn.Text = "Asterisco";
            this.asterisco_Btn.UseVisualStyleBackColor = true;
            // 
            // mostrar_Btn
            // 
            this.mostrar_Btn.Location = new System.Drawing.Point(12, 397);
            this.mostrar_Btn.Name = "mostrar_Btn";
            this.mostrar_Btn.Size = new System.Drawing.Size(75, 23);
            this.mostrar_Btn.TabIndex = 2;
            this.mostrar_Btn.Text = "Mostrar";
            this.mostrar_Btn.UseVisualStyleBackColor = true;
            this.mostrar_Btn.Click += new System.EventHandler(this.mostrar_Btn_Click);
            // 
            // mostrar_Lbl
            // 
            this.mostrar_Lbl.AutoSize = true;
            this.mostrar_Lbl.Location = new System.Drawing.Point(12, 428);
            this.mostrar_Lbl.Name = "mostrar_Lbl";
            this.mostrar_Lbl.Size = new System.Drawing.Size(266, 13);
            this.mostrar_Lbl.TabIndex = 3;
            this.mostrar_Lbl.Text = "Selecciona un tipo de botón e icono y presiona mostrar";
            // 
            // PruebaRadioButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrar_Lbl);
            this.Controls.Add(this.mostrar_Btn);
            this.Controls.Add(this.icono_Gbx);
            this.Controls.Add(this.tipoBoton_Gbx);
            this.Name = "PruebaRadioButtonForm";
            this.Text = "Demostracion de los Controles RadioButton";
            this.tipoBoton_Gbx.ResumeLayout(false);
            this.tipoBoton_Gbx.PerformLayout();
            this.icono_Gbx.ResumeLayout(false);
            this.icono_Gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tipoBoton_Gbx;
        private System.Windows.Forms.GroupBox icono_Gbx;
        private System.Windows.Forms.RadioButton reintentarCancelar_Btn;
        private System.Windows.Forms.RadioButton siNo_Btn;
        private System.Windows.Forms.RadioButton siNoCancelar_Btn;
        private System.Windows.Forms.RadioButton abortarReintentarIgnorar_Btn;
        private System.Windows.Forms.RadioButton cancelar_Btn;
        private System.Windows.Forms.RadioButton aceptar_Btn;
        private System.Windows.Forms.RadioButton informacion_Btn;
        private System.Windows.Forms.RadioButton pregunta_Btn;
        private System.Windows.Forms.RadioButton alto_Btn;
        private System.Windows.Forms.RadioButton advertencia_Btn;
        private System.Windows.Forms.RadioButton mano_Btn;
        private System.Windows.Forms.RadioButton exclamacion_Btn;
        private System.Windows.Forms.RadioButton error_Btn;
        private System.Windows.Forms.RadioButton asterisco_Btn;
        private System.Windows.Forms.Button mostrar_Btn;
        private System.Windows.Forms.Label mostrar_Lbl;
    }
}

