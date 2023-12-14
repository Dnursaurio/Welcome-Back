using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccionheredada : MonoBehaviour
{
    private new Transform camara;
    public float distancia;
    public Texture2D pressE;
    public GameObject panelE;
    private bool interaccion = false;
    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit colision;
        Debug.DrawRay(camara.position, camara.forward * distancia, Color.red);
        if(Physics.Raycast(camara.position,camara.forward, out colision, distancia, LayerMask.GetMask("interaccionherencia")))
        {
            interaccion = !interaccion;
            presionaE();
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(colision.transform.name);
                colision.transform.GetComponent<interaccionpc>().Interact();
            }       
        }
        else
        {   
            panelE.SetActive(false);
        }
    }
    public void presionaE()
    {
        if(interaccion)
        {
            panelE.SetActive(true);
        }
    }
    void OnGUI()
    {
        Rect rect = new Rect(Screen.width/2,Screen.height/2,pressE.width,pressE.height);
        GUI.DrawTexture(rect,pressE);
    }
}

