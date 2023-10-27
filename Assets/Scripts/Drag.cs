using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    public GameObject card;
    public SpriteRenderer spriteRenderer; //Cambiar sprite
    public Sprite newSprite;
    private Vector3 bScale, sScale;
    private bool isBig = true;

    void Start()
    {
        bScale = new Vector3(2.0213f, 2.0213f, 2.0213f);
        sScale = new Vector3(1f, 1f, 1f);
    }

    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("Clic derecho");
            Cerrar();
        }
    }

    void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Cerrar()
    {
        if (!isBig)
        {
            transform.localScale = bScale;
            isBig = true;
        }
        else
        {
            transform.localScale = sScale;
            isBig = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetMouseButtonUp(0) && !isBig && other.transform.name.Contains("Grupo")) //Grupo es con mayuscula
        {    
            //Debug.Log("Collider: " + other.transform.name);
            GameManager.Instance.changePuntaje(other.transform.name);
            /*Antes de eliminar el card, agregar animación de que se va*/
            Destroy(card);
        }
        else if(isBig)
        {
            Debug.Log("Cierralo antes!");
        }
        else if(!isBig)
        {
            switch (other.transform.name)
            {
                case "Grupo1":
                    GetComponent<SpriteRenderer>().color = Color.cyan;
                    break;
                case "Grupo2":
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    break;
                case "Grupo3":
                    GetComponent<SpriteRenderer>().color = Color.red;
                    break;
                case "Grupo4":
                    GetComponent<SpriteRenderer>().color = Color.yellow;
                    break;
                default:
                    Debug.Log("Culpable: " + other.transform.name);
                    break;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(!isBig)
        {
            switch (other.transform.name)
            {
                case "Grupo1":
                    GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    break;
                case "Grupo2":
                    GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    break;
                case "Grupo3":
                    GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    break;
                case "Grupo4":
                    GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    break;
                default:
                    Debug.Log("Culpable: " + other.transform.name);
                    break;
            }
        }
    }
}
