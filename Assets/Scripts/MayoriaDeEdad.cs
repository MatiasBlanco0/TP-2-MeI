﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsuario;
    // Start is called before the first frame update
    void Start()
    {
        if(edadUsuario >= 18)
        {
            Debug.Log("Mayor de edad");
        }
        else
        {
            Debug.Log("Menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}