using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<TextMesh>().text = "<b>Liste de preuves</b>\n";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewItem(string name, string description) {
        transform.GetChild(0).GetComponent<TextMesh>().text += "\n" + name + "\n" + description + "\n";
    }
}
