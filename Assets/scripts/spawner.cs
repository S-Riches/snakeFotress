using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject collectable;
    public float startTime;
    private float timebtwspawns;

    public int number_of_items;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timebtwspawns <= 0 && number_of_items > 0)
        {
            Instantiate(this.collectable, this.transform.position, Quaternion.identity);

            timebtwspawns = startTime;
            number_of_items--;
        }
        else
        {
            timebtwspawns -= Time.deltaTime;
        }
    }
}
