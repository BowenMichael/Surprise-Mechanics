using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    
    public GameObject inventory;
    public GameObject slotHolder;

    private bool inventoryIsOn = false;
    private GameObject[] slots;
    private GameController gc;

    void Start()
    {
        slots = GameObject.FindGameObjectsWithTag("Slot");
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryIsOn = !inventoryIsOn;
            gc.toggleGameState();
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
