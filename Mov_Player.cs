using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Player : MonoBehaviour
{
    //Variables de la clase
    public CharacterController controles;
    public float aceleracion = 30f;
    private float gravedad = -39.81f;
    public Transform pisarSuelo;
    public float radioEsfera = 0.3f;
    public LayerMask sueloMask;
    bool estaenelsuelo;
    Vector3 velocidad;
    public float alturadesalto = 2f;

    // Update is called once per frame
    void Update()
    {
        //detectar colision con el suelo (para poder saltar)
        estaenelsuelo = Physics.CheckSphere(pisarSuelo.position,radioEsfera,sueloMask);
        if(estaenelsuelo && velocidad.y < 0)
        {
            velocidad.y = -2f;
        }
        //movimiento del jugador
        //WASD
        float x = Input.GetAxis("Horizontal");   
        float z = Input.GetAxis("Vertical"); 
        Vector3 moverse = transform.right * x + transform.forward * z; 
        //salto y gravedad
        if(Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            velocidad.y = Mathf.Sqrt(alturadesalto * -2 * gravedad);
        }
        controles.Move(moverse * aceleracion * Time.deltaTime);
        velocidad.y += gravedad * Time.deltaTime;
        controles.Move(velocidad * Time.deltaTime);
    }
}
