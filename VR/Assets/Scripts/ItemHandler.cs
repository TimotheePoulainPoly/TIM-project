using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ItemHandler : MonoBehaviour
{
    private GameObject realItem;

    public void SetData(GameObject realItem) {
        this.realItem = realItem;
        transform.GetChild(0).GetComponent<TextMeshPro>().text = realItem.name;
        transform.GetChild(1).GetComponent<TextMeshPro>().text = realItem.GetComponent<EventHandler>().description;
    }

    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        Debug.Log($"{args.interactorObject} selected " + this.gameObject.name);
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    public void OnHoverExited(HoverExitEventArgs args)
    {
        Debug.Log($"{args.interactorObject} selected " + this.gameObject.name);
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log($"{args.interactorObject} selected " + this.gameObject.name);
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    public void OnSelectExited(SelectExitEventArgs args)
    {
        Debug.Log($"{args.interactorObject} selected " + this.gameObject.name);
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
}
