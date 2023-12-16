using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    private GameManager gameManager;
    private BoxCollider2D col;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
	if (other.name == "player") {
           
        Debug.Log("colision: " + other.gameObject.tag);

	}

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
