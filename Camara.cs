using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    //Variables de la clase
    public float sensiblilidaddelmouse = 0f;
    public Transform cuerpodelPlayer;
    float rotacionX = 0f;



    // Start is called before the first frame update
    void Start()
    {
        //bloqueo y desaparicion del cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Aqui se ve el movimiento del mouse
        float mousex = Input.GetAxis("Mouse X") * sensiblilidaddelmouse * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * sensiblilidaddelmouse * Time.deltaTime;
        rotacionX -= mousey;
        rotacionX = Mathf.Clamp(rotacionX,-90f,90f);
        transform.localRotation = Quaternion.Euler(rotacionX,0,0);
        cuerpodelPlayer.Rotate(Vector3.up * mousex);
    }
}
