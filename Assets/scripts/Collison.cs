using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    
    public BoxCollider2D playerCollider;
    public GameObject player;


    
    void Start()
    {
        // incase the collider is missing
        if (player == null)
        {
            
            player = GameObject.FindWithTag("Player");
            playerCollider = player.GetComponent<BoxCollider2D>();
        } 
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.tag == ("Player"))
        {
            //Lives.lifeCount--;
            Lives.isDead = true;
            Debug.Log("hit");
        }
    }
}
