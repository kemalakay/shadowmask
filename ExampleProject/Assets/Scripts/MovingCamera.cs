using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    private bool mouselookEnabled = false;
    public float flySpeed = 0.25f;

    void Update()
    {

        mouselookEnabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        var pos = transform.position;
        pos.z = Mathf.Clamp(transform.position.z, -14.0f, 27.0f);
        transform.position = pos;

        if (Input.GetAxis("Vertical") != 0)
        {
            this.transform.Translate(Vector3.forward * flySpeed * Input.GetAxis("Vertical"), Space.World);
        }
    }
}