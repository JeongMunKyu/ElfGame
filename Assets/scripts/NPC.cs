﻿using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {
    public float speed = 5f;
    public int heal = 1;

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
        }
    }
}
