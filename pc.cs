using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pc : MonoBehaviour
{
    //variables de la clase
    private new Transform camara;
    public float distancia;
    public Animator pcanimator;
    private bool actuar;
    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        pcanimator.SetBool("actuar", actuar);
        if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit colision;
            Debug.DrawRay(camara.position, camara.forward * distancia, Color.green);
            if(Physics.Raycast(camara.position,camara.forward, out colision, distancia, LayerMask.GetMask("interaccion")))
            {
                Debug.Log(colision.transform.name);
                actuar = true;
            }
            else
            {
                actuar = false;
            }
        }
    }
}
