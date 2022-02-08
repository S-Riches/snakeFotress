using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static Text scoreText;
    public static int Score;

    void Start()
    {
        Debug.Log(score.Score);
        scoreText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + Score.ToString();
    }
}
