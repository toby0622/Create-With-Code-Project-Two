using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal_input;
    public float speed = 20f;
    public float xRange = 10f;
    public GameObject projectile_prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player inside the boundary we set
        if (transform.position.x < (-xRange))
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontal_input = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontal_input * Time.deltaTime * speed);
        
        // Launch a projectile from the player 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Variable for the function will be item, position and moving angle
            Instantiate(projectile_prefab, transform.position, projectile_prefab.transform.rotation);
        }
    }
}
