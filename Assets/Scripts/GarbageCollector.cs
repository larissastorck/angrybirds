﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour {

    public GameObject[] prefabs;
    private GameObject randObj;
    float x, y;
    public float spawnTime = 10;
    public float fallSpeed = 40.0f;    //The speed of falling Apples
    private float timer = 0; //counting timer, reset after calling SpawnRandom() function

    void Start () {
        x = transform.position.x;
        y = transform.position.y+5;
    }

    public void Update(){
        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime){
            randomGarbage();       //Calling method SpawnRandom()
            timer = 0;        //Reseting timer to 0
        }
    }


    void randomGarbage(){
        int i = Random.Range(0, prefabs.Length);
        int z = Random.Range(-100, 100);
        print("z: " + z);
        Instantiate(prefabs[i], transform.position, Quaternion.Euler(0, 0, z));
        prefabs[i].transform.Translate(Vector3.up * fallSpeed , Space.World);
    }
}
