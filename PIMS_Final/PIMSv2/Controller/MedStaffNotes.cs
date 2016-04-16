using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class MedStaffNotes
    {
        public class patientStats
        {
            public int idNum; // Id
            public DateTime time;
            public int patientHeight; //would it be possible to make this  a string 5'6 instead of 56
            public int patientWeight;
            public int bloodPressureSys;
            public int bloodPressureDia;
            public int heartrate;
            public string nurse;

            public patientStats(DateTime when, int weight, int height, int sys, int dia, int hr)
            {
                idNum = 0;
                time = when;
                patientWeight = weight;
                patientHeight = height;
               // patientHeight = String.Copy(height);
                bloodPressureDia = dia;
                bloodPressureSys = sys;
                heartrate = hr;
            }

            public patientStats()
            {

            }
        }

        public List<patientStats> statList;
        public string nurseNotes;
        public string allergies;

        public MedStaffNotes()
        {
            statList = new List<patientStats>();
        }
    }
}
