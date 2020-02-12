using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public GameObject inventory;
    public GameObject slotHolder;

    private bool inventoryIsOn = false;
    private GameObject[] slots;

    void Start()
    {
        slots = GameObject.FindGameObjectsWithTag("Slot");


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryIsOn = !inventoryIsOn;
        }
       
        if (inventoryIsOn)
        {
            inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }
}
