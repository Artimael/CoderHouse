using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalaController : MonoBehaviour
{

    public GameObject[] balaPrefab;
    public float timeBala;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBala",2.0f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     int balaLength=balaPrefab.Length;
        //     for(int i=0;i<balaLength;i++){
        //     balaPrefab[i].transform.localScale = new Vector3(3f, 3f, 3f);
        //     }
        // }
        
    }

    void spawnBala(){
        int balaIndex = Random.Range(0, balaPrefab.Length);
        Instantiate(balaPrefab[balaIndex], transform.position, balaPrefab[balaIndex].transform.rotation);
    }
}
