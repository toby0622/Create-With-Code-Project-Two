﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteouter : MonoBehaviour
{
    // Start is called before the first frame update
    public int outrange = 30;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > outrange)
        {
            Destroy(gameObject);
        }

    }
}
