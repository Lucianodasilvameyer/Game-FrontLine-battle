using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Mirror;

public class TiroDoPlayer : NetworkBehaviour
{
   

    [SerializeField]
    Municao municao;

    public Rigidbody2D bullet;
    public Transform bulletExit;

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && municao.Ammo > 0)
            {
                ShootAt();
            }
        }
        
    }

    void ShootAt()
    {
        Rigidbody2D bulletRgbd = Instantiate(bullet, bulletExit.position, bulletExit.rotation);

        municao.Ammo--;

        //camScript.cameraShake();
    }
}
