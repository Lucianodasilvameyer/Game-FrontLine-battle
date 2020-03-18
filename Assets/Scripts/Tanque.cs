using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Tanque : NetworkBehaviour
{
    TanqueMovimento tanqueMovimento_ref;
    CanhaoMovimento canhaoMovimento_ref;
    TiroDoPlayer TiroDoPlayer_ref;

    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    Vida vida_ref;

    private void Awake()
    {
        tanqueMovimento_ref = GetComponent<TanqueMovimento>();
        
        TiroDoPlayer_ref = GetComponent<TiroDoPlayer>();

        //canhaoMovimento_ref = GameObject.Find("Canhao").GetComponent<CanhaoMovimento>();

        vida_ref = GetComponent<Vida>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        vida_ref.OnDeath += Desativar;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= Desativar;
    }
    public void Desativar()
    {
        tanqueMovimento_ref.enabled = false;
        //canhaoMovimento_ref.enabled = false;
        TiroDoPlayer_ref.enabled = false;


    }
    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        usarRefereciaDoPlayer_ref.AddPlayer(gameObject);

       
    }

}
