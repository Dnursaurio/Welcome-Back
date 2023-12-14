using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    //variables de la clase
    private new Transform camara;
    public float distancia;
    public Animator camanim;
    public Animator pcanimator;
    private bool interaccion;
    private bool actuar;
    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camara.position, camara.forward * distancia, Color.blue);
        camanim.SetBool("interaccion", interaccion);
        pcanimator.SetBool("actuar", actuar);
        if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit colision;
            if(Physics.Raycast(camara.position,camara.forward, out colision, distancia, LayerMask.GetMask("interaccion")))
            {
                Debug.Log(colision.transform.name);
                interaccion = true;
                actuar = true;
            }
            else
            {
                interaccion = false;
                actuar = false;
            }
        }
    }

}
