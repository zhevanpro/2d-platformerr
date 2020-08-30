using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myRigidBody;
    [SerializeField] float runSpeed = 5f;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        run();
        flipSprite();
    }

    private void run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }
    private void flipSprite()
    {
        bool playerHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        if (playerHorizontalSpeed)
        {

            transform.localScale = new Vector2(Math.Sign(myRigidBody.velocity.x), 5f);
            

        }
    }

}

