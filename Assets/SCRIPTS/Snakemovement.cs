using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Snakemovement : MonoBehaviour
{
    [SerializeField] int speed=3;
    Snakemovement snakemovement;
    int score;
    int highscore;
    void Start()
    {
        snakemovement = GetComponent<Snakemovement>();
    }

    void Update()
    {
        Snake_Movement();
        Snake_Rotate();
    }

    void Snake_Rotate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 180))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 0))
            {
                transform.rotation = Quaternion.Euler(0, 0, -180);
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            if (transform.rotation != Quaternion.Euler(0, 0, -90))
            {
                transform.rotation = Quaternion.Euler(0, 0, 90);
            }
        }

        else if (Input.GetKey(KeyCode.D))
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 90))
            {
                transform.rotation = Quaternion.Euler(0, 0, -90);
            }
        }

        else if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Snake_Movement()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Body" || collision.gameObject.tag == "Boder")
        {
            SceneManager.LoadScene(2);
        }
    }
}
