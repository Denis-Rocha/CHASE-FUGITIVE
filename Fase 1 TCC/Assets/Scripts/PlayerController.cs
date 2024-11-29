using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimentação")]
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private CharacterController controller;
    private Animator anim;

    private Vector3 moveDirection;
    private Vector3 smoothMoveVelocity;
    private float fallSpeed;

    [Header("Câmera")]
    public Transform cameraPivot; // Ponto de rotação da câmera
    public Transform playerCamera; // A câmera principal

    public float mouseSensitivity = 2f;
    public float cameraDistance = 3f; // Distância máxima da câmera
    public float minDistance = 1f; // Distância mínima da câmera
    public float cameraCollisionRadius = 0.2f; // Raio da esfera para colisão
    public LayerMask collisionMask; // Máscara de colisão para objetos

    public GameObject SomPassos;

    private float xRotation = 0f;
    private RaycastHit hit;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        HandleMovement();
        HandleCameraRotation();
        HandleCombat();
        Passos();
    }

    void LateUpdate()
    {
        HandleCameraCollision();
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 forward = cameraPivot.forward;
        Vector3 right = cameraPivot.right;

        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 targetDirection = (forward * vertical + right * horizontal).normalized * moveSpeed;
        moveDirection = Vector3.SmoothDamp(moveDirection, targetDirection, ref smoothMoveVelocity, 0.1f);

        if (controller.isGrounded)
        {
            fallSpeed = 0f;
            if (Input.GetKey(KeyCode.Space))
            {
                fallSpeed = jumpForce;
            }
        }
        else
        {
            fallSpeed -= 15f * Time.deltaTime;
        }

        moveDirection.y = fallSpeed;
        controller.Move(moveDirection * Time.deltaTime);

       

        anim.SetBool("correndo", horizontal != 0 || vertical != 0);
    }

    private void HandleCameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cameraPivot.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

    private void HandleCameraCollision()
    {
        Vector3 desiredPosition = cameraPivot.position - cameraPivot.forward * cameraDistance;

        if (Physics.SphereCast(cameraPivot.position, cameraCollisionRadius, -cameraPivot.forward, out hit, cameraDistance, collisionMask))
        {
            float adjustedDistance = Mathf.Clamp(hit.distance, minDistance, cameraDistance);
            desiredPosition = cameraPivot.position - cameraPivot.forward * adjustedDistance;
        }

        playerCamera.position = desiredPosition;
        playerCamera.LookAt(cameraPivot);
    }

    private void Passos()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            SomPassos.SetActive(true);
        }
        else { SomPassos.SetActive(false); }

    }

    private void HandleCombat()
    {
        if (Input.GetMouseButtonDown(0)) // Botão esquerdo do mouse pressionado
        {
       
           anim.SetTrigger("ataque");
        }

    }
}
