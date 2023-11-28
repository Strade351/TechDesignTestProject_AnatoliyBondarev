using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMenu : MonoBehaviour
{
    public GameObject Object;
    void OnMouseDown()
        {
            Object.SetActive(true);
        }
}
