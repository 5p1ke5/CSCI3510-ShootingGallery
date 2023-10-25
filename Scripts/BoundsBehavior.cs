using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
{
        if (!other.gameObject.CompareTag( "Player"))
        {

            Debug.Log("not a player");
            Debug.Log(other.gameObject.tag);
            Physics.IgnoreCollision(other.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }


    }


}
