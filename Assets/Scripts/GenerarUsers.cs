using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GenerarUsers : MonoBehaviour
{
    //Nivel 1
    private int cantUsers = 10;
    private int currentUser = 0;
    private bool isUser = false;
    private List<int> dificultad = new List<int>();
    public GameObject user;
    private Transform temp;
    private GameObject userTemp;
    private string[] nombres = { "Carolina01", "Amanda_RP", "Diego92", "Ana_Torres", "Lucio123", "Piero_S", "Luciana_Mari", "Pedro88", "JaimeTech", "Sofia" };
    private bool[] validar = { false, false, false, false, false };
    #region bds
    public Transform Bank;
    public Transform Links;
    public Transform Game;
    public Transform Fitness;
    public Transform Tienda;
    #endregion

    public static GenerarUsers Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        setDificultadUsers();
    }

    void Update()
    {
        if (currentUser == cantUsers)
        {
            Debug.Log("Finalizar nivel");
            GameManager.Instance.SetNivel();
        }
        else if (!isUser)
        {
            spawnUser(dificultad[currentUser]);
        }
    }

    void setDificultadUsers()
    {
        for (int i = 0; i < cantUsers; i++)
        {
            dificultad.Add(UnityEngine.Random.Range(1, 4));
        }

        Debug.Log("Dificultades: " + String.Join(" - ", dificultad));
        //Debug.Log($"cantUsers: {cantUsers} - currentUser: {currentUser} - isUser:{isUser}");
    }

    void spawnUser(int dif)
    {
        //Debug.Log("New user generated");
        currentUser++;
        userTemp = Instantiate(user, transform.position, Quaternion.identity);
        setNombres(currentUser, userTemp);
        isUser = true;
        changeBD(dif);
    }

    void setNombres(int curr, GameObject userTemp)
    {
        temp = userTemp.transform.Find("Name");
        temp.GetComponent<TextMeshPro>().text = "Usuario: " + nombres[curr];
    }

    void changeBD(int dif)
    {
        //Debug.Log("Dificultad: " + dif);
        llenarExtrasFalsosBD(Bank);
        llenarExtrasFalsosBD(Links);
        llenarExtrasFalsosBD(Game);
        llenarExtrasFalsosBD(Fitness);
        llenarExtrasFalsosBD(Tienda);
        for (int i = 0; i < 5; i++)
        {
            validar[i] = false;
        }
        switch (dif)
        {
            case 1:
                //Facil - Todos
                llenarExtrasBD(Bank);
                llenarExtrasBD(Links);
                llenarExtrasBD(Game);
                llenarExtrasBD(Fitness);
                llenarExtrasBD(Tienda);
                for (int i = 0; i < 5; i++)
                {
                    validar[i] = true;
                }
                break;
            case 2:
                //Medio - Banco, Links, (Fitness o Tienda)
                llenarExtrasBD(Bank);
                llenarExtrasBD(Links);
                validar[0] = true;
                validar[1] = true;
                int escoger = UnityEngine.Random.Range(0, 3);
                switch (escoger)
                {
                    case 0:
                        llenarExtrasBD(Fitness);
                        validar[3] = true;
                        break;
                    case 1:
                        llenarExtrasBD(Tienda);
                        validar[4] = true;
                        break;
                    case 2:
                        llenarExtrasBD(Fitness);
                        llenarExtrasBD(Tienda);
                        validar[3] = true;
                        validar[4] = true;
                        break;
                    default:
                        Debug.Log("Error: Dif medio");
                        break;
                }
                break;
            case 3:
                //Dificil - Solo Banco y Links
                llenarExtrasBD(Bank);
                llenarExtrasBD(Links);
                validar[0] = true;
                validar[1] = true;
                break;
            default:
                Debug.Log("Error dificultad");
                break;
        }


    }

    void llenarExtrasBD(Transform obj)
    {
        int id;
        int ord = UnityEngine.Random.Range(0, 5);
        string[] bds = { "starli", "portal23", "Waesly", "Tom_90", "Amanda123", "CelesteFar", "Psush", "Hgib", "124Film", "Josh78", "Mads_98", "Op334" };
        obj.GetComponent<TextMeshPro>().text = "ID" + "      " + "Username";
        for (int i = 0; i < 5; i++)
        {
            id = UnityEngine.Random.Range(0, 99);
            if (i == ord)
            {
                obj.GetComponent<TextMeshPro>().text = obj.GetComponent<TextMeshPro>().text + "\n" + id + "      " + nombres[currentUser];
            }
            else
            {
                obj.GetComponent<TextMeshPro>().text = obj.GetComponent<TextMeshPro>().text + "\n" + id + "      " + bds[UnityEngine.Random.Range(0, bds.Length)];
            }
        }
    }

    void llenarExtrasFalsosBD(Transform obj)
    {
        int id;
        obj.GetComponent<TextMeshPro>().text = "ID" + "      " + "Username";
        string[] bds = { "starli", "portal23", "Waesly", "Tom_90", "Amanda123", "CelesteFar", "Psush", "Hgib", "124Film", "Josh78", "Mads_98", "Op334" };
        for (int i = 0; i < 5; i++)
        {
            id = UnityEngine.Random.Range(0, 99);
            obj.GetComponent<TextMeshPro>().text = obj.GetComponent<TextMeshPro>().text + "\n" + id + "      " + bds[UnityEngine.Random.Range(0, bds.Length)];
        }
    }

    public bool[] RevisarConexiones()
    {
        bool[] conPuntaje = { false, false, false, false, false };
        string[] nomsConexiones = { "Conexion-Bank", "Conexion-Links", "Conexion-Game", "Conexion-Fitness", "Conexion-Tienda"};
        for (int i = 0; i < nomsConexiones.Length; i++)
        {
            if (GameObject.Find(nomsConexiones[i]) != false)
            {
                conPuntaje[i] = true;
            }
        }
        return conPuntaje;
    }

    public void ResetearConexiones()
    {
        string[] nomsConexiones = { "Conexion-Bank", "Conexion-Links", "Conexion-Game", "Conexion-Fitness", "Conexion-Tienda"};
        for (int i = 0; i < nomsConexiones.Length; i++)
        {
            if (GameObject.Find(nomsConexiones[i]) != false)
            {
                GameObject.Find(nomsConexiones[i]).SetActive(false);
            }
        }
    }

    public void next()
    {
        isUser = false;
        bool[] p = RevisarConexiones();
        Destroy(userTemp);
        GameManager.Instance.changePuntaje(validar, p);
        ResetearConexiones();
    }
}