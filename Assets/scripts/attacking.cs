using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class attacking : MonoBehaviour
{

    [SerializeField]public GameObject player;
    
    // Update is called once per frame
    private void Update()
    {

    }
    
    void OnTriggerEnter (Collider myTrigger) {
        if(myTrigger.gameObject.name == "player"){
           // Debug.Log("ugh!");
           Attacking();
        }
    }

  private void Attacking()
    {
        Debug.Log("player got damaged");
    }
}
