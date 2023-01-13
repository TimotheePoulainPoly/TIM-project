using Models;
using UnityEngine;
using Vuforia;

public class TheaterTouch : MonoBehaviour
{
    public GameObject theaterButton;

    void Start()
    {
        theaterButton = GameObject.Find("TheaterButton");
        theaterButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        print("Pressed in Theater");
        ParseCSV.Data.ResearchSuspect("Theater");
    }
}
