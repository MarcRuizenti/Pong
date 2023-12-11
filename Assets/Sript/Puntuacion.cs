using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public int jugador1 = 0;
    public TMP_Text jugador1Texto;
    public GameObject jugador1Gandor;

    public int jugador2 = 0;
    public TMP_Text jugador2Texto;
    public GameObject jugador2Gandor;

    public GameObject boton;




    void Update()
    {
        jugador1Texto.text = jugador1.ToString();
        jugador2Texto.text = jugador2.ToString();
        if(jugador1 >= 10)
        {
            jugador1Gandor.SetActive(true);
            boton.SetActive(true);
            Time.timeScale = 0f;
        }
        if (jugador2 >= 10)
        {
            jugador2Gandor.SetActive(true);
            boton.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
