using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class button_script : MonoBehaviour
{

    //public GameObject postOfficeButton;
    //public GameObject pizzeriaButton;
    //public GameObject marketButton;
    //public GameObject theaterButton;
    //public GameObject neighbourhoodButton;

    void Start()
    {
        //postOfficeButton = GameObject.Find("PostOfficeButton");
        //pizzeriaButton = GameObject.Find("PizzariaButton");
        //marketButton = GameObject.Find("MarketButton");
        //theaterButton = GameObject.Find("TheaterButton");
        //neighbourhoodButton = GameObject.Find("NeighbourhoodButton");
        //postOfficeButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //pizzeriaButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //marketButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //theaterButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        //neighbourhoodButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Debug.Log("btn pressed");

        //Text myText = GameObject.Find("Canvas/MyText").GetComponent<Text>();
        //myText.text = vb.ToString();
    }

    void Update()
    {
        
    }
}
