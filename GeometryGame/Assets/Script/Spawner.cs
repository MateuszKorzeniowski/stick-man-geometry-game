using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float startTimeBtwSpawn=1f;
    private float timeBtwSpawn;
    public GameObject[] enemies;

    private void Update()
    {
        if(timeBtwSpawn<=0)
        {
            int rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

        startTimeBtwSpawn -= (Time.deltaTime / 100);
        Debug.Log(startTimeBtwSpawn);
        if (startTimeBtwSpawn < 0.3f) startTimeBtwSpawn = 0.3f;
    }
}
