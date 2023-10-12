using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgManager : MonoBehaviour
{
    public static MsgManager Instance { get; private set; }

    public int level = GameManager.Instance.nivel;
    public int part = GameManager.Instance.parte;

    #region //Aqui todos los dialogos  
    List<string> chat_marcia = new List<string>();
    List<string> chat_hilda = new List<string>();
    List<string> chat_jaime = new List<string>();
    public string typing = "...";
    #endregion

    private void Awake() 
    {
        Instance = this;
    }
    
    void Start()
    {
        setDialogo();
    }

    void Update()
    {
        
    }

    void setDialogo() //Registro de los chats
    {
        chat_hilda.Clear();
        chat_marcia.Clear();
        chat_jaime.Clear();
        switch (level)
        {
            case 1:
                #region //Hilda
                chat_hilda.Add("Hola, soy Hilda!");
                chat_hilda.Add("Trabajo en tu misma area");
                chat_hilda.Add("Felicitaciones en tu nuevo puesto");
                chat_hilda.Add("Estamos felices de tener un nuevo integrante en la familia Links!");
                #endregion
                
                #region //Marcia
                chat_marcia.Add("Felicitaciones con tu nuevo empleo hermanito!");
                #endregion

                #region //Jaime
                chat_jaime.Add("Bienvenido a la familia Links!");
                chat_jaime.Add("Antes de iniciar, debes crearte una cuenta en Links");
                chat_jaime.Add("Si tienes alguna duda no dudes en consultarme o a tu compañera Hilda!");
                chat_jaime.Add("Hilda revisa los mismos casos que tu, pero solo como medida de precaución");
                #endregion
                break;
            default:
                Debug.Log("SetDialogo --- Error: " + level);
                break;
        }
        
    }


    
}
