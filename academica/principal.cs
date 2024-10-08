﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objForm = new Form1();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias objForm = new materias();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objForm = new Form2();
            objForm.MdiParent = this;
            objForm.Show();
        }
    }
}
