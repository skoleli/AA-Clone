using UnityEngine;

public class CenterController : MonoBehaviour
{
    private float _speed;
    private bool _isStopped = true;

    public void StartRotate(float speed)
    {
        MyStart();
        _speed = speed;
    }

    private void FixedUpdate()
    {
        if (_isStopped) return;
        transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
    }

    public void Stop()
    {
        _isStopped = true;
    }

    public void MyStart()
    {
        _isStopped = false;
    }
}