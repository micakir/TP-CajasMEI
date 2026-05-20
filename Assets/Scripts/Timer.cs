using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI txt_Timer;

    float tiempo;

    public bool juegoTerminado = false;

    void Update()
    {
        if(juegoTerminado == false)
        {
            tiempo += Time.deltaTime;

            txt_Timer.text = "Tiempo: " + tiempo.ToString("F2");
        }
    }
}
