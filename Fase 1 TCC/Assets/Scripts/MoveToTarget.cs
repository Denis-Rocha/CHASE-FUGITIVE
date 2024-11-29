using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public StatueMovement[] statues;
    public Animator animator;
    private bool hasReachedDestination = false;

    private void Start()
    {

        if (animator != null)
        {
            animator.SetBool("correndo", true);
        }
    }

    private void Update()
    {

        if (!hasReachedDestination && target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                hasReachedDestination = true;


                if (animator != null)
                {
                    animator.SetBool("correndo", false);
                }


                foreach (var statue in statues)
                {
                    statue.StartMovement();
                }


                gameObject.SetActive(false);
            }
        }
    }
}