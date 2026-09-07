using UnityEngine;

public class TestRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float rotateSpeed;
    void Update()
    {
        transform.Rotate(_rotation * rotateSpeed * Time.deltaTime);
    }
}