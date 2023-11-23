using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ready : MonoBehaviour
{

    [SerializeField] private GameObject checks;
    private Collider2D col;

    private GameObject carlos;
    private GameObject jairo;
    private GameObject mirasol;
    private GameObject beth;

    public bool isReady = false;

    void Start()
    {
        carlos = GameObject.Find("Victima-Carlos");
        jairo = GameObject.Find("Victima-Jairo");
        mirasol = GameObject.Find("Victima-Mirasol");
        beth = GameObject.Find("Victima-Beth");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !isReady)
        {
            //Debug.Log("Click!");
            GetReady();
            isReady = true;
        }
        else if (Input.GetMouseButtonDown(0) && isReady)
        {
            //Debug.Log("Click2!");
            GetUnReady();
            isReady = false;
        }
    }

    void GetReady()
    {
        checks.SetActive(true);
        GameObject[] a = { carlos, mirasol, beth, jairo };
        for (int i = 0; i < 4; i++)
        {
            col = a[i].GetComponent<BoxCollider2D>();
            col.enabled = false;
        }
    }

    void GetUnReady()
    {
        GameObject[] a = { carlos, mirasol, beth, jairo };
        for (int i = 0; i < 4; i++)
        {
            col = a[i].GetComponent<BoxCollider2D>();
            col.enabled = true;
        }
        checks.SetActive(false);
    }
}
