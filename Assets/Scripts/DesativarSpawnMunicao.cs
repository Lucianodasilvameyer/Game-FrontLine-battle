using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarSpawnMunicao : MonoBehaviour
{
    SpawnarMunicao spawnarMunicao_ref;
    SpawnarMunicao[] spawnarMunicao;
    //Vida vida_ref;

    private void Awake()
    {
        spawnarMunicao_ref = GetComponent<SpawnarMunicao>();
        //vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void DesligarSpawnMunicao()
    {
        for(int i=0; i< spawnarMunicao_ref.ListMunicao.Count; i++)
        {
            spawnarMunicao[i].enabled = false;
        }
        
        
    }
}
