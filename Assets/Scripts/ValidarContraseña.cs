using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    public string contraseñaCorrecta = "";
    string contraseñaUsuario = "";
    public Text label_Contraseña;
    public GameObject panel_msj;
    public Text label_Respuesta;

    private void Start()
    {
        contraseñaCorrecta = "contraseña";
        panel_msj.SetActive(false);
    }
    public void Validar_Contraseña()
    {
        contraseñaUsuario = label_Contraseña.text;
        if(contraseñaUsuario == contraseñaCorrecta)
        {
            panel_msj.SetActive(true);
            label_Respuesta.text = "Bienvenido";
        }
        else
        {
            panel_msj.SetActive(true);
            label_Respuesta.text = "Contraseña Incorrecta";
        }
    }

    public void Aceptar()
    {
        panel_msj.SetActive(false);
    }
}
