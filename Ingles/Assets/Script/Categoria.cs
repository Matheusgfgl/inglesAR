using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Categoria : MonoBehaviour
{
    public string NextScene;
    public Text textoPontos;
    public int pontosT = 0;
    // Start is called before the first frame update
    void Start()
    {
        pontosT = Userdata.pontosT;
        textoPontos.text = " x " + pontosT.ToString();
    }

    public void ChangeScene(string a)
    {
        Userdata.pontosT = pontosT;
        SceneManager.LoadScene(a);
    }
}
