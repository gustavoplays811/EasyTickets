﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTickets.Views
{
    public partial class TelaFundo : Form
    {
        public TelaFundo()
        {
            InitializeComponent();
        }

        private void TelaFundo_Activated(object sender, EventArgs e)
        {
            Abertura janela = new Abertura();
            janela.ShowDialog();
            Application.Exit();
           
        }
    }
}
