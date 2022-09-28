using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Animator))]
public class HandAnimationInput : MonoBehaviour
{
    private Animator anim;

    private float gripTarget;
    private float gripCurrent;
    private float triggerTarget;
    private float triggerCurrent;
    [SerializeField]private float speed = 1;
    private const string ANIMATOR_GRIP_PARAM = "Grip";
    private const string ANIMATOR_TRIGGER_PARAM = "Trigger";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animateHand();
    }

    public void SetGrip(float readValue)
    {
        gripTarget = readValue;
    }

    public void SetTrigger(float readValue)
    {
        triggerTarget = readValue;
    }

    private void animateHand()
    {
        if (gripCurrent != gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            anim.SetFloat(ANIMATOR_GRIP_PARAM, gripCurrent);
        }
        if (gripCurrent != gripTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            anim.SetFloat(ANIMATOR_TRIGGER_PARAM, triggerCurrent);
        }
    }
}
