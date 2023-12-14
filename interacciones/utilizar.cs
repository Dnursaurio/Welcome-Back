using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class utilizar : interaccionpc
{
    //variables de la clase
    
    public override void Interact()
    {
        base.Interact();
        SceneManager.LoadScene("MainMenu");
    }
}
