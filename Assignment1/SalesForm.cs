using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Employee Name:";
            label2.Text = "Employee ID:";
            label3.Text = "Total Hours Worked:";
            label4.Text = "Total Monthly Sales:";
            label5.Text = "Sales Bonus:";
            calculate_button.Text = "Calculate";
            print_button.Text = "Print";
            clear_button.Text = "Clear";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nom de l'employé:";
            label2.Text = "ID employé:";
            label3.Text = "Heures travaillées:";
            label4.Text = "Ventes totales:";
            label5.Text = "Bonus de vente:";
            calculate_button.Text = "Calculer";
            print_button.Text = "Impression";
            clear_button.Text = "Clair";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nombre de Empleado";
            label2.Text = "ID de empleado:";
            label3.Text = "Horas trabajadas:";
            label4.Text = "Ventas mensuales:";
            label5.Text = "Bonificación de ventas:";
            calculate_button.Text = "Calcular";
            print_button.Text = "Impresión";
            clear_button.Text = "Claro";
        }
    }
}
