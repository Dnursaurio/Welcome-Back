using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Radiola : interaccionpc
{
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene("menu musica");
    }
}
