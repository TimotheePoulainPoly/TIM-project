using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EventHandler : MonoBehaviour
{
    [SerializeField] private GameObject itemList;
    [SerializeField][TextArea(5,10)] private string description;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private bool known = false;

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

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log($"{args.interactorObject} grabbed " + this.gameObject.name);
        initialPosition = this.transform.position;
        initialRotation = this.transform.rotation;
        if (!known) {
            itemList.GetComponent<ItemListHandler>().AddNewItem(this.gameObject.name, this.description);
            known = true;
        }
    }
 
    public void OnSelectExited(SelectExitEventArgs args)
    {
        Debug.Log($"{args.interactorObject} stopped grabbing " + this.gameObject.name);
        this.transform.position = initialPosition;
        this.transform.rotation = initialRotation;
    }
}
