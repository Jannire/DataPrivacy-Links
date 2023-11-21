using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LlenarBDs : MonoBehaviour
{
    public Transform obs;
    public string nom;
    public GameObject self;

    void Start()
    {
        if(!GameManager.Instance.adquirir)
        {
            if(self.name == "BD-Hospital" || self.name == "BD-MusicRy")
            {
                self.SetActive(false);
                Debug.Log("LlenarBD - 2");
            }
        }
        llenarExtrasBD(obs);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Name: " + self.name);
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
                obj.GetComponent<TextMeshPro>().text = obj.GetComponent<TextMeshPro>().text + "\n" + id + "      " + nom;
            }
            else
            {
                obj.GetComponent<TextMeshPro>().text = obj.GetComponent<TextMeshPro>().text + "\n" + id + "      " + bds[UnityEngine.Random.Range(0, bds.Length)];
            }
        }
    }
}
