using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// 
/// App name - Sales Bonus
/// Author's name - Balpreeet Punia (200335082)
/// App Creation Date - 2017/01/29
/// Version 2.0 - 2017/01/30
/// App description - The app aims to calculate the bonus amount each employee which is based upon the percentage of hours 
///                   they've worked for during the bonus period.
/// 
/// </summary>
/// 

namespace Assignment1
{
    public partial class MailOrder : Form
    {

        //Private instance variables

        private string _name;
        private string _id;
        private string _totalhours;
        private string _totalsales;
        private double _salesbonus;

        public MailOrder()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        //This radio button changes the language to english, it is also the default.

        private void englishbutton_CheckedChanged(object sender, EventArgs e)
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

        //This radio button changes the language to French.

        private void frenchbutton_CheckedChanged(object sender, EventArgs e)
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

        //This radio button changes the language to Spanish.

        private void spanishbutton_CheckedChanged(object sender, EventArgs e)
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

        //Event handler for calculate button

        private void calculate_button_Click(object sender, EventArgs e)
        {
            //Checks if all fields are filled

            if (name_input.Text != "" && id_input.Text != "" && hours_input.Text != "")
            {
                //Check validation of the hours field

                if (int.Parse(hours_input.Text) < 161 && int.Parse(hours_input.Text) > -1)
                {
                    //Alorithm to calculate the sales bonus

                    double _percenthoursworked = double.Parse(_totalhours) / 160;
                    double _totalbonusamount = int.Parse(_totalsales) * 0.02;
                    _salesbonus = _percenthoursworked * _totalbonusamount;
            
                    //Variable to output sales bonus

                    bonus_output.Text = "$" + Convert.ToString(_salesbonus);
                    monthly_input.Text += "$" + monthly_input.Text;
                }

                //If hours are negative or more than 160
                else
                {
                    MessageBox.Show("Hours cannot be greater than 160 or less than 0", "Validate Number Of Hours");
                }
            }

            //If all text fields are not entered

            else
            {
                MessageBox.Show("Please enter all the fields", "Textbox Validation");
            }
        }

        //Event handler for print button

        private void print_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form is being sent to the printer","Printer");
        }

        //Event handler for clear button

        private void clear_button_Click(object sender, EventArgs e)
        {
            name_input.Clear();
            id_input.Clear();
            hours_input.Clear();
            bonus_output.Clear();
        }

        //Event handler for name text field

        private void name_input_TextChanged(object sender, EventArgs e)
        {
            _name = name_input.Text;
        }

        //Event handler for id text field

        private void id_input_TextChanged(object sender, EventArgs e)
        {
            _id = id_input.Text;
        }

        //Event handler for hours text field

        private void hours_input_TextChanged(object sender, EventArgs e)
        {
            _totalhours = hours_input.Text;
        }

        //Event handler for monthly sales text field

        private void monthly_input_TextChanged(object sender, EventArgs e)
        {

            _totalsales = monthly_input.Text;
        }
    }
}
