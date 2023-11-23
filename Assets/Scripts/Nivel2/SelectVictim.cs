using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectVictim : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<SpriteRenderer>().color = Color.cyan;
            //Debug.Log("Click 3: " + name);
            GameManager.Instance.RevisarNivel2(name);
        }
    }

    void OnMouseExit()
    {
        //GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }

    
    
}
