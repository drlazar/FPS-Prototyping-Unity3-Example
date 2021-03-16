using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunScript : MonoBehaviour
{

    public GameObject bullet;
    public int maxAmmo =  12;
    int currentAmmo;
    public TextMeshProUGUI AmmoText;
    AudioSource shotSound;
    AudioSource reloadSound;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>(); //sound[0]: shotSound, sound[1]: reloadSound
        shotSound = sounds[0];
        reloadSound = sounds[1];
        currentAmmo = maxAmmo;
        AmmoText.text = currentAmmo.ToString() + "/" + maxAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0)
        {
            shotSound.Play();
            GameObject tempBullet = Instantiate(bullet);
            tempBullet.transform.position = this.transform.position;
            tempBullet.transform.rotation = this.transform.rotation;
            tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 7000f);

            currentAmmo--;
            AmmoText.text = currentAmmo.ToString() + "/" + maxAmmo.ToString();

            Destroy(tempBullet, 5);
        }

        if (Input.GetKeyDown(KeyCode.R) && currentAmmo < maxAmmo)
        {
            reloadSound.Play();
            currentAmmo = maxAmmo;
            AmmoText.text = currentAmmo.ToString() + "/" + maxAmmo.ToString();
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.GetComponent<Animation>().Play("ADS");
        }

        if (Input.GetMouseButtonUp(1))
        {
            this.GetComponent<Animation>().Play("Hip");
        }
    }
}
