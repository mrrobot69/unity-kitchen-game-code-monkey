using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimator : MonoBehaviour
{
    [SerializeField] playerController player;
    private Animator plAnimator;
    private void Awake(){
        plAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        plAnimator.SetBool("IsWalking",player.IsWalking());
    }
}
