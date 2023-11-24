using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SystemDialogue : MonoBehaviour
{
    public string[] dia;
    public int[] stops;

    public GameObject dialogue_text;
    public GameObject UI;
    public GameObject fondo;
    public int it = 0, part = 0;
    public GameObject lose;
    public static SystemDialogue Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        Debug.Log("Awake?");
        Start();
        //DontDestroyOnLoad(this);
    }

    void Start()
    {
        stops = new int[] { 6, 8, 11, 16, 18 };
        dia = new string[] {
            "Buenos días, hoy tenemos unas tareas simples para iniciar", 
            "Logre obtener estas bases de datos de nuestros brokers usuales",
            "Quieren conocer más sobre estas personas, asi que ya sabes que hacer",
            "Para poder conocer más sobre una persona debemos encontrarla en una de estas bases de datos",
            "Haz clic en el triangulo de la base de datos donde la encuentres",
            "No olvides ninguna aparicion, ni pongas de mas. Lo reducire de tu paga", //Stop 1 - 6
            "Las personas tienen distintos comportamiento en las redes", 
            "Ciertas personas cuidan más su huella digital, otros no tanto", //Stop 2 - 8
            "Tuvimos que pagar mucho por esos datos del banco, pero fue mucho más facil conseguir los datos de ese juego",
            "Siempre me sorprende porque esas aplicaciones recolectan tanta información",
            "¡Y si ni siquiera la cuidan!", // Stop 3 - 11
            "Tengo una mejor tarea para ti",
            "Estuve buscando a unas personas dentro del banco X para actualizar nuestra información por ese lado",
            "Creo que nos vendría bien tener información nueva de los clientes del banco",
            "Sin embargo, entre estas personas podríamos hacernos con sus cuentas del trabajo y si se puede hacernos con su cuenta bancaria",
            "Necesito que investigues a estas personas y me digas a quien vale la pena interceptar por correo para apropiarnos de sus cuentas",
            "Si tienes suficientes fondos, podrías comprar unas nuevas bases de datos de nuestro usual para conocer mejor a nuestras cuatro opciones", //Stop 4 - 16
            "Haz click en el card de una persona para abrir su información", 
            "Cuando estes listo, me avisas a quien decidimos atacar" //Stop 5 - 18
        };
        Debug.Log("Start iniciado!");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextDialogue()
    {
        //Debug.Log($"Update dialogue: {UI}, {dialogue_text}, {fondo}");
        //Mejora siguiente -> Repetir parte con boton solo reiniciar iterador y parte
        //stops = new int[] { 6, 8, 11, 16, 18 };
        //Debug.Log($"----> Stop - it: {it} // stop: {stops.Length} // Parte: {part}");
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

    public void UpdateUI()
    {
        //GameObject temp = GameObject.Find("Canvas-Superior2");
        //Debug.Log($"Temp: {temp}");

        //UI = temp.transform.GetChild(1).gameObject;//GameObject.Find("dialogue2");
        //dialogue_text
        //UI = GameObject.Find("Image2");
        //fondo = GameObject.Find("fondo-oscuro2");
        Debug.Log($"Update dialogue: {UI}, {dialogue_text}, {fondo}, Nivel: {GameManager.Instance.nivel}");
    }

    public void death()
    {
        HideUI();
        lose.SetActive(true);
    }
}
