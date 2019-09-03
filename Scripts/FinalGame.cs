using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGame : MonoBehaviour
{
    public GameObject myPlayer;

    // Start is called before the first frame update
    void Start() { }

    private void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject == myPlayer)
        {
            SceneManager.LoadScene(0);
        }
    }
}
