using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarCraw : MonoBehaviour
{
    public GameObject menuComprar;
    public GameObject victimas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameManager.Instance.adquirir_crawlers(this.name);
        victimas.SetActive(true);
        menuComprar.SetActive(false);
    }
}
