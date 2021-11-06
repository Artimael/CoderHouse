using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasicMovemenController : MonoBehaviour
{
    public float speed;
    bool isForward = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isForward)
        {
            moveEnemy(Vector3.right);
        }
        else
        {
            moveEnemy(Vector3.left);
        }

        if (transform.position.x < -10f && !isForward)
        {
            isForward = true;
        }

        if (transform.position.x > 10f && isForward)
        {
            isForward = false;
        }

    }

        void moveEnemy(Vector3 direction){
        transform.Translate(speed* Time.deltaTime * direction);
    }
}
