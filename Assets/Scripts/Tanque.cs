using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Tanque : NetworkBehaviour
{
    public GameObject BotaoBack;

    SpriteRenderer spriteRenderer_ref;
    TanqueMovimento tanqueMovimento_ref;
    CanhaoMovimento canhaoMovimento_ref;
    TiroDoPlayer TiroDoPlayer_ref;

    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    Vida vida_ref;

    private void Awake()
    {
        spriteRenderer_ref = GameObject.Find("GameOver").GetComponentInChildren<SpriteRenderer>();

        tanqueMovimento_ref = GetComponent<TanqueMovimento>();
        
        TiroDoPlayer_ref = GetComponent<TiroDoPlayer>();

        canhaoMovimento_ref = GetComponentInChildren<CanhaoMovimento>();

        vida_ref = GetComponent<Vida>();

        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
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
        canhaoMovimento_ref.enabled = false;
        TiroDoPlayer_ref.enabled = false;


    }
    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        usarRefereciaDoPlayer_ref.AddPlayer(gameObject);

       
    }
    public void AtivarGameOver()
    {
        spriteRenderer_ref.enabled = true;

    }
    public void AtivarBotaoBack()
    {
        BotaoBack.SetActive(true);



    }

}
