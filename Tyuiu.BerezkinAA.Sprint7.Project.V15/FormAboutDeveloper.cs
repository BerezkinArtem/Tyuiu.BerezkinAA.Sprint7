﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BerezkinAA.Sprint7.Project.V15
{
    public partial class FormAboutDeveloper : Form
    {
        public FormAboutDeveloper()
        {
            InitializeComponent();
        }
        private void buttonOK_BAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}