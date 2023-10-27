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

    [SerializeField] private GameObject Hilda;
    [SerializeField] private GameObject Marcia;
    [SerializeField] private GameObject Jaime;

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
                Hilda.SetActive(true);
                Jaime.SetActive(false);
                Marcia.SetActive(false);
                break;
            case "C_Marcia":
                //Cambiar a hilda
                nom_contacto.GetComponent<TextMeshPro>().text = "Marcia";
                Hilda.SetActive(false);
                Jaime.SetActive(false);
                Marcia.SetActive(true);
                break;
            case "C_Jaime":
                //Cambiar a hilda
                nom_contacto.GetComponent<TextMeshPro>().text = "Jaime";
                Hilda.SetActive(false);
                Jaime.SetActive(true);
                Marcia.SetActive(false);
                break;
            default:
                Debug.Log("Mal contacto?");
                break;
        }
    }

}
