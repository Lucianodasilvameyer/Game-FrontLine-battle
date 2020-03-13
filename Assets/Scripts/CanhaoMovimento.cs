using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanhaoMovimento : MonoBehaviour
{
    ReferenciaDoPlayerAoInstanciar referenciaDoPlayerAoInstanciar_ref;
    Rigidbody2D righ;
    
    Vector2 mousePos;

    public Camera cam;


    
    public Transform Tanque;

    void Awake()
    {
        referenciaDoPlayerAoInstanciar_ref = GameObject.Find("Game").GetComponent<ReferenciaDoPlayerAoInstanciar>();

        
        righ = GetComponent<Rigidbody2D>();


    }
    
    // Update is called once per frame
    void Update()
    {
        if (referenciaDoPlayerAoInstanciar_ref.ListPlayer != null)
        {
            transform.position = Tanque.transform.position;
        }
               

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);      
    }
    void FixedUpdate()
    {
        Vector2 OlharDirecao = mousePos - righ.position;

        float angle = Mathf.Atan2(OlharDirecao.y,OlharDirecao.x) * Mathf.Rad2Deg-90f;
        
        righ.rotation = angle; 
    }
}
