using UnityEngine;
using UnityEngine.UI;

public class InteractLevel1 : Interact
{
    public GameObject monster;
    public GameObject thorn;
    public GameObject eyes;
    public GameObject mouth;
    public Text dialog;
    public GameObject nextButton;

    private Animator eyeAnimator;
    private Animator mouthAnimator;

    void Start()
    {
        eyeAnimator = eyes.GetComponent<Animator>();
        mouthAnimator = mouth.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Cast().transform != null)
            {
                if (Cast().transform.name == "Mouth")
                {
                    eyeAnimator.SetBool("isActive", true);
                    mouthAnimator.SetBool("isActive", true);
                    mouth.GetComponent<BoxCollider2D>().enabled = false;
                    thorn.SetActive(true);
                }
            }
        }

        if (thorn == null || Mathf.Abs(thorn.transform.position.x) > 3)
        {
            eyeAnimator.SetBool("isActive", true);
            mouthAnimator.SetBool("isActive", true);
            eyeAnimator.SetBool("isHappy", true);
            mouthAnimator.SetBool("isHappy", true);
            dialog.text = "YAY";
            nextButton.SetActive(true);
        }
    }
}
