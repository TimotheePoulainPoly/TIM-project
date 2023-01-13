using Models;
using UnityEngine;
using Vuforia;

public class PizzaTouch : MonoBehaviour
{
    public GameObject pizzeriaButton;

    void Start()
    {
        pizzeriaButton = GameObject.Find("PizzeriaButton");
        pizzeriaButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        print("Pressed in Pizzeria");
        ParseCSV.Data.ResearchSuspect("Pizzeria");
    }
}
