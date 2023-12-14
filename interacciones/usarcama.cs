using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class usarcama : interaccionpc
{
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene("Final");
    }
}
