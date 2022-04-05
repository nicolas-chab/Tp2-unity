using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mayoriadeedad : MonoBehaviour
{
    public int edadUsuario;
    public Text miTexto; 
    void Start()
    {
        if (edadUsuario >= 18)
        {
            miTexto.text = "es mayor de edad";
            Debug.Log("es mayor de edad");
        }
        else
        {
            miTexto.text = " es menor de edad";
            Debug.Log(" es menor de edad");
        }
          
            
    }

    
    void Update()
    {
        
    }
}
