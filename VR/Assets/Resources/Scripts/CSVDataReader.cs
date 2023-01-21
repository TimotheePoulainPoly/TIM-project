using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSVDataReader : MonoBehaviour
{
    TextAsset suspectsFile;
    TextAsset objectsFile;

    List<Suspect> listOfSuspects = new List<Suspect>();
    List<ObjectOfInterest> listOfObjects = new List<ObjectOfInterest>();
    public Canvas myCanvas;

    // Start is called before the first frame update
    void Start()
    {
        suspectsFile = Resources.Load<TextAsset>("suspects");
        objectsFile = Resources.Load<TextAsset>("objects");

        string[] objects = objectsFile.ToString().Split('\n');
        string[] suspects = suspectsFile.ToString().Split('\n');

        for(int i = 1; i< objects.Length; i++)
        {
            string[] tmp = objects[i].Split(',');
            listOfObjects.Add(new ObjectOfInterest(tmp[0], tmp[1], tmp[2]));
        }

        for (int i = 1; i < suspects.Length; i++)
        {
            string[] tmp = suspects[i].Split(',');
            listOfSuspects.Add(
                new Suspect(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5], tmp[6], tmp[7], int.Parse(tmp[8]), tmp[9], tmp[10], tmp[11])
            );
        }

        myCanvas.GetComponentInChildren<Text>().text = listOfSuspects[0].getName()+" was at " + listOfSuspects[0].queryTime(14) + " at 14h.";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
