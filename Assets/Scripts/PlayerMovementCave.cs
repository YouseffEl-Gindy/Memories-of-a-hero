using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerMovementCave : MonoBehaviour
{
    public float speed;

    int directionX = 1;
    int directionY = 1;
    float actualXScale;

    public int collected = 0;
    public int amountToCollect; 

    public Rigidbody2D rdbd;

    float horizontal;
    float vertical;

    public TMP_Text text;

    public Animator anim;
    void Start()
    {
        rdbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        actualXScale = transform.localScale.x;

        text.text = collected + "/" + amountToCollect;
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (horizontal > 0)
        {
            directionX = 1;
            transform.localScale = new Vector3(actualXScale, transform.localScale.y, transform.localScale.z);
        }
        else if (horizontal < 0)
        {
            directionX = -1;
            transform.localScale = new Vector3(-1 * actualXScale, transform.localScale.y, transform.localScale.z);
        }
        else
            directionX = 0;

        if (vertical > 0)
            directionY = 1;
        else if (vertical < 0)
            directionY = -1;
        else
            directionY = 0;

        if (directionY > 0)
            anim.SetFloat("up", 1);
        else
            anim.SetFloat("up", 0);

        if (directionX != 0)
            anim.SetFloat("walking", 1);
        else
            anim.SetFloat("walking", 0);

        text.text = collected + "/" + amountToCollect;
    }
    void FixedUpdate()
    {
        rdbd.velocity = new Vector2(speed * directionX * Time.fixedDeltaTime, speed * directionY * Time.fixedDeltaTime);
    }

    public void IncrementCollectable()
    {
        collected++;
    }

}

    
