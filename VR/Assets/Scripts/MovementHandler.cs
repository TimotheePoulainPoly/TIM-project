using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public float speed = 5.0f;
    public OVRInput.Controller controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Récupérer les inputs du joystick droit
        float horizontal = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick, controller).x;
        float vertical = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick, controller).y;

        // Vérifier si la manette droite est suivie
        if(OVRInput.GetControllerPositionTracked(controller))
        {
            // Appliquer les inputs pour déplacer la caméra ou le joueur
            transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
        }
    }
}
