﻿//============================================================
// Student Number	: S10198319, S10196678
// Student Name	: Tan Yuan Ming, Gladys
// Module  Group	: P08 //============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project
{
    abstract class Patient
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string CitizenStatus { get; set; }
        public string Status { get; set; }
        public Stay Stay { get; set; }

        public Patient(string id, string na, int ag, char gd, string ctz, string sts)
        {
            Id = id;
            Name = na;
            Age = ag;
            Gender = gd;
            CitizenStatus = ctz;
            Status = sts;
        }
        public abstract double CalculateCharges();
        public override string ToString()
        {
            return "ID: " + Id
                + "\tName: " + Name
                + "\tAge: " +  Age
                + "\tGender" + Gender
                + "\tCitizen Status: " + CitizenStatus
                + "\tStatus: " + Status;
        }
    }
}
