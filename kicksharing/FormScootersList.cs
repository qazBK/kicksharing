using kicksharing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kicksharing
{
    public partial class FormScootersList : Form
    {
        public User CurentUser { get; private set; }
        public bool IsGauste { get; private set; }
        public FormScootersList(User CurentUser, bool IsGauste)
        {
            InitializeComponent();

            if (CurentUser != null)
            {
                LbName.Text = CurentUser.FullName;
            }
            else {
                LbName.Text = "Гость";
                    }
        }

        private void BtnLogaut_Click(object sender, EventArgs e)
        {
            CurentUser = null;
            IsGauste = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
