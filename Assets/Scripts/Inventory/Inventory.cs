using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject inventoryUI;

    private List<Item> itemList;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventoryUI.SetActive(!inventoryUI.activeInHierarchy);
            Debug.Log("E");
        }
    }

    public Inventory()
    {
        itemList = new List<Item>();
        Debug.Log("Inventory");
    }
}
