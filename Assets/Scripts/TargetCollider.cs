using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetCollider : MonoBehaviour
{
    public static TargetCollider instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        moveTarget();
    }

    public void moveTarget()
    {
        Vector3 temp;
        temp.x = Random.Range(-4.5f, 4.5f);
        temp.y = Random.Range(0f, 1f);
        temp.z = Random.Range(-4.5f, 4.5f);
        transform.position = new Vector3(temp.x, temp.y, temp.z);
        if (DefaultTrackableEventHandler.trueFalse == true)
        {
            RaycastController.instance.playSound(0);
        }
    }
}
