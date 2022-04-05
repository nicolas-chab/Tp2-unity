using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Validarcontraseña : MonoBehaviour
{

    string contraseñaCorrecta;
    public Text ingresoUsuario;
    string contraseñaUsuario;
    public GameObject cartelitoMsj;
    public Text textoMsj;

    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    } 

    // Update is called once per frame
    void Update()
    {

    }

    public void ValidarContraseña()
    {
        contraseñaUsuario = ingresoUsuario.text;

        if (contraseñaUsuario == contraseñaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "bienvenido";
            Debug.Log("Bienvenido");
            
        }

        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }

}