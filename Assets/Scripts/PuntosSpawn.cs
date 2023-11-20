using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject conexion;
    public bool isActive = false;

    void Start()
    {
        conexion.SetActive(isActive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //isActive = conexion.activeSelf;
        conexion.SetActive(!conexion.activeSelf);

    }
}
