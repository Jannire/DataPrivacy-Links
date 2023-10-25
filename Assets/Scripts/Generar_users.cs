
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Generar_users : MonoBehaviour
{
    public GameObject card;
    public GameObject user_card;
    private Transform hijo_temp;
    private List<int> tempList = new List<int>(); //GameManager.Instance.cantCards[GameManager.Instance.nivel]
    [SerializeField] private List<string> busquedas = new List<string>();
    private int rand;
    private string temp = "";
    #region randomizar
    public int edad;
    public string nombre;
    public string gender;
    public string[] nombresF = { "Stormy", "Sketches", "Andrea", "Ana2001", "Carolina123", "Lux", "Hilda_A" };
    public string[] nombresM = { "MiguelGG", "Piero", "Diego", "Juan", "Carlos_20", "Alexis_AE", "Ignacio123", "Storm" };
    public string[] generos = { "F", "M" };
    #endregion

    void Update()
    {
        //Debug.Log("Parte: " + GameManager.Instance.parte + " - Cards: " + tempList[GameManager.Instance.parte]);
        tempList = (List<int>)GameManager.Instance.cantCards[GameManager.Instance.nivel];
        Debug.Log("cCards: " + GameManager.Instance.cCards);
        Debug.Log("Templist: " + tempList[GameManager.Instance.parte - 1]);
        
        if (GameManager.Instance.cCards >= tempList[GameManager.Instance.parte - 1])
        {   
            Debug.Log("cCards: " + GameManager.Instance.cCards + " - Total: " + tempList[GameManager.Instance.parte - 1]);
            GameManager.Instance.setLevelAndPart();
            Debug.Log("Nivel - Instance parte: " + GameManager.Instance.parte);
            Debug.Log("Boolean " + GameObject.Find("User_card(Clone)"));
        }
        
        Debug.Log("Boolea antes del if " + GameObject.Find("User_card(Clone)"));
        if (!GameObject.Find("User_card(Clone)"))
        {
            Generar_card();
            Debug.Log("Mi problema: " + GameManager.Instance.parte);
            if (GameManager.Instance.parte == 1)
            {
                switch (GameManager.Instance.nivel)
                {
                    case 1:
                        //Debug.Log("Card1_1");
                        break;
                    case 2:
                        Card2_1();
                        break;
                    case 3:
                        Card3_1();
                        break;
                }
            }
            else if (GameManager.Instance.parte == 2)
            {
                Debug.Log("PARTE 2!!!!!");
                switch (GameManager.Instance.nivel)
                {
                    case 1:
                        Card1_2();
                        break;
                    case 2:
                        Card2_2();
                        break;
                    case 3:
                        Card3_2();
                        break;
                }
            }
            else if (GameManager.Instance.parte == 3)
            {
                switch (GameManager.Instance.nivel)
                {
                    case 1:
                        Card1_3();
                        break;
                    case 2:
                        Debug.Log("Card2_3()");
                        break;
                    case 3:
                        Debug.Log("Card3_3()");
                        break;
                }
            }
            busquedas.Clear(); 
            //Mandar card a GameManager para subir o restar puntaje
            //Debug.Log("usercard: " + user_card);
            GameManager.Instance.RevisarCard(user_card);
        }
    }

    void Generar_randoms()
    {
        gender = generos[Random.Range(0, 2)];
        if (gender == "F")
        {
            nombre = nombresF[Random.Range(0, nombresF.Length)];
        }
        else
        {
            nombre = nombresM[Random.Range(0, nombresM.Length)];
        }
        edad = Random.Range(13, 40);
    }

    void Generar_card()
    {
        Generar_randoms();
        user_card = Instantiate(card, transform.position, Quaternion.identity);
        hijo_temp = user_card.transform.Find("Profile-Info").transform.Find("Username");
        hijo_temp.GetComponent<TextMeshPro>().text = "Username: " + nombre;

        hijo_temp = user_card.transform.Find("Profile-Info").transform.Find("Edad");
        hijo_temp.GetComponent<TextMeshPro>().text = "Edad: " + edad.ToString();

        hijo_temp = user_card.transform.Find("Profile-Info").transform.Find("Genero");
        hijo_temp.GetComponent<TextMeshPro>().text = "Genero: " + gender;
    }

    void Card1_2()
    {
        //3 opciones || En pareja, soltero y buscando pareja, soltero y no buscando pareja
        /*
            •	Estado – información del perfil
            •	Búsquedas (Se toma en cuenta que se acerca san Valentín)
                o	Mejores chocolates para regalar
                o	Precio flores
                o	*Nada pertinente*
                o	¿Cómo saber si le gusto a alguien?
        */
        //Utilizar la misma lista 0-3 Parejas, 4-6 buscando, 7-10 no buscando
        busquedas.AddRange(new string[10] { "Mejores chocolates para regalar", "Precios de flores", "Lugares para salir", "Regalos para aniversario",
                                            "¿Como declararme?", "Tips para saber si le gusto a alguien", "Apps para citas", 
                                            "Celulares 2023", "Outfits verano", "Rutina de ejercicio"});
        
        rand = Random.Range(0, 3);
        hijo_temp = user_card.transform.Find("Busquedas").transform.Find("Busquedas-items");
        switch (rand)
        {
            case 0:
                //pareja
                temp = busquedas[Random.Range(0, 4)];
                break;
            case 1:
                //buscando
                temp = busquedas[Random.Range(4, 7)];
                break;
            case 2:
                //no buscando
                temp = busquedas[Random.Range(7, 11)];
                break;
            default:
                temp = "Error";
                break;
        }
        hijo_temp.GetComponent<TextMeshPro>().text = "- " + temp;

    }

    void Card1_3()
    { 
        //4 opciones || (Trabajando, estudiando), (Trabajando, no estudiando), (No trabajando, estudiando), (No trabajando, no estudiando)
        /*
            •	Estado – información del perfil
            •	Búsquedas
                o	Outfits para universidad
                o	Sueldo mínimo practicante
                o	Entrevistas recién graduados
                o	Balance trabajo y estudio
                o	¿Como encontrar trabajo sin estudios?

        */
        //0-3 Trabajando, 4-6 estudiando, 7-9 Ambos, 10-12 Ninguno
        busquedas.AddRange(new string[13] { "Entrevistas recien graduados", "¿Como encontrar trabajo sin estudios?", "Tips para pedir aumento", "Snacks para oficina",
                                            "Rutina de estudio", "Outfits para universidad", "Snacks para clases", 
                                            "Balance estudio y trabajo", "Sueldo minimo practicantes", "Rutina de trabajo y estudio",
                                            "Celulares 2023", "Outfits verano", "Rutina de ejercicio"});
        
        rand = Random.Range(0, 3);
        hijo_temp = user_card.transform.Find("Busquedas").transform.Find("Busquedas-items");
        switch (rand)
        {
            case 0:
                //pareja
                temp = busquedas[Random.Range(0, 4)];
                break;
            case 1:
                //buscando
                temp = busquedas[Random.Range(4, 7)];
                break;
            case 2:
                //no buscando
                temp = busquedas[Random.Range(7, 10)];
                break;
            default:
                temp = "Error";
                break;
        }
        hijo_temp.GetComponent<TextMeshPro>().text = "- " + temp;
    }

    void Card2_1()
    { }

    void Card2_2()
    { }

    void Card3_1()
    { }

    void Card3_2()
    { }


}
