using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Game : NetworkBehaviour
{

    public static Game singleton;

    Vida vida_ref;
    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    public GameObject GameOver;

    public GameObject BotaoBack;

    SpawnarArmadilhas[] spawnarArmadilhas;
    SpawnarArmadilhas spawnarArmadilhas_ref;

    SpawnarMunicao[] spawnarMunicao;
    SpawnarMunicao spawnarMunicao_ref;


    void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();

        if(singleton != null && singleton != this)
        {
            GameObject.Destroy(this);
        }
        else
        {
            singleton = this;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        

        
        




        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    


    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        usarRefereciaDoPlayer_ref.AddPlayer(gameObject);
    }
    public void DesligarSpawnArmadilhas()
    {
        if (spawnarArmadilhas_ref.ListArmadilhas != null)
        {
            for (int i = 0; i < spawnarArmadilhas_ref.ListArmadilhas.Count; i++)
            {
                spawnarArmadilhas[i] = spawnarArmadilhas_ref.ListArmadilhas[i].GetComponent<SpawnarArmadilhas>();


            }
        }
    }
    public void DesligarSpawnmunicao()
    {
        if (spawnarMunicao_ref.ListMunicao != null)
        {
            for (int i = 0; i < spawnarMunicao_ref.ListMunicao.Count; i++)
            {
                spawnarMunicao[i] = spawnarMunicao_ref.ListMunicao[i].GetComponent<SpawnarMunicao>();
            }
        }
    }
    public void AtivarGameOver()
    {
        if(usarRefereciaDoPlayer_ref.ListPlayer != null)
        {
            for(int i=0; i< usarRefereciaDoPlayer_ref.ListPlayer.Count; i++)
            {
                if (vida_ref.hp <= 0)
                {
                    GameOver.SetActive(true);
                }
            }
        }
    }
    public void AtivarBotaoBack()
    {
        if(usarRefereciaDoPlayer_ref.ListPlayer != null)
        {
            for (int i = 0; i < usarRefereciaDoPlayer_ref.ListPlayer.Count; i++)
            {
                if (vida_ref.hp <= 0)
                {
                    BotaoBack.SetActive(true);   
                }
            }
        }
    }


    
}
