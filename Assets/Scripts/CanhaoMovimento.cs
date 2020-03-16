using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanhaoMovimento : MonoBehaviour
{
    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    ReferenciaDoPlayerAoInstanciar referenciaDoPlayerAoInstanciar_ref;
    Rigidbody2D righ;
    
    Vector2 mousePos;

    public Camera cam;


  

    
    public Transform Tanque;

    void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();

        righ = GetComponent<Rigidbody2D>();

        




    }
    
    // Update is called once per frame
    void Update()
    {
        if (usarRefereciaDoPlayer_ref.ListPlayer != null)
        {
            transform.position = Tanque.transform.position;
        }
               
         
        
         
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
         
            
         
      
            
      

              
    }
    void FixedUpdate()
    {
        
        
            Vector2 OlharDirecao = mousePos - righ.position;

        if (OlharDirecao != null)
        {
            float angle = Mathf.Atan2(OlharDirecao.y, OlharDirecao.x) * Mathf.Rad2Deg - 90f;

            righ.rotation = angle;
        }

           
        

        
    }
}
