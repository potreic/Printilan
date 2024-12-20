﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPrintilanApp;

namespace UIPrintilanApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }


        private void btnToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide(); // Sembunyikan form sign-up
            SignUp SignUpForm = new SignUp(); // Asumsikan kamu punya form login
            SignUpForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Buat objek Employee dengan username dan password dari input (misal dari TextBox)
            Employee employee = new Employee(tbUsername.Text, tbPassword.Text);

            // Cek login
            if (employee.Login())
            {
                // Jika login berhasil, tampilkan pesan
                MessageBox.Show("Login Berhasil, ID anda adalah " + employee.EmployeeID.ToString(), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Store the user information in UserSession
                UserSession.UserId = employee.EmployeeID;
                //UserSession.Username = tbUsername.Text; // Optionally store username/email
                //UserSession.Email = tbEmail.Text; // Optionally store email

                // Sembunyikan form login
                this.Hide();

                // Tampilkan form homepage
                Homepage homePage = new Homepage(); // Pastikan menggunakan nama yang benar
                homePage.Show(); // Tampilkan Homepage
            }
            else
            {
                // Jika login gagal, tampilkan pesan error
                MessageBox.Show("Login Gagal, Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}