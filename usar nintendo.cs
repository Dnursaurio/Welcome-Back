using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class usarnintendo : interaccionpc
{
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene("no func nintendo");
    }
}
