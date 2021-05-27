
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour {

    public Transform player;
    public Text st;
    public float n;

    // Update is called once per frame
    void Update () {
        n = (player.position.z) + 12.2f ;
       
        st.text = (n.ToString("0") );
        

	}
}
