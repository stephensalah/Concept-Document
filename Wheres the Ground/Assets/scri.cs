using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    public GameObject lev2;
    private GameObject playerObject;

    void OnTriggerEnter2D(Collider2D player){

        if (player.tag =="Player"){
            //Could add little text and delay to show next level
            lev2.SetActive(true);
            playerObject=player.gameObject;
            playerObject.SetActive(false);
            Invoke("Pause", 5);
            
            
        }

    }
    void Pause(){
        
        
        lev2.SetActive(false);
        GameManager.GM.nextLevel=true;
        playerObject.SetActive(true);
        return;
    }
}
