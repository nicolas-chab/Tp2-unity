using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{
     public int edadUsuario;

    void Start()
       
    {
       

        if (edadUsuario >= 18) 
        {
            Debug.Log("es mayor de edad");
        }
        else 
        {
            Debug.Log("no es mayor de edad");
        }
    }

   
    void Update()
    {
        
    }
}
