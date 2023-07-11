using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gasoline : MonoBehaviour
{

    public Image Gasol;

    
    void Update()
    {
        Gasol.fillAmount -= Input.GetAxis("Horizontal") / 3000f;

    }

    public void AddFuel()
    {
        Gasol.fillAmount += 0.3f;
    }

}

