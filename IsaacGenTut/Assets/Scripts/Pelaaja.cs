using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pelaaja : MonoBehaviour
{


    Rigidbody2D rb;
    public Animator Anim;

    float horizontal = 0f;
    float vertical = 0f;

    public float nopeus = 400.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal"); 
        vertical = Input.GetAxisRaw("Vertical");
        Move();
        
        
    }

    void Move()
    {
        if(horizontal != 0f | vertical != 0f)
        {
            rb.velocity = new Vector2(horizontal * nopeus * Time.deltaTime, vertical * nopeus * Time.deltaTime);
            Anim.SetBool("Walking", true);
        }
        else
        {
            rb.velocity = new Vector2(0,0);
            Anim.SetBool("Walking", false);
        }
        
       
        
        
    }


}