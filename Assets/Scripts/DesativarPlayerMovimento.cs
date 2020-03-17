﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarPlayerMovimento : MonoBehaviour
{
    
    Vida vida_ref;
    TanqueMovimento tanqueMovimento_ref;


    private void Awake()
    {
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
        tanqueMovimento_ref = GameObject.Find("Tanque").GetComponent<TanqueMovimento>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        vida_ref.OnDeath += DesligarPlayerMovimento;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= DesligarPlayerMovimento;
    }
    public void DesligarPlayerMovimento()
    {
        tanqueMovimento_ref.enabled = false;
    }
   

}
