﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupColliision : MonoBehaviour
{
    public GameObject changeScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pickup")
        {
            changeScore.GetComponent<ChangeScore>().score++;
            Destroy(collision.gameObject);
        }
    }
}
