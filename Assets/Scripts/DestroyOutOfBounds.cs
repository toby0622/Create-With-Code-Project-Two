using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float top_bound = 30;
    private float lower_bound = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > top_bound)
        {
            Destroy(gameObject);
        } 
        
        else if (transform.position.z < lower_bound)
        {
            Destroy(gameObject);
        }
    }
}
