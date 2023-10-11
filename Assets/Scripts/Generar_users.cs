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
    #region randomizar
    public int edad;
    public string nombre;
    public string gender;
    public string[] nombresF = {"Stormy", "Sketches", "Andrea", "Ana2001", "Carolina123", "Lux", "Hilda_A"};
    public string[] nombresM = {"MiguelGG", "Piero", "Diego", "Juan", "Carlos_20", "Alexis_AE", "Ignacio123", "Storm"};
    public string[] generos = {"F", "M"};
    #endregion

    
    void Update()
    {
        if (!GameObject.Find("User_card(Clone)"))
        {
            Generar_card();
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
    }

}
