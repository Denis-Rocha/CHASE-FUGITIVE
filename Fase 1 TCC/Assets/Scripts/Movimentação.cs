using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float mouseSensitivity = 2f;
    public Transform playerCamera;

    private Vector3 moveDirection = Vector3.zero;

    private Rigidbody rb;
    private CharacterController controller;
    private bool isGrounded;
    private float xRotation = 0f;

    private float veloQueda = 0f;

    private Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("correndo", true);
        }
        else
        {
            anim.SetBool("correndo", false);
        }

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);

        if (controller.isGrounded)
        {
            veloQueda = 0f;

            if (Input.GetKey(KeyCode.Space))
            {
                veloQueda = jumpForce;
            }
        }
        else
        {
            veloQueda -= 9.8f * Time.deltaTime;
        }

        moveDirection.y = veloQueda;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}