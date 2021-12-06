using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Bumped into " + other.gameObject.ToString());
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log($"Triggered the object {other.gameObject.ToString()}");
    }
}
