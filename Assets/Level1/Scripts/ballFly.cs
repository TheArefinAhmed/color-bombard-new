using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFly : MonoBehaviour
{
    public float flySpeed = 24f;

    private Rigidbody2D ballBody;
    private bool isoccured;


    void Start()
    {
        ballBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //make our pin fly
        ballBody.MovePosition(ballBody.position + Vector2.up * Time.deltaTime * flySpeed );

    }
}
