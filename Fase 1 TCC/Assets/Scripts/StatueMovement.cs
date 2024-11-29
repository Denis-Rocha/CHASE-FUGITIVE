using UnityEngine;
using UnityEngine.SceneManagement; 

public class StatueMovement : MonoBehaviour
{
    public float speed = 2f; 
    public float distance = 3f; 
    public float zigzagWidth = 1f; 
    private bool isMoving = false; 

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position; 
    }

    private void Update()
    {
        if (isMoving)
        {
          
            float zMovement = Mathf.PingPong(Time.time * speed, distance); 
            float xMovement = Mathf.Sin(Time.time * speed) * zigzagWidth; 

            transform.position = new Vector3(startPos.x + xMovement, startPos.y, startPos.z + zMovement);
        }
    }

   
    public void StartMovement()
    {
        isMoving = true;
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
