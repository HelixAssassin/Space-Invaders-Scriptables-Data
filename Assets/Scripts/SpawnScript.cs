﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnScript : MonoBehaviour
{



    [SerializeField] GameObject thingToSpawn;
    [SerializeField] float delayBetweenSpawns = 2.0f;
    [SerializeField] float timeOfNextSpawn = 1f;

    int amountToSpawn = 10;
    static int AmountSpawned = 1;

    void Start()
    {

    }




    void Update()

    {

        if (Time.time >= timeOfNextSpawn && AmountSpawned < amountToSpawn)

        {

            Instantiate(thingToSpawn, transform.position, Quaternion.identity);

            timeOfNextSpawn = Time.time + delayBetweenSpawns;



        }

    }

}