using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalaController : MonoBehaviour
{

    public GameObject balaPrefab;
    public float timeBala;
    // Start is called before the first frame update
    void Start()
    {
        balaPrefab.transform.localScale = new Vector3(1f, 1f, 1f);
        InvokeRepeating("spawnBala",2.0f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           balaPrefab.transform.localScale = new Vector3(3f, 3f, 3f);
           //balaPrefab=Instantiate(balaPrefab, transform.position, Quaternion.identity);
        }
        
    }

    void spawnBala(){
        Instantiate(balaPrefab,transform.position,balaPrefab.transform.rotation);
    }
}
