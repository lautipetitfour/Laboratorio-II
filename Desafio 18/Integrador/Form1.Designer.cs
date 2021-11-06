
namespace Integrador
{
    partial class Form1
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
        

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxTipoPrenda;
        private System.Windows.Forms.CheckBox checkBoxBermuda;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.RadioButton radioButtonPantalon;
        private System.Windows.Forms.RadioButton radioButtonCamisa;
        private System.Windows.Forms.GroupBox groupBoxCalidadPrenda;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.GroupBox groupBoxPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.GroupBox groupBoxCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button buttonCalculoPrecioFinal;
    }
}

