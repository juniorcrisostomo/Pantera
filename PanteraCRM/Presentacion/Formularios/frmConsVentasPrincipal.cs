﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmConsVentasPrincipal : Form
    {
        public frmConsVentasPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            frmConsVentasDetalle f = new frmConsVentasDetalle();
            f.ShowDialog();
        }
    }
}
