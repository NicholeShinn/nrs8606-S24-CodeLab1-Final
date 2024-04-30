using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollider : MonoBehaviour
{
    public EndManager endManager;
    private void Start()
    {
        endManager = GameObject.Find("EndGameManager").GetComponent<EndManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endManager.Movedir();
            Destroy(this.gameObject);
        }
    }
}
