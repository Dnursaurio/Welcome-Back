using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SND : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            audio.Play();
        }
    }
}
