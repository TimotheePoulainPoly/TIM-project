using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseToRay : MonoBehaviour
{
    
    public Camera mycam;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = mycam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            objectHit.GetComponent<Renderer>().material.color = Color.red;
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(0, 1, 0);

            //Text myText = GameObject.Find("Canvas/MyText").GetComponent<Text>();
            //myText.text = "test";
            Text textt = Canvas.FindObjectOfType<Text>();
            textt.text = "test";
        }
    }
}
