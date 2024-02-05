using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private float walkSpeed;

    [SerializeField] private float walk;
    [SerializeField] private bool jump;

    private void Start()
    {
        jump = false;
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            walk = 1;
        }
        else
        {
            walk = 0;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        else jump = false;

        /* playerAnimator.SetFloat();**/
    }
    private void FixedUpdate()
    {
        if(walk == 1)
        {
            transform.position += new Vector3(walkSpeed, 0f, 0f);
            playerAnimator.SetFloat("Walk Speed", walk);
        }
        else if (walk == 0)
        {
            transform.position += new Vector3(0, 0, 0);
            playerAnimator.SetFloat("Walk Speed", walk);
        }

        if(jump == true)
        {
            transform.position += new Vector3(-0.1f, 0.25f);
            playerAnimator.SetBool("Jump", jump);
        }
    }
}
