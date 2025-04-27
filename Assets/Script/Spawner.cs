using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Objects to Spawn")]
    public GameObject[] spawnObjects;
    [Header("Area Fill")]
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    [Header("Time Variation")]
    public float timeBtnSpawn;
    public float time;              //time to increase spawn time
    public float spawnTimeDecrease = 0.1f;
    public float spawnThreshold = 0.6f;

    [Header("Size Variation")]
    public float minSize = 0.5f;
    public float maxSize = 2.0f;

    
    float spawnTime;
    float _time;


    void Start()
    {
        _time = time;
    }
    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        if(_time <= 0)
        {
            _time = time;
            DecreaseRate();
        }
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBtnSpawn;
        }
        
    }

    void Spawn()
    {

        int i = Random.Range(0, spawnObjects.Length);
        float randX = Random.Range(minX, maxX);
        float randY = Random.Range(minY, maxY);

        GameObject newObject = Instantiate(spawnObjects[i], transform.position + new Vector3(randX, randY, 0), transform.rotation);

        //random object size
        float randomSize = Random.Range(minSize, maxSize);
        newObject.transform.localScale = new Vector2(randomSize, randomSize);
    } 
    
    void DecreaseRate()
    {
        if (timeBtnSpawn > spawnThreshold)
            timeBtnSpawn -= spawnTimeDecrease;
    }

}
