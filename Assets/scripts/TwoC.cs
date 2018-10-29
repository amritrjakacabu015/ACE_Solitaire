using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoC : MonoBehaviour
{

    [SerializeField] private GameObject green_back;

    public void OnMouseDown()
    {
        if (green_back.activeSelf)
        {
            green_back.SetActive(false);
        }
    }
}
