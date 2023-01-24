using System.Collections.Generic;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Models
{
    public class ParseCSV : MonoBehaviour
    {

        public static ParseCSV Data;

        public List<Obj> objects = new List<Obj>();
        public List<Suspect> suspects = new List<Suspect>();

        enum CSV_FILES
        {
            objects,
            suspects
        }

        public ParseCSV()
        {
            parsing(CSV_FILES.objects);
            parsing(CSV_FILES.suspects);
        }

        void Awake()
        {
            if (Data != null)
                GameObject.Destroy(Data);
            else
                Data = this;

            parsing(CSV_FILES.objects);
            parsing(CSV_FILES.suspects);
        }

        public void ResearchSuspect(string termToResearch)
        {
            StringBuilder suspectsBuilder = new StringBuilder();
            foreach (Suspect suspect in Data.suspects)
            {
                if (suspect.thirteenHour.Trim().ToUpper().Equals(termToResearch.ToUpper()))
                {
                    suspectsBuilder.Append(suspect.name);
                    suspectsBuilder.Append("-");
                }
            }

            StringBuilder objectsBuilder = new StringBuilder();
            foreach (Obj obj in Data.objects)
            {
                if (obj.location.Trim().ToUpper().Equals(termToResearch.ToUpper()))
                {
                    objectsBuilder.Append(obj.title);
                    objectsBuilder.Append("-");
                }
            }

            Text locationText = GameObject.Find("Canvas/LocationText").GetComponent<Text>();
            locationText.text = termToResearch;

            TextMeshProUGUI suspectsText = GameObject.Find("Canvas/SuspectsText").GetComponent<TextMeshProUGUI>();
            string suspectsString = suspectsBuilder.ToString();
            if(suspectsString.Length > 0)
            {
                suspectsString = suspectsString.Remove(suspectsString.Length - 1);
            }
            suspectsText.text = "<b>Suspects</b> : " + suspectsString;

            TextMeshProUGUI objectsText = GameObject.Find("Canvas/ObjectsText").GetComponent<TextMeshProUGUI>();
            string objectsString = objectsBuilder.ToString();
            if (objectsString.Length > 0)
            {
                objectsString = objectsString.Remove(objectsString.Length - 1);
            }
            objectsText.text = "<b>Objects</b> : " + objectsString;
        }

        private static void parsing(CSV_FILES sourceFileName)
        {
            using (StreamReader parser = new StreamReader($"C:/Users/user/Documents/SI5/Multimodal/rendu/TIM-project/AR/Assets/CSV/{sourceFileName.ToString()}.csv"))
            {

                while (!parser.EndOfStream)
                {
                    string line = parser.ReadLine();
                    string[] fields = line.Split(',');
                    int i = 0;

                    if (sourceFileName == CSV_FILES.objects)
                    {
                        Data.objects.Add(new Obj(fields[i++], fields[i++], fields[i++]));
                    }

                    if (sourceFileName == CSV_FILES.suspects)
                    {
                        Data.suspects.Add(new Suspect(fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++], fields[i++]));
                    }
                }
            }
        }
    }
}