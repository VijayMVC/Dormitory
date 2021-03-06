﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DormintoryStudentApp.Entity;
using DormintoryStudentApp.Model;
using DormintoryStudentApp.UI;

namespace DormintoryStudentApp
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "" || password == "") // username or password is empty
            {
                MessageBox.Show("Username and password are required!");
                return;
            } else // have entered username and password
            {
                StudentAccount theAccount = new StudentDAL().studentLogin(username, password);
                if (theAccount != null) // correct username and password
                {
                    // create this student
                    Student theStudent = new StudentDAL().getTheStudent(theAccount.studentID);
                    this.Hide();
                    ManagementForm managerWindow = new ManagementForm(theAccount, theStudent);
                    managerWindow.Show();
                }
                else // wrong username or password
                {
                    errorMessage.ForeColor = Color.Yellow;
                    errorMessage.Text = "Wrong username or password";
                }
            }
            
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            errorMessage.Text = "";
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
