using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    public GameObject[] bullet;
    public float startTimeBtwShot;
    float timeBtwShot;

    private void Start()
    {
        timeBtwShot = startTimeBtwShot;
    }

    void Update () {

        if (timeBtwShot <= 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Instantiate(bullet[0], transform.position, Quaternion.identity);
                timeBtwShot = startTimeBtwShot;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(bullet[1], transform.position, Quaternion.identity);
                timeBtwShot = startTimeBtwShot;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Instantiate(bullet[2], transform.position, Quaternion.identity);
                timeBtwShot = startTimeBtwShot;
            }
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }
    }
}
