using UnityEngine;
using UnityEngine.UI;

public class InteractLevel2 : Interact
{
    public GameObject manhole;
    public GameObject manholeTarget;
    public GameObject birdWalking;
    public float birdWalkingSpeed;

    private Transform targetPos;
    private Animator birdWalkingAnimator;
    private Animator birdShoutingAnimator;

    void Start()
    {
        birdWalkingAnimator = birdWalking.GetComponent<Animator>();
        targetPos = manholeTarget.transform;
    }

    void Update()
    {
        float step = birdWalkingSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Cast().transform != null)
            {
                if (Cast().transform.name == "BirdWalking")
                {
                    targetPos = birdWalking.transform;
                    birdWalkingAnimator.SetTrigger("isStopped");
                }
            }
        }

        if(birdWalking.transform.position.x < 1.50) {
            targetPos.position = new Vector2(-0.22f,-5.81f);
            step = 1;
        }

        birdWalking.transform.position = Vector3.MoveTowards(birdWalking.transform.position, targetPos.position, step);
    }
}
