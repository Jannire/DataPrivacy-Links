using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SystemDialogue : MonoBehaviour
{
    public String[] dia = {
        "Buenos días, hoy tenemos unas tareas simples para iniciar",
        "Logre obtener estas bases de datos de nuestros brokers usuales",
        "Quieren conocer más sobre estas personas, asi que ya sabes que hacer",
        "Para poder conocer más sobre una persona debemos encontrarla en una de estas bases de datos",
        "Haz clic en el triangulo de la base de datos donde la encuentres",
        "No olvides ninguna aparicion, ni pongas de mas. Lo reducire de tu paga",
        "Las personas tienen distintos comportamiento en las redes", 
        "Ciertas personas cuidan más su huella digital, otros no tanto"
    };
    public int[] stops = { 6, 8 };

    public GameObject dialogue_text;
    public GameObject UI;
    public GameObject fondo;
    public int it = 0, part = 0;
    public static SystemDialogue Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        stops = new int[] { 6, 8 };
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextDialogue()
    {
        //Mejora siguiente -> Repetir parte con boton solo reiniciar iterador y parte
        if (stops[part] == it)
        {
            Debug.Log($"Stop - it: {it} // stop: {stops[part]} // Parte: {part}");
            HideUI();
            part++;
        }
        else
        {
            dialogue_text.GetComponent<TextMeshProUGUI>().text = dia[it];
            it++;

        }
    }

    public void Esperar()
    {

    }

    public void HideUI()
    {
        UI.SetActive(false);
        fondo.SetActive(false);
    }

    public void unHideUI()
    {
        UI.SetActive(true);
        fondo.SetActive(true);
    }
}
