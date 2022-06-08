using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("Owwww!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (
            other.tag == "Package" &&
            !hasPackage
        )
        {
            Debug.Log("Package grabbed!");
            hasPackage = true;
            Destroy(other.gameObject, 0.5f);
        }

        if (
            other.tag == "Customer" &&
            hasPackage
        )
        {
            Debug.Log("Customer hit!");
            hasPackage = false;
            Destroy(other.gameObject, 0.5f);
        }
    }
}
