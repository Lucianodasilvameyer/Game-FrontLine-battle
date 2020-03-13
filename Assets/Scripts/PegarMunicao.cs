using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarMunicao : MonoBehaviour
{
    [SerializeField]
    Municao municao;

    ReferenciaDoPlayerAoInstanciar referenciaDoPlayerAoInstanciar_ref;
    private void Awake()
    {
        referenciaDoPlayerAoInstanciar_ref = GameObject.Find("Game").GetComponent<ReferenciaDoPlayerAoInstanciar>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ammo"))
        {
            municao.Ammo++;

            Destroy(collision.gameObject);
        }
    }
    public void AddPlayer(GameObject gameObject)
    {
        referenciaDoPlayerAoInstanciar_ref.ListPlayer.Add(gameObject);
    }
}
