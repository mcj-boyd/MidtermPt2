using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
  public GameObject ball;
    public AudioClip goalSound;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(goalSound, transform.position);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
