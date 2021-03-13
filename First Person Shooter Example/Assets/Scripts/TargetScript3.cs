using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript3 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "Bullet(Clone)")
        {
            this.gameObject.transform.position = new Vector3(Random.Range(33.97f, 63.3f), 1.35f, Random.Range(14.7f, -63.9f));
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
