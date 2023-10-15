using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Generar_users : MonoBehaviour
{
    public GameObject card;
    public GameObject user_card;
    public Transform hijo_temp;
    private List<int> tempList = new List<int>(); //GameManager.Instance.cantCards[GameManager.Instance.nivel]
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
        tempList = (List<int>)GameManager.Instance.cantCards[GameManager.Instance.nivel];
        if (GameManager.Instance.cCards >= tempList[GameManager.Instance.parte - 1])
        {
            GameManager.Instance.setLevelAndPart();
        }
        else if (!GameObject.Find("User_card(Clone)"))
        {
            Generar_card();
            if (GameManager.Instance.parte == 1)
            {
                switch (GameManager.Instance.nivel)
                {
                    case 1:
                        Debug.Log("Card1_1");
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
            else
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
        }
    }

    void Generar_randoms()
    {
        //Random.Range(15, 60);
        gender = generos[Random.Range(0, 2)];
        if (gender == "F")
        {
            nombre = nombresF[Random.Range(0, nombresF.Length)];
        }
        else
        {
            nombre = nombresM[Random.Range(0, nombresM.Length)];
        }
        edad = Random.Range(12, 65);
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

        //Mandar card a GameManager para subir o restar puntaje
        //Debug.Log("usercard: " + user_card);
        GameManager.Instance.RevisarCard(user_card);

    }

    void Card1_2()
    { }

    void Card1_3()
    { }

    void Card2_1()
    { }

    void Card2_2()
    { }

    void Card3_1()
    { }

    void Card3_2()
    { }


}
