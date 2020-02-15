using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onCollision : MonoBehaviour
{
    public GameObject shop;

    private GameController gc;
    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision With: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Shop"))
        {
            shop.SetActive(true);
            if(gc.getGameState() == true)
            {
                gc.toggleGameState();
            }
        }
        else if (collision.gameObject.CompareTag("Tavern"))
        {
            gc.changeScene("Tavern");
            
        }
    }
}
