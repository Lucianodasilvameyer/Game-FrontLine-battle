﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Bullet : MonoBehaviour
    {
        float speed = 5;

        float timerSelfDestruct = 0;
        float timerSelfDestruct_Max = 5;

        private Rigidbody2D rgbd;

        private void Awake()
        {
            rgbd = GetComponent<Rigidbody2D>();
        }

        // Start is called before the first frame update
        void Start()
        {
            timerSelfDestruct = Time.time;
        }

        // Update is called once per frame
        void Update()
        {
            //rgbd.MovePosition(direction * speed * Time.deltaTime/*, Space.World*/);

            if (Time.time >= timerSelfDestruct + timerSelfDestruct_Max)
            {
                Destroy(gameObject);

                timerSelfDestruct = Time.time;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);

                Destroy(gameObject);
            }
        }
    }
}