using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    
    [SerializeField] private float startingHealth;
    public float currentHealth;
    public Movement MyMovement;
    public GameObject gotHurt;

    

    private void Awake(){
        currentHealth=startingHealth;
        

    }

    
    
    public void TakeDamage(float _damage){
        
        currentHealth = Mathf.Clamp(currentHealth-_damage,0,startingHealth);
        if (GameManager.GM.Lives>0){
            //Let player know he got spiked
            //reset position and take a heart
            MyMovement.move=false;
            GameManager.GM.Lives--;
            gotHurt.SetActive(true);
            Invoke("Delay", 3);
            

        }else{
            
            GameManager.GM.LevelLost = true;
            

            //Restart level and hearts

        }

    }
    void Delay(){
        
        this.gameObject.transform.position = new Vector2(0,-9);
        MyMovement.move=true;
        gotHurt.SetActive(false);
        return;
    }



   
}
