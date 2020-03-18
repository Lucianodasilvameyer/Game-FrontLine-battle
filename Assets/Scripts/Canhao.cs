using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Canhao : NetworkBehaviour
{
    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;
    public Transform Tanque;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (usarRefereciaDoPlayer_ref.ListPlayer != null)
        {
            transform.position = Tanque.transform.position;
        }
    }
    private void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
    }
    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        usarRefereciaDoPlayer_ref.AddCanhao(gameObject);

    }


}
