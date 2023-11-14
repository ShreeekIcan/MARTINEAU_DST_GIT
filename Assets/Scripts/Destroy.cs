using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroy : MonoBehaviour
{

    public UnityEvent _destroyed;

    private void OnTriggerEnter(Collider other)
    {
        _destroyed.Invoke();
    }
    public void DestroyObject()
    {
        GameObject.Destroy(this.gameObject);
    }
}
