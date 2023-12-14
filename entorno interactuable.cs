using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entornointeractuable : MonoBehaviour
{
//variables de la clase
    private new Transform camara;
    public float distancia;
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
        if(Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit colision;
            if(Physics.Raycast(camara.position,camara.forward, out colision, distancia, LayerMask.GetMask("interentorno")))
            {
                Debug.Log(colision.transform.name);
                
            }
        }
    }
}
