using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 30;
    private int limit = 20;
    public GameObject shootbanana;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        if (transform.position.x < -limit)
        {
            transform.position = new Vector3(-limit, transform.position.y, transform.position.z);
        }

        if (transform.position.x > limit)
        {
            transform.position = new Vector3(limit, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(shootbanana, transform.position, shootbanana. transform.rotation);
        }


    }
}