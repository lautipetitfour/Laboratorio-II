using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1 Form11
        {
            get => default;
            set
            {
            }
        }

        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxTipoPrenda = new System.Windows.Forms.GroupBox();
            this.checkBoxBermuda = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.groupBoxCalidadPrenda = new System.Windows.Forms.GroupBox();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.groupBoxPrecio = new System.Windows.Forms.GroupBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.groupBoxCantidad = new System.Windows.Forms.GroupBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonCalculoPrecioFinal = new System.Windows.Forms.Button();
            this.groupBoxTipoPrenda.SuspendLayout();
            this.groupBoxCalidadPrenda.SuspendLayout();
            this.groupBoxPrecio.SuspendLayout();
            this.groupBoxCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(206, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "VENTAS AL POR MAYOR - PradBit";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxTipoPrenda
            // 
            this.groupBoxTipoPrenda.Controls.Add(this.checkBoxBermuda);
            this.groupBoxTipoPrenda.Controls.Add(this.checkBoxMangaCorta);
            this.groupBoxTipoPrenda.Controls.Add(this.radioButtonPantalon);
            this.groupBoxTipoPrenda.Controls.Add(this.radioButtonCamisa);
            this.groupBoxTipoPrenda.Location = new System.Drawing.Point(15, 39);
            this.groupBoxTipoPrenda.Name = "groupBoxTipoPrenda";
            this.groupBoxTipoPrenda.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTipoPrenda.TabIndex = 1;
            this.groupBoxTipoPrenda.TabStop = false;
            this.groupBoxTipoPrenda.Text = "Tipo de Prenda";
            // 
            // checkBoxBermuda
            // 
            this.checkBoxBermuda.AutoSize = true;
            this.checkBoxBermuda.Enabled = false;
            this.checkBoxBermuda.Location = new System.Drawing.Point(105, 64);
            this.checkBoxBermuda.Name = "checkBoxBermuda";
            this.checkBoxBermuda.Size = new System.Drawing.Size(68, 17);
            this.checkBoxBermuda.TabIndex = 3;
            this.checkBoxBermuda.Text = "Bermuda";
            this.checkBoxBermuda.UseVisualStyleBackColor = true;
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(105, 31);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.checkBoxMangaCorta.TabIndex = 2;
            this.checkBoxMangaCorta.Text = "Manga Corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Location = new System.Drawing.Point(7, 64);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPantalon.TabIndex = 1;
            this.radioButtonPantalon.Text = "Pantalón";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            this.radioButtonPantalon.CheckedChanged += new System.EventHandler(this.radioButtonPantalon_CheckedChanged);
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Checked = true;
            this.radioButtonCamisa.Location = new System.Drawing.Point(7, 31);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCamisa.TabIndex = 0;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisa";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            this.radioButtonCamisa.CheckedChanged += new System.EventHandler(this.radioButtonCamisa_CheckedChanged);
            // 
            // groupBoxCalidadPrenda
            // 
            this.groupBoxCalidadPrenda.Controls.Add(this.radioButtonPremium);
            this.groupBoxCalidadPrenda.Controls.Add(this.radioButtonStandard);
            this.groupBoxCalidadPrenda.Location = new System.Drawing.Point(15, 157);
            this.groupBoxCalidadPrenda.Name = "groupBoxCalidadPrenda";
            this.groupBoxCalidadPrenda.Size = new System.Drawing.Size(200, 73);
            this.groupBoxCalidadPrenda.TabIndex = 2;
            this.groupBoxCalidadPrenda.TabStop = false;
            this.groupBoxCalidadPrenda.Text = "Calidad de Prenda";
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(105, 33);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(65, 17);
            this.radioButtonPremium.TabIndex = 1;
            this.radioButtonPremium.Text = "Premium";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Checked = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(7, 33);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(68, 17);
            this.radioButtonStandard.TabIndex = 0;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrecio
            // 
            this.groupBoxPrecio.Controls.Add(this.textBoxPrecio);
            this.groupBoxPrecio.Location = new System.Drawing.Point(15, 249);
            this.groupBoxPrecio.Name = "groupBoxPrecio";
            this.groupBoxPrecio.Size = new System.Drawing.Size(94, 50);
            this.groupBoxPrecio.TabIndex = 3;
            this.groupBoxPrecio.TabStop = false;
            this.groupBoxPrecio.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(7, 20);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(81, 20);
            this.textBoxPrecio.TabIndex = 0;
            // 
            // groupBoxCantidad
            // 
            this.groupBoxCantidad.Controls.Add(this.textBoxCantidad);
            this.groupBoxCantidad.Location = new System.Drawing.Point(120, 249);
            this.groupBoxCantidad.Name = "groupBoxCantidad";
            this.groupBoxCantidad.Size = new System.Drawing.Size(95, 50);
            this.groupBoxCantidad.TabIndex = 4;
            this.groupBoxCantidad.TabStop = false;
            this.groupBoxCantidad.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(7, 20);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(80, 20);
            this.textBoxCantidad.TabIndex = 0;
            // 
            // buttonCalculoPrecioFinal
            // 
            this.buttonCalculoPrecioFinal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCalculoPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculoPrecioFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCalculoPrecioFinal.Location = new System.Drawing.Point(15, 306);
            this.buttonCalculoPrecioFinal.Name = "buttonCalculoPrecioFinal";
            this.buttonCalculoPrecioFinal.Size = new System.Drawing.Size(200, 53);
            this.buttonCalculoPrecioFinal.TabIndex = 5;
            this.buttonCalculoPrecioFinal.Text = "Calcular Precio Final";
            this.buttonCalculoPrecioFinal.UseVisualStyleBackColor = false;
            this.buttonCalculoPrecioFinal.Click += new System.EventHandler(this.buttonCalculoPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(232, 368);
            this.Controls.Add(this.buttonCalculoPrecioFinal);
            this.Controls.Add(this.groupBoxCantidad);
            this.Controls.Add(this.groupBoxPrecio);
            this.Controls.Add(this.groupBoxCalidadPrenda);
            this.Controls.Add(this.groupBoxTipoPrenda);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Ventas al por mayor";
            this.groupBoxTipoPrenda.ResumeLayout(false);
            this.groupBoxTipoPrenda.PerformLayout();
            this.groupBoxCalidadPrenda.ResumeLayout(false);
            this.groupBoxCalidadPrenda.PerformLayout();
            this.groupBoxPrecio.ResumeLayout(false);
            this.groupBoxPrecio.PerformLayout();
            this.groupBoxCantidad.ResumeLayout(false);
            this.groupBoxCantidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMangaCorta.Enabled = true;
            checkBoxBermuda.Enabled = false;
        }

        private void radioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBermuda.Enabled = true;
            checkBoxMangaCorta.Enabled = false;
        }

        private void buttonCalculoPrecioFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonCamisa.Checked)
                {
                    int cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    double precioBase = Convert.ToDouble(textBoxPrecio.Text);

                    Camisa camisa1 = new Camisa(checkBoxMangaCorta.Checked,cantidad, precioBase,radioButtonStandard.Checked, radioButtonPremium.Checked);


                    MessageBox.Show("Precio Final $" + camisa1.CalcularPrecioFinal());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado. \nVerifique llenar todos los datos de manera correcta.");
            }

            try
            {
                if (radioButtonPantalon.Checked)
                {
                    int cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    double precioBase = Convert.ToDouble(textBoxPrecio.Text);

                    Pantalon pantalon1 = new Pantalon(checkBoxBermuda.Checked,cantidad, precioBase,radioButtonStandard.Checked, radioButtonPremium.Checked);


                    MessageBox.Show("Precio Final $" + pantalon1.CalcularPrecioFinal());

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado. \nVerifique llenar todos los datos de manera correcta.");
            }

        }
    }
}



