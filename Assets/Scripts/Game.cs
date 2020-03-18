using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Game : NetworkBehaviour
{
    CanhaoMovimento canhaoMovimento_ref;
    public static Game singleton;

    Vida vida_ref;
    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    public GameObject GameOver;

    public GameObject BotaoBack;

    SpawnarArmadilhas[] spawnarArmadilhas;
    SpawnarArmadilhas spawnarArmadilhas_ref;

    SpawnarMunicao[] spawnarMunicao;
    SpawnarMunicao spawnarMunicao_ref;


    void Awake()
    {
        usarRefereciaDoPlayer_ref = GameObject.Find("Game").GetComponent<UsarRefereciaDoPlayer>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
        //canhaoMovimento_ref = GameObject.Find("Canhao").GetComponent<CanhaoMovimento>();


        if(singleton != null && singleton != this)
        {
            GameObject.Destroy(this);
        }
        else
        {
            singleton = this;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        

        
        




        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    


   
    
    


    public void DesligarSpawnArmadilhas()
    {
        if (spawnarArmadilhas_ref.ListArmadilhas != null)
        {
            for (int i = 0; i < spawnarArmadilhas_ref.ListArmadilhas.Count; i++)
            {
                spawnarArmadilhas[i] = spawnarArmadilhas_ref.ListArmadilhas[i].GetComponent<SpawnarArmadilhas>();
                spawnarArmadilhas[i].enabled = false;

            }
        }
    }
    public void DesligarSpawnmunicao()
    {
        if (spawnarMunicao_ref.ListMunicao != null)
        {
            for (int i = 0; i < spawnarMunicao_ref.ListMunicao.Count; i++)
            {
                spawnarMunicao[i] = spawnarMunicao_ref.ListMunicao[i].GetComponent<SpawnarMunicao>();
                spawnarMunicao[i].enabled = false;
            }
        }
    }
    public void AtivarGameOver()
    {
         GameOver.SetActive(true);
                
    }
    public void AtivarBotaoBack()
    {
        BotaoBack.SetActive(true);   
                
            
        
    }
    /*public void DesativarCanhaoMovimento()
    {
        if(usarRefereciaDoPlayer_ref.ListCanhao !=null)
        {
            for(int i=0;i<usarRefereciaDoPlayer_ref.ListCanhao.Count; i++)
            {
                
                
                    canhaoMovimento_ref.enabled = false;
                
            }
        }
    }*/


    
}
