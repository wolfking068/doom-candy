﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpickup : pickup{
    public float healthpickups;
    public float timer;
    // Use this for initialization
    void Start () {
        timer = 10;
	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        player_movment player = other.GetComponent<player_movment>();
        if (player != null)
        {
            pick.playfaceeffect(FaceStates.get);
            player.currenthealth += healthpickups;
            player.currenthealth = Mathf.Clamp(player.currenthealth, 0, player.maxhealth);
            play.health2();
            sp.currentpickups -= 1;
            Destroy(gameObject);
        }

    }
}
