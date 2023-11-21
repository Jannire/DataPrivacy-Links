using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuntosSpawn2 : MonoBehaviour
{
    public string nameO;
    public GameObject temp;
    public Transform data;
    public Transform work;

    [SerializeField] private GameObject conexion;
    public bool isActive = false;
    void Start()
    {
        conexion.SetActive(isActive);
        Debug.Log("Conexion: " + conexion.name + " --> " + conexion.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void infoNivel2()
    {
        switch (nameO)
        {
            case "Carlos":
                if (temp.activeSelf && temp.name == "BD-Bank")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Ahorros: 10k";
                }
                if (temp.activeSelf && temp.name == "BD-Links")
                {
                    work.GetComponent<TextMeshPro>().text = work.GetComponent<TextMeshPro>().text + "\n" + "Analista Inmobiliario";
                }
                if (temp.activeSelf && temp.name == "BD-Hospital")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Seguro publico";
                }
                if (temp.activeSelf && temp.name == "BD-MusicRy")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "4 dispositivos conectados";
                }
                break;
            case "Jairo":
                if (temp.activeSelf && temp.name == "BD-Bank")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Ahorros: 50k";
                }
                if (temp.activeSelf && temp.name == "BD-Links")
                {
                    work.GetComponent<TextMeshPro>().text = work.GetComponent<TextMeshPro>().text + "\n" + "Jefe de Finanzas";
                }
                if (temp.activeSelf && temp.name == "BD-Hospital")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Seguro privado";
                }
                if (temp.activeSelf && temp.name == "BD-MusicRy")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "8 dispositivos conectados";
                }
                break;
            case "Marisol":
                if (temp.activeSelf && temp.name == "BD-Bank")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Ahorros: 15k";
                }
                if (temp.activeSelf && temp.name == "BD-Links")
                {
                    work.GetComponent<TextMeshPro>().text = work.GetComponent<TextMeshPro>().text + "\n" + "Abogada";
                }
                if (temp.activeSelf && temp.name == "BD-Hospital")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Seguro privado";
                }
                if (temp.activeSelf && temp.name == "BD-MusicRy")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "3 dispositivos conectados";
                }
                break;
            case "Beth":
                if (temp.activeSelf && temp.name == "BD-Bank")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Ahorros: 3k";
                }
                if (temp.activeSelf && temp.name == "BD-Links")
                {
                    work.GetComponent<TextMeshPro>().text = work.GetComponent<TextMeshPro>().text + "\n" + "Practicante de Marketing";
                }
                if (temp.activeSelf && temp.name == "BD-Hospital")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "Seguro publico";
                }
                if (temp.activeSelf && temp.name == "BD-MusicRy")
                {
                    data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text + "\n" + "2 dispositivos conectados";
                }
                break;
            default:
                break;
        }
    }

    void OnMouseOver()
    {
        Debug.Log("Spawn2");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Spawn2--CLICK");
            conexion.SetActive(!conexion.activeSelf);
            infoNivel2();
        }
    }
}
