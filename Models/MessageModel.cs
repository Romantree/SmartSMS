﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Carriage_SMS_Project.Views.MessageView;

namespace Carriage_SMS_Project.Models
{
    public class MessageModel
    {
        private int sabun;
        private string check;
        private string message;
        private string name1;
        private string name2;
        private string name3;

        public int Sabun
        {
            get { return sabun; }
            set { sabun = value; }
        }

        public string Check
        {
            get { return check; }
            set { check = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value;   }
        }
       
        public string Name1
        {
            get { return name1; }
            set { name1 = value; }
        }

        public string Name2
        {
            get { return name2; }
            set { name2 = value; }
        }

        public string Name3
        {
            get { return name3; }
            set { name3 = value; }
        }


    }
}