using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
//variables de la clase
    private new Transform camara;
    public float distancia;
    public Animator camanim;
    public Animator pcanimator;
    private bool interaccion;
    private bool actuar;
    public GameObject panelE;
    private bool interactuar;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Main Camera");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit colision;
        Debug.DrawRay(camara.position, camara.forward * distancia, Color.blue);
        camanim.SetBool("interaccion", interaccion);
        pcanimator.SetBool("actuar", actuar);
        if(Physics.Raycast(camara.position,camara.forward, out colision, distancia, LayerMask.GetMask("interaccion")))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                interactuar = !interactuar;
                presionaE();
                panelE.SetActive(false);
                Debug.Log(colision.transform.name);
                interaccion = true;
                actuar = true;
                audio.Play();
            }
        }
    }
    public void presionaE()
    {
        if(interactuar)
        {
            panelE.SetActive(false);
        }
    }
}
