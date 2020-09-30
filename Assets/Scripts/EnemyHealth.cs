using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   
    public float health = 100;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDmg(int dmg){

            health -=dmg;
    }
}
