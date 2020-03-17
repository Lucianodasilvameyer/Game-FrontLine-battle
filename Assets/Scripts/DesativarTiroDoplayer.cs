using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DesativarTiroDoplayer : MonoBehaviour
{
    
    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    //TiroDoPlayer[] tiroDoPlayer_ref;
    TiroDoPlayer tiroDoPlayer_ref;
 
    Vida vida_ref;
   

    GameObject[] Player;
    // Start is called before the first frame update

    void Awake()
    {
        
         


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
        vida_ref.OnDeath += DesligarTiroDoPlayer;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= DesligarTiroDoPlayer;
    }
    public void DesligarTiroDoPlayer()
    {

        tiroDoPlayer_ref.enabled = false;
        

    }

}
