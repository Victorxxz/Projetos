
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiupiuController : MonoBehaviour
{

    public float speed = 1f;
    private Rigidbody2D _rig;

    public  GameObject GameOver;

    void Start()
    {
        _rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
