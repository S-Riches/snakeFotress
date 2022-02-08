using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour
{
    public AudioSource backMusic;
    public bool MusicOn;

    void Start()
    {
        MusicOn = true;
        backMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt) && MusicOn == false)
        {
            backMusic.mute = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt) && MusicOn)
        {
            MusicOn = false;
            backMusic.mute = true;
        }
    }
}
