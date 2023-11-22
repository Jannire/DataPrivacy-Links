using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pBien = 0, pMal = 0, balance = 0;
    public int nivel = 0;
    public GameObject temp;
    public bool adquirir = true;
    public Transform bal;
    public int sceneNum;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        SetNivel();
        bal = null;
        temp = GameObject.Find("Balance-Text");
        bal = temp.transform;
        sceneNum = 0;
    }

    void Update()
    {
        temp = GameObject.Find("Balance-Text");
        bal = temp.transform;
        bal.GetComponent<TextMeshProUGUI>().text = "Balance: " + balance;
    }

    void NextScene()
    {
        sceneNum++;
        SceneManager.LoadScene(sceneNum);
        temp = GameObject.Find("Balance-Text");
        bal = temp.transform;
        
    }

    public void setLevelAndPart()
    {
        //Debug.Log("Bien: " + pBien + "\nMal: " + pMal);
        SetNivel();
    }

    //Set nivel y parte son más que nada para cinematicas
    public void SetNivel()
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
                NextScene();
                break;
            case 3:
                Debug.Log("Nivel 3");
                balance += 100;
                NextScene();
                break;
            default:
                Debug.Log("Algo paso mal.... niveles");
                break;
        }
        bal.GetComponent<TextMeshProUGUI>().text = "Balance: " + balance;
    }

    public void changePuntaje(bool[] validar, bool[] real)
    {
        bool correcto = true;
        for (int i = 0; i < 5; i++)
        {
            if (validar[i] != real[i])
            {
                correcto = false;
                break;
            }
        }
        if (correcto)
        {
            pBien++;
            balance += 50;
        }
        else
        {
            pMal++;
            balance -= 70;
        }
        if (balance <= 0)
        {
            Debug.Log("Fin del juego");
        }
        bal.GetComponent<TextMeshProUGUI>().text = "Balance: " + balance;

    }

    public void adquirir_crawlers(string nam)
    {
        if (nam == "Crawler")
        {
            Debug.Log("Solo crawlers");
            adquirir = false;
        }
        else if (nam == "Wilson")
        {
            balance -= 250;
            adquirir = true;
            Debug.Log("Comprar BDs");
        }
        bal.GetComponent<TextMeshProUGUI>().text = "Balance: " + balance;
    }
}
