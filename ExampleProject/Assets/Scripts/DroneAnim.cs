using UnityEngine;
using System.Collections;

public class DroneAnim : MonoBehaviour {
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;

    void Update()
    {
        float tiltAroundZ = Random.Range(Mathf.PerlinNoise(smooth,1.0f)*50, -5.0f);
        float tiltAroundX = Random.Range(-10.0f, 10.0f);
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
