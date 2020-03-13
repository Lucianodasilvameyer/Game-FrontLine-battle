using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ReferenciaDoPlayerAoInstanciar : NetworkBehaviour
{
    public List<GameObject> ListPlayer = new List<GameObject>();
    

    public GameObject[] Tanque;

    //public GameObject Tank;
    PegarMunicao pegarMunicao_ref;

    private void Awake()
    {
        pegarMunicao_ref = GetComponent<PegarMunicao>();
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

        
        
            for(int i = 0; i < Tanque.Length; i++)
            {
                Tanque[i].GetComponent<PegarMunicao>().AddPlayer(gameObject);
            }
        
    }

    public void AddPlayer(GameObject gameObject)
    {
        ListPlayer.Add(gameObject);
    }


}
