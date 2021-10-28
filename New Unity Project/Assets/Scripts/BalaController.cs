using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float speed;
    public float timeBala;
    private GameObject player;
    enum enumTipoEnemigos { Tipo1 = 1, Tipo2, Tipo3 };
    [SerializeField] enumTipoEnemigos tipoEnemigos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Fox");
    }

    // Update is called once per frame
    void Update()
    {
    //     timeBala -= Time.deltaTime;

    //     if(timeBala<=0.0f){
    //         Destroy(gameObject);
    //     }
    //    moveBala();

    switch(tipoEnemigos){

        case enumTipoEnemigos.Tipo1:
            LookAtPlayer();
            MoveTowards();
        break;
        case enumTipoEnemigos.Tipo2:
            float distanciaEntreBalaJugador = Vector3.Distance(player.transform.position,transform.position);
            Debug.Log("distanciaEntreBalaJugador: "+distanciaEntreBalaJugador);
            if(distanciaEntreBalaJugador>=2.0f){
                LookAtPlayer();
                MoveTowards();               
            }else{
                Debug.Log("no te muevas");
                MoveTowards();
            }
        break;
        case enumTipoEnemigos.Tipo3:

        break;        

    }

        LookAtPlayer();
        MoveTowards();

    }

    void moveBala(Vector3 direction){
        transform.Translate(speed* Time.deltaTime * direction);
    }


    private void MoveTowards()
    {
        Vector3 direction   = (player.transform.position - transform.position).normalized;
        transform.position += speed * direction * Time.deltaTime;
    }

    private void LookAtPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = newRotation;
    }

    private void accion(){

    }


}
