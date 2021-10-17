using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speedEnemy=5.0f;
    void Start()
    {
        Debug.Log("Frame inicial");
        Debug.DrawLine(transform.position,new Vector3(0,0,0),Color.red,5f);//transform.position -> posicion actual
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
