using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalaController : MonoBehaviour
{

    public GameObject balaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        spawnBala();
        InvokeRepeating("spawnBala",3.0f,3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnBala(){
        Instantiate(balaPrefab,transform.position,balaPrefab.transform.rotation);
    }
}
