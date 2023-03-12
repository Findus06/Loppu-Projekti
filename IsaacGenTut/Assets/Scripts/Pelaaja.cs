using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pelaaja : MonoBehaviour
{


    Rigidbody2D rb;

    float horizontal;
    float vertical;

    public float nopeus = 400.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal"); 
        vertical = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * nopeus * Time.deltaTime, vertical * nopeus * Time.deltaTime);
    }


}