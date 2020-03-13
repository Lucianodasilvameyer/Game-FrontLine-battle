using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ReferenciaDoPlayerAoInstanciar : NetworkBehaviour
{
    public List<GameObject> ListPlayer = new List<GameObject>();
    //public static ReferenciaDoPlayerAoInstanciar Singleton;

    public GameObject Tanque;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        OnStartLocalPLayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnStartLocalPLayer()
    {
        base.OnStartLocalPlayer();
        AddPlayer(Tanque.gameObject);

    }
    public void AddPlayer(GameObject gameObject)
    {
        ListPlayer.Add(gameObject);
    }


}
