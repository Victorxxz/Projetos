using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{

    public GameOver controller;

    void Start()
    {
        controller = FindObjectOfType<GameOver>();
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
