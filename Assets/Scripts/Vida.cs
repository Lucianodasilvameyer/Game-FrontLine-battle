using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Vida : MonoBehaviour
{
   

    public event Action OnDeath; 

    [SerializeField]
    BarraDeHP hpBar;

    private int HPMax = 7;
    
    public int hp;
    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;

            if (hp <= 0)
            {                
                hp = 0;

                Game.singleton.DesligarSpawnmunicao();
                Game.singleton.DesligarSpawnArmadilhas();
                Game.singleton.AtivarGameOver();
                Game.singleton.AtivarBotaoBack();

                if(OnDeath != null)
                {
                    OnDeath();
                    OnDeath = null;
                }

            }
            else if (hp >= HPMax)
            {
                hp = HPMax;
            }

            hpBar.Counter = hp;
        }

    }
    private void Start()
    {
        
    }

    private void Awake()
    {
       

        HP = HPMax;
        
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            HP--;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            HP++;
        }
    }
}
