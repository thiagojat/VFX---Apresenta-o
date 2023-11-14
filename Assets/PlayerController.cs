using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject shot;
    public float force;

    Rigidbody l_rigidBody;
    bool l_canShot = true;
    void Update()
    {
        if (Input.GetMouseButton(0) && l_canShot)
        {
            l_rigidBody = Instantiate(shot, transform.position, Quaternion.identity, null).GetComponent<Rigidbody>();
            l_rigidBody.AddForce(transform.forward*force);
            StartCoroutine(CanShotDelay());
        }
    }

    IEnumerator CanShotDelay()
    {
        l_canShot = false;

        float i = 0;
        while (i < 0.5f)
        {
            yield return null;
            i += Time.deltaTime;
        }
        l_canShot = true;

    }
}
