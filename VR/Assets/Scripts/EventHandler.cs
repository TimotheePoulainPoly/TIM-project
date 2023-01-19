using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EventHandler : MonoBehaviour
{
    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        Debug.Log($"{args.interactorObject} hovered over " + this.gameObject.name);
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
 
    public void OnHoverExited(HoverExitEventArgs args)
    {
        Debug.Log($"{args.interactorObject} stopped hovering over " + this.gameObject.name);
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
}
