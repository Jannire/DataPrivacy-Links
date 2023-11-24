using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int balance = 0;
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

    //Set nivel y parte son más que nada para cinematicas
    public void SetNivel()
    {
        nivel++;
        switch (nivel)
        {
            case 1:
                Debug.Log("Nivel 1");
                SystemDialogue.Instance.unHideUI();
                SystemDialogue.Instance.NextDialogue();
                //Generar users DB
                balance += 200;
                break;
            case 2:
                Debug.Log("Nivel 2");
                SystemDialogue.Instance.HideUI();
                NextScene();
                /*SystemDialogue2.Instance.unHideUI();
                SystemDialogue2.Instance.NextDialogue();*/
                balance += 100;
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
            balance += 50;
        }
        else
        {
            balance -= 70;
        }
        if (balance <= 0)
        {
            if(nivel == 1)
            {
                SystemDialogue.Instance.death();    
            }
            if(nivel == 2)
            {
                SystemDialogue2.Instance.death();    
            }
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

    public void RevisarNivel2(string nombre)
    {
        nombre = nombre.Substring(2);
        Debug.Log("Elegido: " + nombre);
        if(nombre == "jairo" || nombre == "mirason") //Cambiar el nombre mal escrito
        {
            SystemDialogue2.Instance.FinDemo();
            Debug.Log("Fin de la demo");
        }
        else
        {
            SystemDialogue2.Instance.MalaEleccion();
            balance -= 100;
        }
        bal.GetComponent<TextMeshProUGUI>().text = "Balance: " + balance;
    }
}
