using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public float speed;
    public GameObject dead;
    PointsMenager points;

    private void Start()
    {
        points = FindObjectOfType<PointsMenager>();
    }

    void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if(collision.tag==gameObject.tag)
        {
            points.AddPoint();
            points.PrintPoints();

            GameObject particle = Instantiate(dead, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(particle, 1);
            Destroy(gameObject);
        }
        else
        {
            points.HighScore();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
