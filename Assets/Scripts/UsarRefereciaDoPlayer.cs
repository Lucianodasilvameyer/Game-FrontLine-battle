using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarRefereciaDoPlayer : MonoBehaviour
{
    //ReferenciaDoPlayerAoInstanciar referenciaDoPlayerAoInstanciar_ref;

    public List<GameObject> ListPlayer = new List<GameObject>();
    // Start is called before the first frame update

    void Awake()
    {
        //referenciaDoPlayerAoInstanciar_ref = GameObject.Find("Tanque").GetComponent<ReferenciaDoPlayerAoInstanciar>();    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPlayer(Tanque tanque)
    {
        ListPlayer.Add(tanque.gameObject);
    }
}
