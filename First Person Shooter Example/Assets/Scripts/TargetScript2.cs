using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "Bullet(Clone)")
        {
            this.gameObject.transform.position = new Vector3(Random.Range(3.32f, -26.5f), 1.35f, Random.Range(-37.5f, -14.3f));
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
