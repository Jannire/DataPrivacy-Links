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

    #region cards
    private GameObject CarlosCard;
    private GameObject JairoCard;
    private GameObject MirasolCard;
    private GameObject BethCard;
    #endregion

    public BoxCollider2D col;
    private Vector3 posIni = new Vector3(0f, 0f, 0f);
    private Vector3 posIniChild = new Vector3(0f, 0f, 0f);
    private Vector3 posIniCollider = new Vector3(0f, 0f, 0f);
    private Vector2 offsetIni = new Vector2(0f, 0f);
    private Vector2 sizeIni = new Vector2(0f, 0f);
    public bool cardOpen = false;

    void Start()
    {
        Debug.Log("Nivel 2");
        full.SetActive(false);
        card.SetActive(true);
        //Debug.Log("Full: " + full.activeSelf + " Card: " + card.activeSelf);
        //Debug.Log("This card is: " + this.name);
        //string nomCard = this.name.Substring(5);
        #region cards
        JairoCard = GameObject.Find("Card-Jairo");
        MirasolCard = GameObject.Find("Card-Mirasol");
        BethCard = GameObject.Find("Card-Beth");
        CarlosCard = GameObject.Find("Card-Carlos");
        #endregion
        //Debug.Log($"All Cards: {JairoCard.name}, {BethCard.name}, {MirasolCard.name}, {CarlosCard.name}");
        posIni = this.transform.position;
        posIniChild = this.transform.GetChild(0).transform.position;
        offsetIni = col.offset;
        sizeIni = col.size;
        //Debug.Log("Pos Child: " + posIniChild);
        if (!GameManager.Instance.adquirir)
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
        //Debug.Log("Over:" + this.name);
        if (Input.GetMouseButtonDown(0) && cardOpen ) { Cerrar(); }
        else if (Input.GetMouseButtonDown(0) && !cardOpen ) { Abrir(); }
    }
    void Abrir()
    {
        Debug.Log("*********************--ABRIR--*****************");
        card.SetActive(false);
        full.SetActive(true);
        CerrarTodo();
        col.size = new Vector2(1.863308f, 1.853351f);
        col.offset = new Vector2(10.84986f, 4.442803f);
        col.transform.position = new Vector3 (0f, 0f, 0f);
        //col.transform.position = new Vector3(1.400924f, -3.3558f, 0.02803782f);
        this.transform.position = posIni;
        this.transform.GetChild(0).transform.position = posIniChild;
        cardOpen = true;
    }

    void Cerrar()
    {
        Debug.Log("*********************--CERRAR--*****************");
        full.SetActive(false);
        card.SetActive(true);
        col.transform.position = posIniCollider;
        col.offset = offsetIni;
        col.size = sizeIni;
        AbrirTodo();
        this.transform.position = posIni;
        this.transform.GetChild(0).transform.position = posIniChild;

        cardOpen = false;
    }

    void CerrarTodo()
    {
        JairoCard.SetActive(false);
        BethCard.SetActive(false);
        MirasolCard.SetActive(false);
        CarlosCard.SetActive(false);
    }

    void AbrirTodo()
    {
        JairoCard.SetActive(true);
        BethCard.SetActive(true);
        MirasolCard.SetActive(true);
        CarlosCard.SetActive(true);
    }
}
