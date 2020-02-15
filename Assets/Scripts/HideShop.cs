using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HideShop : MonoBehaviour
{
    public GameObject shop;
    private Button button;

    private GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(hideShop);
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void hideShop()
    {
        shop.SetActive(false);
        if (gc.getGameState() == false)
        {
            gc.toggleGameState();
        }
    }

    
}
