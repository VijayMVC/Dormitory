﻿namespace DormitoryManager
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentRequests = new System.Windows.Forms.Button();
            this.UpdateRoom = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLeaveRoomRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormitory Manager";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLeaveRoomRequest);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.StudentRequests);
            this.panel1.Controls.Add(this.UpdateRoom);
            this.panel1.Controls.Add(this.AddRoom);
            this.panel1.Location = new System.Drawing.Point(26, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 338);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Room\'s Informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentRequests
            // 
            this.StudentRequests.Location = new System.Drawing.Point(33, 108);
            this.StudentRequests.Name = "StudentRequests";
            this.StudentRequests.Size = new System.Drawing.Size(298, 23);
            this.StudentRequests.TabIndex = 3;
            this.StudentRequests.Text = "View Change Room Requests";
            this.StudentRequests.UseVisualStyleBackColor = true;
            this.StudentRequests.Click += new System.EventHandler(this.StudentRequests_Click);
            // 
            // UpdateRoom
            // 
            this.UpdateRoom.Location = new System.Drawing.Point(33, 64);
            this.UpdateRoom.Name = "UpdateRoom";
            this.UpdateRoom.Size = new System.Drawing.Size(298, 23);
            this.UpdateRoom.TabIndex = 2;
            this.UpdateRoom.Text = "Update Room\'s Fee";
            this.UpdateRoom.UseVisualStyleBackColor = true;
            this.UpdateRoom.Click += new System.EventHandler(this.UpdateRoom_Click);
            // 
            // AddRoom
            // 
            this.AddRoom.Location = new System.Drawing.Point(33, 21);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(298, 23);
            this.AddRoom.TabIndex = 0;
            this.AddRoom.Text = "Add New Room";
            this.AddRoom.UseVisualStyleBackColor = true;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(409, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 338);
            this.panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(298, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Change Room";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 108);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Update Student Status";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 67);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 19);
            this.button3.TabIndex = 4;
            this.button3.Text = "Student Checkout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "Student Checkin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLeaveRoomRequest
            // 
            this.btnLeaveRoomRequest.Location = new System.Drawing.Point(33, 153);
            this.btnLeaveRoomRequest.Name = "btnLeaveRoomRequest";
            this.btnLeaveRoomRequest.Size = new System.Drawing.Size(298, 23);
            this.btnLeaveRoomRequest.TabIndex = 5;
            this.btnLeaveRoomRequest.Text = "View Leave Room Requests";
            this.btnLeaveRoomRequest.UseVisualStyleBackColor = true;
            this.btnLeaveRoomRequest.Click += new System.EventHandler(this.btnLeaveRoomRequest_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UpdateRoom;
        private System.Windows.Forms.Button StudentRequests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnLeaveRoomRequest;
    }
}

