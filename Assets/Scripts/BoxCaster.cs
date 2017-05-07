using UnityEngine;
using UnityEngine.UI;

public class ThornActions : MonoBehaviour
{
    public GameObject monster;
    public Text dialog;

    private Animator eyeAnimator;
    private Animator mouthAnimator;

    void Start()
    {
        eyeAnimator = monster.transform.FindChild("Eyes").GetComponent<Animator>();
        mouthAnimator = monster.transform.FindChild("Mouth").GetComponent<Animator>();
    }

    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 3)
        {
            eyeAnimator.SetBool("isActive", true);
            mouthAnimator.SetBool("isActive", true);
            eyeAnimator.SetBool("isHappy", true);
            mouthAnimator.SetBool("isHappy", true);
            dialog.text = "Yey!";
        }
    }
}
