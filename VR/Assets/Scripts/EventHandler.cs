using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EventHandler : MonoBehaviour
{
    [SerializeField] private GameObject itemList;
    [SerializeField] private GameObject rightHand;
    [SerializeField][TextArea(5,10)] public string description;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private bool known = false;

    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
 
    public void OnHoverExited(HoverExitEventArgs args)
    {
        Debug.Log($"{args.interactorObject} stopped hovering over " + this.gameObject.name);
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        rightHand.GetComponent<HandMorph>().Holding();
        Debug.Log($"{args.interactorObject} grabbed " + this.gameObject.name);
        initialPosition = this.transform.position;
        initialRotation = this.transform.rotation;
        if (!known) {
            itemList.GetComponent<ItemListHandler>().AddNewItem(this.gameObject);
            known = true;
        }
    }
 
    public void OnSelectExited(SelectExitEventArgs args)
    {
        rightHand.GetComponent<HandMorph>().NotHolding();
        Debug.Log($"{args.interactorObject} stopped grabbing " + this.gameObject.name);
        this.transform.position = initialPosition;
        this.transform.rotation = initialRotation;
    }

    public void GrabbedFromList() {
        rightHand.GetComponent<HandMorph>().Holding();
        transform.SetParent(rightHand.transform, false);
        transform.localPosition = new Vector3(0f, 0f, 0f);
        transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
    }

    public void UngrabbedFromList() {
        rightHand.GetComponent<HandMorph>().NotHolding();
        transform.SetParent(null);
        this.transform.position = initialPosition;
        this.transform.rotation = initialRotation;
    }
}
