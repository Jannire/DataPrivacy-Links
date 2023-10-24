using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pBien = 0, pMal = 0;
    public int cont = -1, cCards = 0;
    public int nivel = 0, parte = 0, totPartes;
    public string grupoRev;
    public GameObject cardRev;
    private GameObject temp;
    List<int> ccCards = new List<int>();
    public Hashtable cantCards = new Hashtable();
    public List<string> datosRev = new List<string>();
    public List<string> buscar = new List<string>();

    [SerializeField] private GameObject grupo1;
    [SerializeField] private GameObject grupo2;
    [SerializeField] private GameObject grupo3;
    [SerializeField] private GameObject grupo4;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        SetNivel();
        cantCards.Add(1, new List<int> { 5, 5, 5 }); //Level 1
        cantCards.Add(2, new List<int> { 5, 5, 0 }); //Level 2
        cantCards.Add(3, new List<int> { 5, 5, 0 }); //Level 3
    }

    public void setLevelAndPart()
    {
        Debug.Log("Bien: " + pBien + "\nMal: " + pMal);
        pBien = 0;
        pMal = 0;
        if (parte == 3)
        {
            SetNivel();
        }
        else
        {
            setParte();
        }
    }

    //Set nivel y parte son más que nada para cinematicas
    void SetNivel()
    {
        nivel++;
        parte = 0;
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
        setParte();
    }

    void setParte()
    {
        parte++;
        totPartes++;
        cCards = 0;
        switch (totPartes)
        {
            case 1:
                Debug.Log("Parte 1.1");
                setGrupos(2);
                break;
            case 2:
                Debug.Log("Parte 1.2");
                setGrupos(3);
                break;
            case 3:
                Debug.Log("Parte 1.3");
                setGrupos(4);
                break;
            case 4:
                Debug.Log("Parte 2.1");
                break;
            case 5:
                Debug.Log("Parte 2.2");
                break;
            case 6:
                Debug.Log("Parte 2.3");
                break;
            case 7:
                Debug.Log("Parte 3.1");
                break;
            case 8:
                Debug.Log("Parte 3.2");
                break;
            case 9:
                Debug.Log("Parte 3.3");
                break;
            default:
                Debug.Log("Algo paso mal.... por partes");
                break;
        }
    }

    void setGrupos(int numG)
    {
        switch (numG)
        {
            case 0:
                grupo1.SetActive(false);
                grupo2.SetActive(false);
                grupo3.SetActive(false);
                grupo4.SetActive(false);
                break;
            case 2:
                temp = grupo1;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(-0.25344f, -0.04f, 0f); //Posición
                temp.transform.localScale = new Vector3(-0.485769f, 0.5493945f, 0f); //Scale

                temp = grupo2;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(0.25f, -0.04f, 0f);
                temp.transform.localScale = new Vector3(-0.485769f, 0.5493945f, 0f); //Scale

                temp = grupo3;
                temp.SetActive(false);

                temp = grupo4;
                temp.SetActive(false);
                break;
            case 3:
                temp = grupo1;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(-0.33648f, -0.04f, 0f); //Posición
                temp.transform.localScale = new Vector3(0.3196882f, 0.5493945f, 0f); //Scale

                temp = grupo2;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(0.01f, -0.04f, 0f);
                temp.transform.localScale = new Vector3(0.3196882f, 0.5493945f, 0f); //Scale

                temp = grupo3;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(0.355f, -0.04f, 0f);
                temp.transform.localScale = new Vector3(0.3196882f, 0.5493945f, 0f); //Scale

                temp = grupo4;
                temp.SetActive(false);
                break;
            case 4:
                temp = grupo1;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(-0.39677f, -0.04f, 0f); //Posición
                temp.transform.localScale = new Vector3(0.2258989f, 0.5493945f, 0f); //Scale

                temp = grupo2;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(-0.137f, -0.04f, 0f);
                temp.transform.localScale = new Vector3(0.2258989f, 0.5493945f, 0f); //Scale

                temp = grupo3;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(0.129f, -0.04f, 0f);
                temp.transform.localScale = new Vector3(0.2258989f, 0.5493945f, 0f); //Scale

                temp = grupo4;
                temp.SetActive(true);
                temp.transform.localPosition = new Vector3(0.387f, -0.04f, 0f);
                temp.transform.localScale = new Vector3(0.2258989f, 0.5493945f, 0f); //Scale
                break;
            default:
                Debug.Log("Error en setGrupos");
                break;
        }
    }

    public void changePuntaje(string grupo)
    {
        Debug.Log(grupo + " -- " + grupoRev);
        if (grupoRev == grupo)
        {
            pBien++;
        }
        else if (grupoRev == "")
        {
            ;
        }
        else
        {
            pMal++;
        }
        grupoRev = "";
        Debug.Log("CHANGE PUNTAJE - GM" + "-Mal: " + pMal + " -Bien" + pBien);
        //Debug.Log("--> " + grupoRev);
    }

    public void RevisarCard(GameObject GO)
    {
        //Recibe card y depnde de la parte y nivel, revisa cosa distintas
        cardRev = GO;
        cCards++;
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
            case 3:
                //Debug.Log("Nivel 3");
                break;
            case 4:
                //Debug.Log("Nivel 4");
                break;
            case 5:
                //Debug.Log("Nivel 5");
                break;
            default:
                Debug.Log("Algo paso mal.... - RevCard: nivel ->" + nivel);
                break;
        }
        datosRev.Clear();
        buscar.Clear();
    }

    void RevisarNivel1()
    {
        switch (parte)
        {
            case 1: //Mayores y menores de edad
                datosRev.Add(cardRev.transform.Find("Profile-Info").transform.Find("Edad").GetComponent<TextMeshPro>().text);
                if (int.Parse(datosRev[0].Substring(6)) >= 18)
                {
                    grupoRev = "Grupo2";
                }
                else
                {
                    grupoRev = "Grupo1";
                }
                datosRev.Clear();
                break;
            case 2:
                buscar.AddRange(new string[10] { "Mejores chocolates para regalar", "Precios de flores", "Lugares para salir", "Regalos para aniversario",
                                            "¿Como declararme?", "Tips para saber si le gusto a alguien", "Apps para citas",
                                            "Celulares 2023", "Outfits verano", "Rutina de ejercicio"});
                datosRev.Add(cardRev.transform.Find("Busquedas").transform.Find("Busquedas-items").GetComponent<TextMeshPro>().text);

                cont = buscar.FindIndex(a => a.Contains(datosRev[0].Substring(2)));
                if (cont >= 0 && cont < 4)
                {
                    grupoRev = "Grupo1";
                }
                else if (cont < 7)
                {
                    grupoRev = "Grupo2";
                }
                else
                {
                    grupoRev = "Grupo3";
                }
                datosRev.Clear();
                buscar.Clear();
                break;
            case 3:
                buscar.AddRange(new string[10] { "Entrevistas recien graduados", "¿Como encontrar trabajo sin estudios?", "Tips para pedir aumento", "Snacks para oficina",
                                            "Rutina de estudio", "Outfits para universidad", "Snacks para clases",
                                            "Balance estudio y trabajo", "Sueldo minimo practicantes", "Rutina de trabajo y estudio"});
                datosRev.Add(cardRev.transform.Find("Busquedas").transform.Find("Busquedas-items").GetComponent<TextMeshPro>().text);

                cont = buscar.FindIndex(a => a.Contains(datosRev[0].Substring(2)));

                //0-3 Trabajando, 4-6 estudiando, 7-9 Ambos, 10-12 Ninguno
                if (cont == 0 && cont < 4)
                {
                    grupoRev = "Grupo1";
                }
                else if (cont < 7)
                {
                    grupoRev = "Grupo2";
                }
                else if (cont < 10)
                {
                    grupoRev = "Grupo3";
                }
                else
                {
                    grupoRev = "Grupo4";
                }
                datosRev.Clear();
                buscar.Clear();
                break;
            default:
                break;
        }
    }

    void RevisarNivel2()
    {
        switch (parte)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
    }

    void RevisarNivel3()
    {
        switch (parte)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
    }
}
