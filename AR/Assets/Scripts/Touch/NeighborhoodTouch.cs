using Models;
using UnityEngine;
using Vuforia;

public class NeighborhoodTouch : MonoBehaviour
{
    public GameObject neighborhoodButton;

    void Start()
    {
        neighborhoodButton = GameObject.Find("NeighborhoodButton");
        neighborhoodButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        print("Pressed in Neighborhood");
        ParseCSV.Data.ResearchSuspect("Neighborhood");
    }
}
