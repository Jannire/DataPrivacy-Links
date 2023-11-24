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

    List<string> data_ = new List<string>();
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

        //Debug.Log("Spawn 2: " + nameO);
        if (conexion.activeSelf)
        {
            data.GetComponent<TextMeshPro>().text += "\n";
            switch (nameO)
            {
                case "Carlos":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text += "Ahorros: 10k";
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \nAnalista Inmobiliario";
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text += "Seguro publico";
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text += "4 dispositivos conectados";
                    }
                    break;
                case "Jairo":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text += "Ahorros: 50k";
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \nJefe de Contabilidad";
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text += "Seguro privado";
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text += "8 dispositivos conectados";
                    }
                    break;
                case "Mirasol":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text += "Ahorros: 15k";
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \nAbogada";
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text += "Seguro privado";
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text += "3 dispositivos conectados";
                    }
                    break;
                case "Beth":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text += "Ahorros: 3k";
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \nPracticante de Marketing";
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text += "Seguro publico";
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text += "2 dispositivos conectados";
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
            data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("\n", "");
            switch (nameO)
            {
                case "Carlos":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Ahorros: 10k", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto:";
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Seguro publico", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("4 dispositivos conectados", "");
                    }
                    break;
                case "Jairo":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Ahorros: 50k", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \n" + work.GetComponent<TextMeshPro>().text.Replace("Puesto: \n", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Seguro privado", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("8 dispositivos conectados", "");
                    }
                    break;
                case "Mirasol":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Ahorros: 15k", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \n" + work.GetComponent<TextMeshPro>().text.Replace("Puesto: \n", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Seguro privado", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("3 dispositivos conectados", "");
                    }
                    break;
                case "Beth":
                    if (temp.activeSelf && temp.name == "BD-Bank")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Ahorros: 3k", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Links")
                    {
                        work.GetComponent<TextMeshPro>().text = "Puesto: \n" + work.GetComponent<TextMeshPro>().text.Replace("Puesto: \n", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-Hospital")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("Seguro publico", "");
                    }
                    if (temp.activeSelf && temp.name == "BD-MusicRy")
                    {
                        data.GetComponent<TextMeshPro>().text = data.GetComponent<TextMeshPro>().text.Replace("2 dispositivos conectados", "");
                    }
                    break;
                default:
                    break;
            }

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
