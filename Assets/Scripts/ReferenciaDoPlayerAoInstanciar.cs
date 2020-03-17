using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ReferenciaDoPlayerAoInstanciar : NetworkBehaviour
{
    TanqueMovimento tanqueMovimento_ref;

    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    TiroDoPlayer[] tiroDoPlayer_ref;
    Vida vida_ref;
    SpawnarArmadilhas[] spawnarArmadilhas;
    SpawnarArmadilhas spawnarArmadilhas_ref;

    SpawnarMunicao[] spawnarMunicao;
    SpawnarMunicao spawnarMunicao_ref;


    void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
        tanqueMovimento_ref = GetComponent<TanqueMovimento>();
    }
    // Start is called before the first frame update
    void Start()
    {
        

        if (spawnarArmadilhas_ref.ListArmadilhas != null)
        {
            for (int i = 0; i < spawnarArmadilhas_ref.ListArmadilhas.Count; i++)
            {
                spawnarArmadilhas[i] = spawnarArmadilhas_ref.ListArmadilhas[i].GetComponent<SpawnarArmadilhas>();

                
            }
        }
        if(spawnarMunicao_ref.ListMunicao != null)
        {
            for(int i = 0; i < spawnarMunicao_ref.ListMunicao.Count; i++)
            {
                spawnarMunicao[i] = spawnarMunicao_ref.ListMunicao[i].GetComponent<SpawnarMunicao>();
            }
        }




        //OnStartLocalPlayer();
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
    
    
}
