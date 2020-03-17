using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarSpawnArmadilhas : MonoBehaviour
{
   
    SpawnarArmadilhas spawnarArmadilhas_ref;
    SpawnarArmadilhas[] spawnarArmadilhas;

    

    private void Awake()
    {
       
        spawnarArmadilhas_ref = GetComponent<SpawnarArmadilhas>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DesligarSpawnArmadilha()
    {
        for(int i=0 ; i < spawnarArmadilhas_ref.ListArmadilhas.Count; i++)
        {
            spawnarArmadilhas[i].enabled = false;
        }
    }
}
