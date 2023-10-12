using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    public GameObject card;

    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
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

    void OnTriggerStay2D(Collider2D other)
    {
        //Grupo 1 --> menores
        //Grupo 2 --> mayores
        if(Input.GetMouseButtonUp(0))
        {
            GameManager.Instance.changePuntaje(other.transform.name);
            /*Antes de eliminar el card, agregar animación de que se va*/
            Destroy(card);
        }
    }
}
