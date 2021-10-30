using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed;
    public float cameraAxisX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            movePlayer(Vector3.forward);
        }

        if(Input.GetKey(KeyCode.S)){
            movePlayer(Vector3.back);
        }

        if(Input.GetKey(KeyCode.A)){
            movePlayer(Vector3.left);
        }

        if(Input.GetKey(KeyCode.D)){
            movePlayer(Vector3.right);
        }
        RotatePlayer();
    }

    void movePlayer(Vector3 direction){
        transform.Translate(speed* Time.deltaTime * direction);
    }

    private void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion angulo   = Quaternion.Euler(0, cameraAxisX, 0);
        transform.localRotation = angulo;
    }


}
