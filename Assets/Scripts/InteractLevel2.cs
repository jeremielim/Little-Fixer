using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractLevel2 : Interact
{
    public GameObject manhole;
    public GameObject manholeTarget;
    public GameObject birdShouting;
    public GameObject birdWalking;
    public GameObject headPhones;
    public float birdWalkingSpeed;

    public Text dialog;
    public GameObject nextButton;

    private Transform targetPos;
    private Animator birdWalkingAnimator;
    private Animator birdShoutingAnimator;
    private bool hasStoppedWalking;
    private bool headPhonesDraggable;

    void Start()
    {
        hasStoppedWalking = false;
        headPhonesDraggable = false;
        birdWalkingAnimator = birdWalking.GetComponent<Animator>();
        birdShoutingAnimator = birdShouting.GetComponent<Animator>();
        targetPos = manholeTarget.transform;
    }

    void Update()
    {
        float step = birdWalkingSpeed * Time.deltaTime;

        if (headPhonesDraggable)
        {
            if (headPhones == null)
            {
                birdWalkingAnimator.SetTrigger("isListening");
                birdShoutingAnimator.SetTrigger("isResting");

                dialog.text = "YAY";
                nextButton.SetActive(true);
            }
        }

        if (Input.GetButton("Fire1"))
        {
            if (Cast().transform != null)
            {
                if (Cast().transform.name == "BirdWalking")
                {
                    targetPos = birdWalking.transform;
                    birdWalkingAnimator.SetTrigger("isStopped");
                    headPhones.SetActive(true);

                    birdWalking.GetComponent<BoxCollider2D>().enabled = false;

                    hasStoppedWalking = true;

                }

                if (Cast().transform.name == "Headphones")
                {
                    headPhones.GetComponent<Draggable>().enabled = true;
                    headPhonesDraggable = true;
                }
            }


        }

        // if bird is over the man hole
        if (birdWalking.transform.position.x < 1.50)
        {
            targetPos.position = new Vector2(-0.22f, -5.81f);
            step = 1;
        }

        // if bird has reached bottom of manhole
        if (birdWalking.transform.position.y <= -5.81f)
        {
            SceneManager.LoadScene("Game02");
        }

        birdWalking.transform.position = Vector3.MoveTowards(birdWalking.transform.position, targetPos.position, step);
    }
}
