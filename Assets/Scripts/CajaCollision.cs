using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollision : MonoBehaviour
{
    public float speedIncrease = 1f;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Caja"))
        {
            col.gameObject.GetComponent<CajaSpawner>().LocateBoxAtRandomPosition();
            col.gameObject.GetComponent<CajaMovement>().speed += speedIncrease;
        }
    }
}
