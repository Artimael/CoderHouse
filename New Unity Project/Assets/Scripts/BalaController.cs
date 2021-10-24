using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float speed;
    public float timeBala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeBala -= Time.deltaTime;

        if(timeBala<=0.0f){
            Destroy(gameObject);
        }
       moveBala();
    }

    void moveBala(){
        transform.Translate(speed* Time.deltaTime * Vector3.forward);
    }
}
