using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CerrarAbrir : MonoBehaviour
{
    [SerializeField] private GameObject card;
    [SerializeField] private GameObject full;

    #region  conexiones
    public GameObject hospital;
    public GameObject music;
    #endregion


    void Start()
    {
        Debug.Log("Nivel 2");
        full.SetActive(false);
        card.SetActive(true);
        Debug.Log("Full: " + full.activeSelf + " Card: " + card.activeSelf);

        if(!GameManager.Instance.adquirir)
        {
            Debug.Log("*********************Desactivar*****************");
            hospital.SetActive(false);
            music.SetActive(false);
        }
    }

    void Update()
    {
        //Debug.Log("Mouse: " + Input.GetMouseButtonDown(0));
    }
    void OnMouseOver()
    {
        Debug.Log("Over:" + this.name);
        if(Input.GetMouseButtonDown(1)) { Cerrar(); }
        if(Input.GetMouseButtonDown(0)) { Abrir(); }
    }
    void Abrir()
    {
        card.SetActive(false);
        full.SetActive(true);
        Debug.Log("Abrir?");
    }

    void Cerrar()
    {
        full.SetActive(false);
        card.SetActive(true);
    }
}
