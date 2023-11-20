using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pBien = 0, pMal = 0, balance = 0;
    public int nivel = 0;
    private GameObject temp;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        SetNivel();
    }

    public void setLevelAndPart()
    {
        //Debug.Log("Bien: " + pBien + "\nMal: " + pMal);
        SetNivel();
    }

    //Set nivel y parte son más que nada para cinematicas
    void SetNivel()
    {
        nivel++;
        switch (nivel)
        {
            case 1:
                Debug.Log("Nivel 1");
                //Generar users DB
                balance += 200;
                break;
            case 2:
                Debug.Log("Nivel 2");
                balance += 100;
                break;
            case 3:
                Debug.Log("Nivel 3");
                balance += 100;
                break;
            default:
                Debug.Log("Algo paso mal.... niveles");
                break;
        }
    }

    public void changePuntaje(bool[] validar, bool[] real)
    {
        bool correcto = true;
        for (int i = 0; i < 5; i++)
        {
            if(validar[i] != real[i])
            {
                correcto = false;
                break;
            }
        }
        if(correcto)
        {
            pBien++;
            balance += 50;
        }
        else
        {
            pMal++;
            balance -= 70;
        }
        if(balance <= 0)
        {
            Debug.Log("Fin del juego");
        }
    }

    public void RevisarCard(GameObject GO)
    {
        //Recibe card y depnde de la parte y nivel, revisa cosa distintas
        //cardRev = GO;
        switch (nivel)
        {
            case 1:
                //Debug.Log("Nivel 1 - RevCard");
                RevisarNivel1();
                break;
            case 2:
                //Debug.Log("Nivel 2");
                RevisarNivel2();
                break;
            default:
                Debug.Log("Algo paso mal.... - RevCard: nivel ->" + nivel);
                break;
        }
        //datosRev.Clear();
        //buscar.Clear();
    }

    void RevisarNivel1()
    {

    }

    void RevisarNivel2()
    {

    }

    void RevisarNivel3()
    {

    }
}
