using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspect
{
    string sName, sGender, sHairColor, sRelation, sTransport, sClothing;
    string[] locations = new string[5];
    int sHeight;

    // Start is called before the first frame update
    public Suspect(
        string name,
        string gender,
        string onePM,
        string twoPM,
        string threePM,
        string fourPM,
        string fivePM,
        string hairColor,
        int height,
        string relation,
        string transport,
        string clothing)
    {
        sName = name;
        sGender = gender;
        locations[0] = onePM;
        locations[1] = twoPM;
        locations[2] = threePM;
        locations[3] = fourPM;
        locations[4] = fivePM;
        sHairColor = hairColor;
        sHeight = height;
        sRelation = relation;
        sTransport = transport;
        sClothing = clothing;
    }

    public string getName()
    {
        return sName;
    }


    // function to return the location of the person at a specific time
    public string queryTime(int time)
    {
        if (time <= 17 && time >= 13)
        {
            return locations[time-13];
        }
        else return "time not existant";
    }

}
