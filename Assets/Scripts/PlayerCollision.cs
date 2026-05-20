using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public Timer timer;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            timer.juegoTerminado = true;
            col.gameObject.GetComponent<CajaMovement>().enabled = false;
            Destroy(gameObject);
        }
    }
}
