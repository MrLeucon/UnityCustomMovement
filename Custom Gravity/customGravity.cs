using UnityEngine;

public class customGravity : MonoBehaviour
{
    [SerializeField] float gravityForce = -9.81f;
    [SerializeField] float velocityY;
    [SerializeField] float maxGravitySpeed = -15f;
    void Update()
    {
        ApplyGravity();
    }
    void ApplyGravity()
    {
        Gravity();
        transform.Translate(0, velocityY * Time.deltaTime, 0);
    }
    void Gravity()
    {
        velocityY += gravityForce* Time.deltaTime;
        velocityY = Mathf.Max(velocityY, maxGravitySpeed);
    }
}
