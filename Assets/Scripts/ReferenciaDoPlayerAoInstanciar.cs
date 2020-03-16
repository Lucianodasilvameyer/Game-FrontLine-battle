using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ReferenciaDoPlayerAoInstanciar : NetworkBehaviour
{

    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    
    public Tanque tanque;
    
    
    void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        OnStartLocalPlayer();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        usarRefereciaDoPlayer_ref.AddPlayer(tanque);
    }
}
