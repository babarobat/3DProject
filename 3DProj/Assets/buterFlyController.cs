using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buterFlyController : MonoBehaviour {
    Vector3 startPos;
    public float radius = 10;
    public float speed = 10;
    Vector3 target;
	Vector3 FindNextPoint()
    {
        var newX = Random.Range(startPos.x - radius, startPos.x + radius);
        var newY = Random.Range(startPos.y - radius, startPos.y + radius);
        var newZ = Random.Range(startPos.z - radius, startPos.z + radius);

        return new Vector3(newX, newY, newZ);
    }
    private void Start()
    {
        startPos = transform.position;
        target = FindNextPoint();
    }
    // Update is called once per frame
    void Update () {
        print(Vector3.Distance(transform.position, target));
        if (Vector3.Distance(transform.position,target)<=0.1)
        {
            
            target = FindNextPoint();
        }
        else
        {
            Vector3 dir = (target - transform.position).normalized;
            transform.position += dir * Time.deltaTime * speed;
            transform.LookAt(target);
        }
        
		
	}
}
