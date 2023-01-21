using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandMorph : MonoBehaviour
{
    public void Holding() {
        transform.GetChild(0).gameObject.SetActive(false);
        GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    public void NotHolding() {
        transform.GetChild(0).gameObject.SetActive(true);
        GetComponent<XRInteractorLineVisual>().enabled = true;
    }
}
