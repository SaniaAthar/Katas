﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduler.Exceptions;
using Scheduler.Models;

namespace Scheduler
{
    public partial class CaseWorkerVisualSchedule : UserControl
    {
        private readonly Action _meetingAddedHandlar;
        private readonly CaseWorker _caseWorker;

        public CaseWorkerVisualSchedule(CaseWorker caseWorker, Action meetingAddedHandlar)
        {
            _meetingAddedHandlar = meetingAddedHandlar;
        }

        {
            _caseWorker = caseWorker;
            InitializeComponent();

            label_CaseWorkerName.Text = _caseWorker.Name;
            dateTimePicker.Format = DateTimePickerFormat.Custom;

            button_Add.Click += Button_Add_Click;
            button_ChangeDate.Click += Button_ChangeDate_Click;

            RefreshDisplayedMeetings();
        }

        private void Button_ChangeDate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox_Meetings.SelectedIndex;
                _caseWorker.ChangeMeeting(index, dateTimePicker.value);
                RefreshDisplayedMeetings();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
               int index = listBox_Meetings.SelectedIndex; 


            _caseWorker.ChangeMeeting(index, dateTimePicker.Value);
            RefreshDisplayedMeetings();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            _caseWorker.NewDateAdded(dateTimePicker.Value);
            RefreshDisplayedMeetings();
        }

        public void RefreshDisplayedMeetings()
        {
            List<string> content = new List<string>();

            foreach (Meeting meeting in _caseWorker.Meetings)
            {
                content.Add(meeting.ToString());
            }

            listBox_Meetings.DataSource = content;
        }
    }
}
