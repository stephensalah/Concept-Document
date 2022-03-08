using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    private bool dead;
    [SerializeField] private float startingHealth;
    public float currentHealth {get; private set;}

    private void Awake(){
        currentHealth=startingHealth;

    }
    public void TakeDamage(float _damage){
        currentHealth = Mathf.Clamp(currentHealth-_damage,0,startingHealth);
        
        if (currentHealth>0){


        }else{
            if (!dead){
                //restart from beginning of level
            }else{
                //Death screen and restart level with hearts again
            }

        }

    }
   
}
