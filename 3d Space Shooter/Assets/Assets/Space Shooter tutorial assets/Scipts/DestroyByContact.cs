﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {


    public GameObject explode;
    public GameObject playerExplode;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "boundry")
        {
            return;
        }
        Instantiate(explode, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplode, other.transform.position, other.transform.rotation);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}