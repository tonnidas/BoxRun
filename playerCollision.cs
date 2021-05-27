
using UnityEngine;

public class playerCollision : MonoBehaviour {

    public Movement mt;
    

	
	// Update is called once per frame
	void OnCollisionEnter (Collision cinfo) {
        if (cinfo.collider.tag == "BADHA")
        {
            mt.enabled = false;
            FindObjectOfType<gamemnger>().EndGame(); 
        }
        
    }
}
