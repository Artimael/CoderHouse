using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    // Start is called before the first frame update
    public string swordName="Muramasa";
    public int damageSword=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetSwordName(){
        return swordName;
    }

    public void SetSwordName(string newSwordName){
        swordName=newSwordName;
    }

    public int GetDamageSword(){
        return damageSword;
    }

    public void setDamageSword(int newDamageSword){
        damageSword=newDamageSword;
    }
}
