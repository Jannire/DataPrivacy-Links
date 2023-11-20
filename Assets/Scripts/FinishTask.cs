using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishTask : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Next task!");
        GenerarUsers.Instance.next();
    }
}
