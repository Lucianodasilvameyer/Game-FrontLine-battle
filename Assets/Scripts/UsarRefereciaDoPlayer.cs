using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarRefereciaDoPlayer : MonoBehaviour
{
    

    public List<GameObject> ListPlayer = new List<GameObject>();
    public List<GameObject> ListCanhao = new List<GameObject>();
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
    public void AddPlayer(GameObject gameObject)
    {
        ListPlayer.Add(gameObject);
    }
    public void AddCanhao(GameObject gameObject)
    {
        ListCanhao.Add(gameObject);
    }
}
