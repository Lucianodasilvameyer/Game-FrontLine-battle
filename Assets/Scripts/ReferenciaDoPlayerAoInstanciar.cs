using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ReferenciaDoPlayerAoInstanciar : NetworkBehaviour
{

    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    TiroDoPlayer[] tiroDoPlayer_ref;
    Vida[] vida_ref;



    void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        usarRefereciaDoPlayer_ref = GetComponent<UsarRefereciaDoPlayer>();

        /*if (usarRefereciaDoPlayer_ref.ListPlayer != null)
        {
            for (int i = 0; i < usarRefereciaDoPlayer_ref.ListPlayer.Count; i++)
            {


                tiroDoPlayer_ref[i] = usarRefereciaDoPlayer_ref.ListPlayer[i].GetComponent<TiroDoPlayer>();
                vida_ref[i] = usarRefereciaDoPlayer_ref.ListPlayer[i].GetComponent<Vida>();
            }



           
        }*/



        OnStartLocalPlayer();
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
