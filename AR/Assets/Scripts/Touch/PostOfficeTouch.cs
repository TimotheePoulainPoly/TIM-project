using Models;
using UnityEngine;
using Vuforia;

public class PostOfficeTouch : MonoBehaviour
{
    public GameObject postOfficeButton;

    void Start()
    {
        postOfficeButton = GameObject.Find("PostOfficeButton");
        postOfficeButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        print("Pressed in PostOffice");
        ParseCSV.Data.ResearchSuspect("PostOffice");
    }
}
