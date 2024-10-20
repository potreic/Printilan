﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrintilanApp
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            this.Hide(); // close the Product window
            DM DMForm = new DM(); // construct DM Form
            DMForm.Show(); // show DM Form
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DM DMForm = new DM();
            DMForm.Show();
        }

        private void btnWish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infokan profile bang @Rore", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit Printilan App?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}