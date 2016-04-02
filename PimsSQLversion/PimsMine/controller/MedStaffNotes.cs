using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class MedStaffNotes
    {
        public struct patientStats
        {
            public DateTime time;
            public int patientWeight;
            public int patientHeight;
            public int bloodPressureSys;
            public int bloodPressureDia;
            public int heartrate;
            public patientStats(DateTime when, int weight, int height, int sys, int dia, int hr)
            {
                time = when;
                patientWeight = weight;
                patientHeight = height;
                bloodPressureDia = dia;
                bloodPressureSys = sys;
                heartrate = hr;
            }

        }
        public List<patientStats> statList = new List<patientStats>();
        public string nurseNotes;
        public string allergies;
        public MedStaffNotes()
        {
            statList.Add(new patientStats(new DateTime(1980,1,1), 150, 56, 120, 70, 60));
            statList.Add(new patientStats(new DateTime(1990,1,1), 150, 56, 120, 70, 60));
            statList.Add(new patientStats(new DateTime(2000,1,1), 150, 56, 120, 70, 60));
            statList.Add(new patientStats(new DateTime(2010,1,1), 150, 56, 120, 70, 60));

        }
    }
}
