using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TanqueMovimento : NetworkBehaviour
{
    public float movSpeed;

    Rigidbody2D righ;

    [SerializeField]
    Vector2 movement;

   // [SerializeField]
    //Vector2 movement2;

    Animator animator;

    void Awake()
    {
        righ = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        /*movement2.x = Input.GetAxisRaw("Horizontal2");
        movement2.y = Input.GetAxisRaw("Vertical2");*/

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        /*animator.SetFloat("Horizontal", movement2.x);
        animator.SetFloat("Vertical", movement2.y);
        animator.SetFloat("Speed", movement2.sqrMagnitude);*/

    }

    private void FixedUpdate()
    {
        if (!isLocalPlayer)
        {
            return;
           
        }
        else
        {
            righ.MovePosition(righ.position + movement * movSpeed * Time.fixedDeltaTime);
        }

        
    }
}
