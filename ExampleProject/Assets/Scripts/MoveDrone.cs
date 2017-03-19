using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveDrone : MonoBehaviour 
{
    public float speed;										
	public float delay;										

    private int currentPoint;
	private float arrivalTime;
    private bool reached = false;
	private List<Transform> waypointList = new List<Transform>();
	
	void Awake()
	{
        foreach (Transform child in transform)
            if (child.tag == "Waypoint")
                waypointList.Add(child);

        foreach (Transform waypoint in waypointList)
			waypoint.parent = null;
	}
	
	
	void Update()
	{

	}
	
	//move it toward waypoint
	void FixedUpdate()
	{
		if(!reached)
		{
			if (Vector3.Distance(transform.position, waypointList[currentPoint].position) < 0.3f)
			{
				arrivalTime = Time.time;
				reached = true;
			}
		}
		else
		{
			if(Time.time > arrivalTime + delay)
			{
				currentPoint = (currentPoint == waypointList.Count - 1) ? 0 : currentPoint += 1;
				reached = false;
			}
		}


		if(!reached && waypointList.Count > 0)
		{
			Vector3 direction = waypointList[currentPoint].position - transform.position;
			GetComponent<Rigidbody>().MovePosition(transform.position + (direction.normalized * speed * Time.fixedDeltaTime));
		}
	}
	
	//get the next waypoint
	private void GetNextWP()
	{

		
	}
	
	//draw gizmo spheres for waypoints
	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
        {
            foreach (Transform child in transform)
            {
                if (child.tag == "Waypoint")
                    Gizmos.DrawSphere(child.position, .5f);
            }
        }
    }
}