﻿using DormintoryStudentApp.Entity;
using DormintoryStudentApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormintoryStudentApp.UI
{
    public partial class ChangeRoomRequestForm : Form
    {
        Student theStudent;
        public ChangeRoomRequestForm()
        {
            InitializeComponent();
        }
        public ChangeRoomRequestForm(Student theStudent)
        {
            InitializeComponent();
            this.theStudent = theStudent;
        }

        public void loadData()
        {
            StudentDAL studentDAL = new StudentDAL();
            RoomDAL roomDAL = new RoomDAL();
            Slot slot = roomDAL.getSlotByStudentID(theStudent.studentID);
            nameField.Text = theStudent.name;
            idField.Text = theStudent.studentID;
            slotField.Text = slot.slotNumber.ToString();
            roomField.Text = slot.roomID;

            DataTable allAvailableRoomTable = roomDAL.getAllRoomWhichHaveAvailableSlot();
            toRoomCombobox.DataSource = allAvailableRoomTable;
            toRoomCombobox.DisplayMember = "roomID";
            toRoomCombobox.ValueMember = "roomID";

            loadSlot(toRoomCombobox.SelectedValue.ToString());

        }
        // load slot available from room
        public void loadSlot(string roomName)
        {
            toSlotCombobox.DataSource = null;
            DataTable allSlotAvailableFromRoom = new RoomDAL().getAvailableSlotByRoomName(roomName);
            toSlotCombobox.DataSource = allSlotAvailableFromRoom;
            toSlotCombobox.DisplayMember = "slotNumber";
            toSlotCombobox.ValueMember = "slotNumber";
        }

        private void ChangeRoomRequestForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public bool isNumberic(string slotNumber)
        {
            try
            {
                int slot = int.Parse(slotNumber);
                return true;
            }catch
            {
                return false;
            }
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            string toRoom = toRoomCombobox.SelectedValue.ToString();
            string toSlot = toSlotCombobox.SelectedValue.ToString();

            if(toRoom=="" || toSlot=="")
            {
                MessageBox.Show("Destination of Room and Slot required!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else if (!isNumberic(toSlot))
            {
                MessageBox.Show("Slot have to be an integer!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else if (!(new RoomDAL().isRoomExisted(toRoom))) {
                MessageBox.Show("This room is not existed", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else 
            {
                DataTable availableRoom = new RoomDAL().getAvailableRoomByInput(toRoom);
                if ( !(availableRoom.Rows.Count > 0))
                {
                    message.Text = "Room " + toRoom + " is full";
                    return;
                }
                else
                {
                    // insert
                    bool successInsert = new RequestDAL().addChangeRoomRequest(theStudent.studentID, slotField.Text, roomField.Text, contentField.Text, toSlot, toRoom, "1");
                    if (successInsert)
                    {
                        MessageBox.Show("Request has sent!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Send fail", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            } 
            
        }

        private void toRoomCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string selectedValue = cb.SelectedValue.ToString();
            loadSlot(selectedValue);
        }

        private void toRoomCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void toSlotCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
