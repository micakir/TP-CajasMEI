using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float min = -2f;
    public float max = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-2,0,0);
            float restrictedX = Mathf.Clamp(transform.position.x, min, max);
            transform.position = new Vector3(restrictedX, 0.5f, 0.75f);
        }
          
        if(Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(2,0,0);
            float restrictedX = Mathf.Clamp(transform.position.x, min, max);
            transform.position = new Vector3(restrictedX, 0.5f, 0.75f);
        }

        //Calculo que debe haber una mejor manera pero bueno esto fue lo que salió
    }
}
