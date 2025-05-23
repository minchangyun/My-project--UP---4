using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody _rigidbody = other.gameObject.GetComponent<Rigidbody>();

            if (_rigidbody != null)
            {
                _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);
                _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
