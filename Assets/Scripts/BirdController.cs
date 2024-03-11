using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Transform targetfocus;
    // Start is called before the first frame update
    void Start()
    {
        targetfocus = GameObject.FindGameObjectWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = targetfocus.position - this.transform.position;
        Debug.Log(target.magnitude);

        if (target.magnitude < 1)
        {
            TargetCollider.instance.moveTarget();
        }
        transform.LookAt(targetfocus.transform);

        float speed = Random.Range(1f, 4f);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
