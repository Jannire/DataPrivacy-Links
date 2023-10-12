using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhoneLogic : MonoBehaviour
{
    //Este script sirve para hacer las transiciones cuando hacen clic en el celular. El UI del celular
    /*[SerializeField] private GameObject Icon_mensaje;
    [SerializeField] private GameObject Icon_internet;
    [SerializeField] private GameObject Icon_links;
    [SerializeField] private GameObject Icon_news;*/
    [SerializeField] private Transform nom_contacto;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.name.Contains("C_"))
                {
                    CambiarContacto(hit.collider);
                }
            }
        }
    }

    void CambiarContacto(Collider2D contacto)
    {
        switch (contacto.name)
        {
            case "C_Hilda":
                //Cambiar a hilda
                nom_contacto.GetComponent<TextMeshPro>().text = "Hilda";
                break;
            case "C_Marcia":
                //Cambiar a hilda
                nom_contacto.GetComponent<TextMeshPro>().text = "Marcia";
                break;
            case "C_Jaime":
                //Cambiar a hilda
                nom_contacto.GetComponent<TextMeshPro>().text = "Jaime";
                break;
            default:
                Debug.Log("Mal contacto?");
                break;
        }
    }

}
