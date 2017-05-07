using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractLevel3 : Interact
{
    public Text dialog;
    public GameObject nextButton;
    public GameObject mango;

    public GameObject cryBabyEye;
    public GameObject cryBabyMouth;

    private Animator cryBabyEyeAnimator;
    private Animator cryBabyMouthAnimator;
    private bool hasEaten;

    void Start()
    {
        hasEaten = false;
        cryBabyEyeAnimator = cryBabyEye.GetComponent<Animator>();
        cryBabyMouthAnimator = cryBabyMouth.GetComponent<Animator>();
    }

    void Update()
    {
        if (mango != null)
        {
            if (mango.transform.position.y <= -5.92f)
            {
                SceneManager.LoadScene("Game03");
            }

            if (mango.transform.position.y < -1.961f && mango.transform.position.x > 1.53f)
            {
                Destroy(mango);
                cryBabyEyeAnimator.SetTrigger("isHappy");
                cryBabyMouthAnimator.SetTrigger("isHappy");

                dialog.text = "Yey!";
                nextButton.SetActive(true);
            }
        }
    }
}
