using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "Bullet(Clone)")
        {
            this.gameObject.transform.position = new Vector3(Random.Range(-43.2f, 8.5f), 1.35f, Random.Range(3f, 33.3f));
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
