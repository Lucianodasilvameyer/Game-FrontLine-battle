using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarMunicao : MonoBehaviour
{
    SpawnarMunicao spawnarMunicao_ref;

    [SerializeField]
    Municao municao;

    Game referenciaDoPlayerAoInstanciar_ref;
    private void Awake()
    {
        spawnarMunicao_ref = GameObject.Find("Game").GetComponent<SpawnarMunicao>();
        referenciaDoPlayerAoInstanciar_ref = GameObject.Find("Game").GetComponent<Game>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ammo"))
        {
            municao.Ammo++;

            spawnarMunicao_ref.adicionarOuDestruirMunicao(collision.gameObject);
        }
    }
    
}
