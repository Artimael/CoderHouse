using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLives;
    public string namePlayer= "Default Name";
    public float speedPlayer= 1.0f;
    public Vector3 initPosition = new Vector3(4,2,1);
    public GameObject Espada;

    private int damageSwordBase;
    public bool buffSword=false;
    public int vida;
    public int damageEnemy; 
    public int multiplyEnemyDamage;

    void Start()
    {
        transform.position= initPosition;
        transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        Debug.Assert(playerLives > 0,"Las vidas tienen que ser mayores que cero"); // Se muestra si no se cumple 
        Debug.Log(Espada.GetComponent<SwordController>().GetSwordName());
        Espada.GetComponent<SwordController>().SetSwordName("Espadon");
        Debug.Log(Espada.GetComponent<SwordController>().GetSwordName());
        Espada.transform.position=transform.position + Vector3.forward;
        damageSwordBase=Espada.GetComponent<SwordController>().GetDamageSword();
        Debug.Log("Damage Base sword "+damageSwordBase); 
        if(buffSword){
            Espada.GetComponent<SwordController>().setDamageSword(damageSwordBase+50);
            damageSwordBase=Espada.GetComponent<SwordController>().GetDamageSword();
            Debug.Log("Damage Base sword + Buff "+damageSwordBase); 
        }

        Debug.Log("Vida base del personaje "+vida); 

    }

    // Update is called once per frame
    void Update()
    {
     //get the Input from Horizontal axis
     float horizontalInput = Input.GetAxis("Horizontal");
     transform.position+= new Vector3(horizontalInput * speedPlayer * Time.deltaTime,0,0);  // se movera con las teclas <-  -> 

     if(vida<=0){
        Debug.Log("Estoy muerto");
     }else{
        int dano=Random.Range(1,multiplyEnemyDamage); // Funcion Random para realizar daño/update en base a multiplicador
        Debug.Log("Recibe daño de "+dano);
        vida=vida-dano; 
        Debug.Log("Vida Restante: "+vida);
     }


     

    }
}
