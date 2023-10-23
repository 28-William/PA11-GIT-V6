﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (other.CompareTag("Point"))
        {
            score++;
        }
    }
}