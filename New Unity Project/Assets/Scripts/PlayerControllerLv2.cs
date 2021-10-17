using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerLv2 : MonoBehaviour
{
    // Start is called before the first frame update

    public int vidas=2;
    public string nombrePersonaje="Alien 1";
    public double velocidad = 200.05f;

    void Start()
    {
        Debug.Log(vidas);
        transform.position = new Vector3(13,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
