using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interaccionTV : interaccionpc
{
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene("dibujitos 80");
    }
}
