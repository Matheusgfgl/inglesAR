using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimenta : MonoBehaviour
{
    public int rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rot * Time.deltaTime, 0);
    }
}
