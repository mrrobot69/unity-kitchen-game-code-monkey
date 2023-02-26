using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private bool isWalking;
    [SerializeField] private float playerSpeed = 2.0f;
    void Update()
    {
        Vector2 inputVector = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        inputVector = inputVector.normalized;
        Vector3 moveDir = new Vector3(inputVector.x,0f,inputVector.y);
        transform.position += moveDir*Time.deltaTime*playerSpeed;
        float rotateSpeed = 10.0f;
        transform.forward = Vector3.Slerp(transform.forward,moveDir,Time.deltaTime*rotateSpeed);
        isWalking = moveDir!=Vector3.zero;
    }
    public bool IsWalking(){
        return isWalking;
    }
}
