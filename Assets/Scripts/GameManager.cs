using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int puntaje;
    public int nivel = 0;
    public int parte;
    public GameObject cardRev;
    public GameObject temp;
    public string grupoRev;
    List<string> datosRev = new List<string>();


    public static GameManager Instance { get; private set; }

    private void Awake() 
    {
        Instance = this;
    }

    void Start()
    {
        puntaje = 0;
        SetNivel();
    }

    void SetNivel()
    {
        nivel++;
        parte = 0;
        setParte();
        switch (nivel)
        {
            case 1:
                Debug.Log("Nivel 1");
                break;
            case 2:
                Debug.Log("Nivel 2");
                break;
            case 3:
                Debug.Log("Nivel 3");
                break;
            case 4:
                Debug.Log("Nivel 4");
                break;
            case 5:
                Debug.Log("Nivel 5");
                break;
            default:
                Debug.Log("Algo paso mal.... niveles");
                break;
        }
    }

    void setParte()
    {
        parte++;
        switch (parte)
        {
            case 1:
                //Debug.Log("Parte 1");
                break;
            case 2:
                Debug.Log("Parte 2");
                break;
            case 3:
                Debug.Log("Parte 3");
                break;
            default:
                Debug.Log("Algo paso mal.... por partes");
                break;
        }
    }

    public void changePuntaje(string grupo)
    {
        Debug.Log("CHANGE PUNTAJE - GM");
        Debug.Log(grupo + " -- " + grupoRev);
        if (grupoRev == grupo)
        {
            Debug.Log("Bien!");
            puntaje++;
        }
        else
        {
            Debug.Log("Mal!");
            puntaje--;
        }
    }

    public void RevisarCard(GameObject GO)
    {
        //Recibe card y depnde de la parte y nivel, revisa cosa distintas
        //Debug.Log("GO: " + GO);
        cardRev = GO;
        switch (nivel)
        {
            case 1:
                //Debug.Log("Nivel 1 - RevCard");
                RevisarNivel1();
                break;
            case 2:
                Debug.Log("Nivel 2");
                break;
            case 3:
                Debug.Log("Nivel 3");
                break;
            case 4:
                Debug.Log("Nivel 4");
                break;
            case 5:
                Debug.Log("Nivel 5");
                break;
            default:
                Debug.Log("Algo paso mal.... - RevCard: nivel ->" + nivel);
                break;
        }
    }

    void RevisarNivel1()
    {
        switch (parte)
        {
            case 1:
                //Mayores y menores de edad
                datosRev.Add(cardRev.transform.Find("Profile-Info").transform.Find("Edad").GetComponent<TextMeshPro>().text);
                Debug.Log(datosRev[0]);
                //Grupo 1 --> menores
                //Grupo 2 --> mayores
                if (int.Parse(datosRev[0].Substring(6)) >= 18)
                {
                    grupoRev = "Grupo2";
                }
                else
                {
                    grupoRev = "Grupo1";
                }
                //Debug.Log("-----> " + datosRev[0].Substring(6));
                datosRev.Clear();
                break;
            default:
                break;
        }
        //Debug.Log("GRUPO REV: " + grupoRev);

    }


}
