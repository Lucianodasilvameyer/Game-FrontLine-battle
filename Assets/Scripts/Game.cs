using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Game : NetworkBehaviour
{
    
    public static Game singleton;

    SpriteRenderer spriteRenderer_ref;

    Vida vida_ref;
    UsarRefereciaDoPlayer usarRefereciaDoPlayer_ref;

    public GameObject GameOver;

    public GameObject BotaoBack;



    SpawnarArmadilhas[] spawnarArmadilhas;
    SpawnarArmadilhas spawnarArmadilhas_ref;

    
    SpawnarMunicao spawnarMunicao_ref;
    SpawnarMunicao[] spawnarMunicao;


    void Awake()
    {
        spriteRenderer_ref = GameObject.Find("GameOver").GetComponent<SpriteRenderer>();
        usarRefereciaDoPlayer_ref = GetComponent<UsarRefereciaDoPlayer>();
        spawnarArmadilhas_ref = GetComponent<SpawnarArmadilhas>();
       
        spawnarMunicao_ref = GetComponent<SpawnarMunicao>();



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

        spawnarArmadilhas_ref.enabled = false;
        
    }
    public void DesligarSpawnmunicao()
    {
        spawnarMunicao_ref.enabled = false;
        /*if (spawnarMunicao_ref.ListMunicao != null)
        {
            for (int i = 0; i < spawnarMunicao_ref.ListMunicao.Count; i++)
            {
                GameObject [] municoes = spawnarMunicao_ref.ListMunicao.ToArray();

               
                municoes[i].SetActive(false);
            }
        }*/
    }
    public void AtivarGameOver()
    {
        spriteRenderer_ref.enabled = true;
                
    }
    public void AtivarBotaoBack()
    {
        BotaoBack.SetActive(true);   
                
            
        
    }
    


    
}
