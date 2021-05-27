
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemnger : MonoBehaviour
{
    public bool ended = false;
    public float restartdelay = 2f;
    public void EndGame()
    {

        if (ended == false)
        
            {
                ended = true;
                Debug.Log("GAME OVER");
            Invoke("Restart", restartdelay);
            }

      
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
