using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListHandler : MonoBehaviour
{
    [SerializeField] private GameObject listItemPrefab;
    private int count = 0;

    public void AddNewItem(GameObject item) {
        Debug.Log("Adding new item...");
        GameObject newItem = Instantiate(listItemPrefab);
        newItem.transform.SetParent(this.transform);
        newItem.transform.localPosition = new Vector3(0f, 0.312f-(count*0.179f), -0.41f);
        newItem.transform.localScale = new Vector3(0.85f, 0.18f, 0.35f);
        newItem.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
        newItem.GetComponent<ItemHandler>().SetData(item);
        count++;
    }
}
