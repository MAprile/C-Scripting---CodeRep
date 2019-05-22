using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAwarePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);

        if (transform.position.y <= 2.81)
        {
            Debug.Log("I'm about to hit te ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
