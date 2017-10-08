using UnityEngine;

public class Controller : MonoBehaviour {

    private CharacterController cc;
    private float speed = 5f;
    private float gravity = 0f;
    private float _xRot = 0f;

    public Settings playerSettings;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (cc.isGrounded)
        {
            gravity = Physics.gravity.y;
        }
        else
        {
            gravity += Physics.gravity.y * Time.deltaTime;
        }

        float _xMov = Input.GetAxis("Horizontal") * speed;
        float _zMov = Input.GetAxis("Vertical") * speed;

        Vector3 velocity = new Vector3(_xMov, gravity, _zMov);

        float _yRot = Input.GetAxis("Mouse X") * playerSettings.sensitivity;
        transform.Rotate(0, _yRot, 0);

        _xRot -= Input.GetAxis("Mouse Y") * playerSettings.sensitivity;
        _xRot = Mathf.Clamp(_xRot, -90, 90);
        playerSettings.playerCamera.transform.localRotation = Quaternion.Euler(_xRot, 0f, 0f);

        velocity = transform.rotation * velocity;

        cc.Move(velocity * Time.deltaTime);
    }
}
