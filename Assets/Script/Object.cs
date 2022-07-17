using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject particalEffect;
    public int obsBoost;
    public GameObject obsboost;
    public float downborder= -16f;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;


    public int damage = 1;
    public float obsspeed;

    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        obsBoost = obsboost.GetComponent<Score>().playerscore;

        if (obsBoost > 30)
        {
           obsspeed = 6f;
        }

        if (obsBoost > 60)
        {
            obsspeed = 7f;
        }


        if (obsBoost > 90)
        {
            obsspeed = 8f;
        }

        if (obsBoost > 120)
        {
            obsspeed = 8.5f;
        }

        if (obsBoost > 150)
        {
            obsspeed = 9f;
        }

        if (obsBoost > 180)
        {
            obsspeed = 9.5f;
        }

        //Obstacle Movement
        transform.Translate(Vector2.down * obsspeed * Time.deltaTime);

        if(transform.position.y < downborder)
        {
            transform.position = new Vector2(transform.position.x, 5.04f);
        }
    }

    //Destroying Player While Collision
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().health -= damage;
            Debug.Log(other.GetComponent<PlayerMovement>().health);

            if (other.GetComponent<PlayerMovement>().health ==-1)
            {
                Destroy(health3.gameObject);
            }
            if (other.GetComponent<PlayerMovement>().health == -2)
            {
                Destroy(health2.gameObject);
            }
            if (other.GetComponent<PlayerMovement>().health == -3)
            {

                Destroy(health1.gameObject);
                gameover.SetActive(true);
                Destroy(other.gameObject);
               

            }
        }
    }
}
