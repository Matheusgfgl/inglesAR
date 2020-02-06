using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Oculos":
                SceneManager.LoadScene("prismahexa");
                break;
            case "SemOculos":
                SceneManager.LoadScene("prismahexaS");
                break;
        }
    }
}