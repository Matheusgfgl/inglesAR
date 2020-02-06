using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MostraPontuação : MonoBehaviour
{
    public GameObject window;
    public GameObject windowR;
    public int ponto;
    public Text textoPontos;
    // Start is called before the first frame update
    void Start()
    {
        ponto = Userdata.ponto;
        textoPontos.text = " x " + ponto.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (ponto >= 3)
            window.SetActive(true);
        else
            windowR.SetActive(true);
    }
    public void ChangeScene(string a)
    {
            Userdata.ponto = 0;
            SceneManager.LoadScene(a);
        
    }
}
