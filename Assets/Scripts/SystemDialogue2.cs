using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SystemDialogue2 : MonoBehaviour
{
    public string[] dia;
    public int[] stops;

    public GameObject dialogue_text;
    public GameObject UI;
    public GameObject fondo;
    public GameObject boton;
    public GameObject lose;
    public int it = 0, part = 0;

    public static SystemDialogue2 Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        Debug.Log("-------------------------------------Sys2");
        //Start();
        //DontDestroyOnLoad(this);
    }

    void Start()
    {
        stops = new int[] { 6, 8 };
        dia = new string[] {
            "Disculpa la interrupción, tengo una mejor tarea para ti",
            "Estuve buscando a unos trabajadores de la red social 'Links'",
            "Creo que nos vendría bien tener información nueva de sus usuarios",
            "Entre estas personas podríamos hacernos con sus cuentas y acceso al trabajo",
            "Necesito que investigues a estas personas y me digas a quien vale la pena interceptar para apropiarnos de sus cuentas",
            "Con suficientes fondos, compra unas nuevas bases de datos para conocer mejor a nuestras cuatro opciones", //Stop 1 - 6
            "Haz click en el card de una persona para abrir su información", 
            "Cuando estes listo, me avisas a quien decidimos atacar", //Stop 2 - 8
        };
        unHideUI();
        NextDialogue();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextDialogue()
    {
        //Debug.Log($"Update dialogue: {UI}, {dialogue_text}, {fondo}");
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
            Debug.Log("It: " + it);
        }
    }

    public void Esperar()
    {
        unHideUI();
        boton.SetActive(false);
        fondo.SetActive(false);
        dialogue_text.GetComponent<TextMeshProUGUI>().text = "Selecciona a quien deseas atacar";
    }

    public void MalaEleccion()
    {
        unHideUI();
        fondo.SetActive(false);
        boton.SetActive(false);
        dialogue_text.GetComponent<TextMeshProUGUI>().text = "No creo que esa sea una buena elección...";
    }
    
    public void FinDemo()
    {
        unHideUI();
        boton.SetActive(false);
        dialogue_text.GetComponent<TextMeshProUGUI>().text = "Gracias por jugar la demo de Links! Pronto tendrá nuevas actualizaciones";
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

    public void death()
    {
        HideUI();
        lose.SetActive(true);
    }
}
