using Models;
using UnityEngine;
using Vuforia;

public class MarketTouch : MonoBehaviour
{
    public GameObject marketButton;

    void Start()
    {
        marketButton = GameObject.Find("MarketButton");
        marketButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        print("Pressed in Market");
        ParseCSV.Data.ResearchSuspect("Market");
    }
}
