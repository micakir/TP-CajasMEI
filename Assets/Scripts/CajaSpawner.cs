using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaSpawner : MonoBehaviour
{
    int randomNumber;
    public float startYvalue;
    private CajaMovement cajaMovement;

    // Start is called before the first frame update
    void Start()
    {
        cajaMovement = GetComponent<CajaMovement>();
        LocateBoxAtRandomPosition();
    }
    
     public void LocateBoxAtRandomPosition()
     {
        cajaMovement.speed += 0.05f;
        Vector3 currentPosition = transform.position;
        float newX = 0;

        randomNumber = Random.Range(0,3);
        if(randomNumber == 0)
        {
            newX = -2f;
        }else if(randomNumber == 1)
        {
            newX = 0f;
        }else if(randomNumber == 2)
        {
            newX = 2f;
        }
        currentPosition.x = newX;
        currentPosition.y = startYvalue;
        transform.position = currentPosition;
     } 

    //CUANDO LA CAJA TOQUE EL PISO QUE SE REPOSICIONE USANDO LA FUNCION
    //ah pero para eso no esta hecho ya??
}
