using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    [SerializeField] float lerpRate;
    private void Start()
    {
        offset = ball.transform.position - transform.position;
    }
    private void Update()
    {
        if (!GameManager.instance.gameOver) Follow();
    }
    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos = Vector3.Lerp(pos, targetPos,lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
