using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public float mouseSensitivity = 500f;
    private float minXAngle;
    private float maxXAngle;
    private float minYAngle;
    private float maxYAngle;

    [SerializeField] private float minRotationX; // 20
    [SerializeField] private float maxRotationX; // 10
    [SerializeField] private float minRotationY; // 20
    [SerializeField] private float maxRotationY; // 20


    void Start()
    {

        minXAngle = transform.localEulerAngles.x - minRotationX;
        maxXAngle = transform.localEulerAngles.x + maxRotationX;

        minYAngle = transform.localEulerAngles.y - minRotationY;
        maxYAngle = transform.localEulerAngles.y + maxRotationY;

    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 newRotation = transform.localEulerAngles;
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            newRotation.y += mouseX;
            newRotation.x -= mouseY;

            newRotation.x = Mathf.Clamp(newRotation.x, minXAngle, maxXAngle);
            newRotation.y = Mathf.Clamp(newRotation.y, minYAngle, maxYAngle);

            transform.localEulerAngles = newRotation;
        }
    }
}
