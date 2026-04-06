using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    private float _horizontalAxis;

    [SerializeField] float _speed;

    private void Update()
    {
        Move();
    }
    private  void Move()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(_horizontalAxis, 0);
        transform.Translate(movement * _speed * Time.deltaTime);
    }
}