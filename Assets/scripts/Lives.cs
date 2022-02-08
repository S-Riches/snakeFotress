using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    /// <summary>
    /// this script is for controlling the win/loss conditions
    /// </summary>

    public static GameObject heart, heart2, heart3;
    //public static Image heartIMG, heart2IMG, heart3IMG;
    //public Collectables col;
    public static int maxPoints;
    
    public static int lifeCount;
    public static GameObject[] Getcount;
    public static bool isDead = false;
    public Text gameover;
    public score Score;
    public Rigidbody2D rb;

   

    void Awake()
    {
        // gives us the amount of objects needed to get the maximum points
        Getcount = GameObject.FindGameObjectsWithTag("collectablesSpawner");
    }
    // Start is called before the first frame update
    void Start()
    {
        //heart3IMG = GetComponent<Image>();
        //heart2IMG = GetComponent<Image>();
        //heartIMG = GetComponent<Image>();
       
        score.scoreText = GetComponent<Text>();

        gameover.enabled = false;
        maxPoints = Collectables.value;
        Debug.Log(maxPoints);
        
        score.scoreText.enabled = false;


    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (isDead == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        
        if (score.Score == maxPoints)
        {
            gameover.text = "You win! you got  " + score.Score.ToString() + "  out of  " + maxPoints + "  \n you got a grade A! ";
            score.scoreText.enabled = false;
            gameover.enabled = true;
                
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("menu");
                isDead = false;
                score.Score = 0;
            }

        }

        if (isDead && score.Score == maxPoints / 2)
        {
            gameover.text = "game over! your score was  " + score.Score.ToString() + "  out of  " + maxPoints + "  \n you got a grade B!  ";
            score.scoreText.enabled = false;
            gameover.enabled = true;
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("menu");
                isDead = false;
                score.Score = 0;
            }



        }

        if (isDead)
        {
            gameover.text = "game over! your score was  " + score.Score.ToString() + "  out of  " + maxPoints;
            score.scoreText.enabled = false;
            gameover.enabled = true;
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("menu");
                isDead = false;
                score.Score = 0;
            }



        }
        if (timer.display_number <= 0)
        {
            gameover.text = "times up! your score was  " + score.Score.ToString() + "  out of  " + maxPoints;
            score.scoreText.enabled = false;
            gameover.enabled = true;
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("menu");
                isDead = false;
                score.Score = 0;
            }



        }

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }




    }
    
    
    
}

    
