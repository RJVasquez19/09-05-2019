﻿using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmVendor : Form
    {

        manttoVendor obj = new manttoVendor();

        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(obj.prueba());
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            obj.CodigoVendor = txtCodigoVen.Text; 
            obj.NombreVendor = txtNombreVen.Text;
            obj.insertarVendor();
            limpiar();
            cargar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            obj.CodigoVendor = txtCodigoVen.Text; 
            
            obj.consultar();
            txtCodigoVen.Text = obj.CodigoVendor;
            txtNombreVen.Text = obj.NombreVendor;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            obj.CodigoVendor = txtCodigoVen.Text;
            obj.NombreVendor = txtNombreVen.Text;
            obj.updateVendor();
            limpiar();
            cargar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        public void limpiar() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar() 
        {
            obj.mostrarVendor();
            dataGridView1.DataSource = obj.dt;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            obj.CodigoVendor = txtCodigoVen.Text;
            obj.NombreVendor = txtNombreVen.Text;
            obj.deleteVendor();
            limpiar();
            cargar();
        }
    }
}
