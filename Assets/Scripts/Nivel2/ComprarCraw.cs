using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComprarCraw : MonoBehaviour
{
    public GameObject menuComprar;
    public GameObject victimas;
    void Start()
    {
        GameManager.Instance.temp = GameObject.Find("Balance-Text");
        GameManager.Instance.bal = GameManager.Instance.temp.transform;
        Debug.Log("bal: " + GameManager.Instance.temp.transform);
        GameManager.Instance.bal.GetComponent<TextMeshProUGUI>().text = "Balance: " + GameManager.Instance.balance;
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
        SystemDialogue2.Instance.unHideUI();
        SystemDialogue2.Instance.NextDialogue();
    }
}
