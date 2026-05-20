using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
    }
}
