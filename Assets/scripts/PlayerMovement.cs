using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _mSpeed;
    [SerializeField] private float _rSpeed;

    private GameObject playerCam;

    // Start is called before the first frame update
    void Start()
    {
        playerCam = GetComponentInChildren<Camera>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCam();

        Vector3 zMove = Input.GetAxis("Vertical") * playerCam.transform.forward;
        Vector3 xMove = Input.GetAxis("Horizontal") * playerCam.transform.right;
        Vector3 movement = zMove + xMove;

        transform.position += new Vector3(movement.x, 0, movement.z) * _mSpeed * Time.deltaTime;
    }

    void RotateCam()
    {
        Vector3 rotation = playerCam.transform.eulerAngles;

        rotation.x -= Input.GetAxis("Mouse Y") * (_rSpeed * 100) * Time.deltaTime;
        rotation.y += Input.GetAxis("Mouse X") * (_rSpeed * 100) * Time.deltaTime;
        rotation.z += 0;

        playerCam.transform.eulerAngles = rotation;
    }
}
