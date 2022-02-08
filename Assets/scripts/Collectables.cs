using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectables : MonoBehaviour
{
    /// <summary>
    /// code for the collectables that is responsible
    /// for handling with the collision, active status(i.e. if it exists or not)
    /// and what the object should look like (texture) and the value associated with it
    /// </summary>
    
    
    public static int value;

    public score Score;
    public BoxCollider2D Collider;
    public SpriteRenderer sprites;
    public Sprite gem, coin, guitar, goldBar;


    void Awake()
    {
        if(value == 0)
        {
            value = 1;
        }
        sprites = GetComponent<SpriteRenderer>();
        Collider = GetComponent<BoxCollider2D>();

        switch (Random_number())
        {
            //COIN
            case 0: sprites.sprite = coin; value = 100; Lives.maxPoints = value * Lives.Getcount.Length; Debug.Log(value) ; break;
                

            //GEM
            case 1: sprites.sprite = gem; value = 300; Lives.maxPoints = value * Lives.Getcount.Length; Debug.Log(value); break;

            //GUITAR
            case 2: sprites.sprite = guitar; value = 500; Lives.maxPoints = value * Lives.Getcount.Length;  Debug.Log(value); break;

            //GOLD BAR
            case 3: sprites.sprite = goldBar; value = 1000; Lives.maxPoints = value * Lives.Getcount.Length; Debug.Log(value); break;


        }
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == ("Player"))
        {
            score.Score = score.Score + value ;
            Destroy(this.gameObject);
            Debug.Log(score.Score);
        }
    }
    public static int Random_number()
    {
        //this code randomly choses a number between 
        System.Random r = new System.Random();
        int randomNumber = r.Next(0, 4);
        
        return randomNumber;
        
    }
}
