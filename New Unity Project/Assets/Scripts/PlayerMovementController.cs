using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed;
    public float cameraAxisX;
    private float tiempoColision=0.0f;
    private GameObject wall;
    [SerializeField] bool esCruzarPortal=false;
    private int contador=0;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.Find("Wall");
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        RotatePlayer();
    }

    void movePlayer(){
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speed * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }

    private void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion angulo   = Quaternion.Euler(0, cameraAxisX, 0);
        transform.localRotation = angulo;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);    
    }

    private void OnCollisionStay(Collision other){

        if (other.gameObject.CompareTag("Muro"))
        {
           tiempoColision=tiempoColision+Time.deltaTime;
        } 

        if(tiempoColision>2.0f){
            Debug.Log("Colisionaste mas de 2f");
            Debug.Log(wall.transform.position);
            Vector3 nuevaPosicion= new Vector3(Random.Range(-10f, 10f),transform.position.y,Random.Range(-10f, 10f));
            wall.transform.position=nuevaPosicion;
            tiempoColision=0.0f;
        }
 

        
    }

    private void OnTriggerExit(Collider other)
    {
        Vector3 mitadScale= new Vector3(0.5f,0.5f,0.5f);
        Vector3 scaleOriginal= new Vector3(1f,1f,1f);
        Debug.Log("other.tag "+other.tag);
        Debug.Log("esCruzarPortal "+esCruzarPortal);

        if(contador<2){
            if (other.tag == "Portal" && !esCruzarPortal)
            {
                Debug.Log("Entre  ");
                transform.localScale = mitadScale;
                esCruzarPortal = true;
                contador++;
            }

            else
            //if( other.tag == "Portal" && esCruzarPortal)
            {
                Debug.Log("Entre  asdf");
                transform.localScale = scaleOriginal;
                esCruzarPortal = false;
                contador++;
            }
        }else{
            contador=0;
        }


        Debug.Log("esCruzarPortal Saliendo "+esCruzarPortal);

    }





}
