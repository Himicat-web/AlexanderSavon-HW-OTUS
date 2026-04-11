using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  [SerializeField] private float speed;
  [SerializeField] private float mouseSensivity;
  private Vector3 moveDirection;
  private float rotationY;
    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        moveDirection = new Vector3(horizontal, 0f, vertical).normalized;
        
        transform.Translate(moveDirection * (speed * Time.deltaTime));
    }

    private void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        rotationY += mouseX * mouseSensivity;
        
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}
