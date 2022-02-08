using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenechanger : MonoBehaviour
{
    public string scene;
    public Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SceneChange);
    }
    void SceneChange()
    {
        SceneManager.LoadScene(scene);
    }
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
    
}
