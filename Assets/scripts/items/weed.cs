﻿using UnityEngine;
using System.Collections;

public class weed : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Player"))
        {

            Destroy(gameObject);
            col.GetComponent<elf_inventory>().weed += 1;
        }
    }
}
