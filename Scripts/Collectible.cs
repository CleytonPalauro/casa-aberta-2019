using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject myPlayer;

    public int pointValue = 0;

    // Start is called before the first frame update
    void Start() { }

    private void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject == myPlayer)
        {
            Destroy(gameObject);

            PointsManager.UpdatePoints(pointValue);
        }
    }
}
