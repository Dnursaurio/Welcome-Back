using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject panelpausa;
    private bool estaenpausa = false;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P))
       {
            estaenpausa = !estaenpausa;
            pausar();
       } 
    }
    public void pausar()
    {
        if(estaenpausa)
        {
            Time.timeScale = 0;
            panelpausa.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            panelpausa.SetActive(false);
        }
    }
}
