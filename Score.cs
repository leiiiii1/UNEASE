using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Score : MonoBehaviour
{

    public float timeLeft = 30.0f;
    public bool stopTimer = false;
    public Text startText; //used for showing countdown from 3,2,1

    private Animator animator;
    private CameraController camera;
    private bool isHalf;
    private bool isMoreHalf;

    MinusTime minusTime;
    [SerializeField] GameObject minus;

    AddTime addTime;
    [SerializeField] GameObject add;


    Win win;
    [SerializeField] GameObject yay;

    private int subtract;
    private int de;

    private void Start()
    {
        minusTime = minus.GetComponent<MinusTime>();
        addTime = add.GetComponent<AddTime>();
        win = yay.GetComponent<Win>();

        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.onClickStart += TestingEvents_onClickStart;

        animator = GetComponent<Animator>();
        CameraController camera = GetComponent<CameraController>();
    }

    private void TestingEvents_onClickStart(object sender, EventArgs e)
    {
        stopTimer = true;
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.onClickStart -= TestingEvents_onClickStart;

    }
    void Update()
    {
        minusTimer();
        addTimer();
        winScenario();
        timer();
        animatorHandler();
    }

    bool minusTimer()
    {
        if (minusTime != null)
        {
           return minusTime.lesstime();
        }
        return false;
    }
    
    bool addTimer()
    {
        if (addTime != null)
        {
            return addTime.moreTime();
        }
        return false;
    }

    bool winScenario()
    {
        if (win != null)
        {
            return win.winScene();
        }
        return false;
    }

    public void timer()
    {
        if (stopTimer == true)
        {
            timeLeft -= Time.deltaTime;
            startText.text = (timeLeft).ToString("0");


            if (minusTimer())
            {
                timeLeft -= 2;
            }
            if (addTimer())
            {
                de += 1;
                Debug.Log(de);
                if (de == 3)
                {
                    Destroy(add);
                }
                if (timeLeft <= 40)
                {
                    timeLeft += 2;
                }
            }

            if (winScenario())
            {
                Debug.Log("hu");
                SceneManager.LoadScene(4);
            }

            isHalf = timeLeft < 15 ? true : false;
            isMoreHalf = timeLeft < 7 ? true : false;

            if (isMoreHalf == true)
            {
                GetComponent<CameraController>().yOffset = Random.Range(-5.0f,5.0f);
                GetComponent<CameraController>().xOffset = Random.Range(-5.0f, 5.0f);
            }
            if (timeLeft <= 0)
            {
                SceneManager.LoadScene(3); //Scene change
                stopTimer = false;
            }
        }
    }

    void animatorHandler()
    {
        
        animator.SetBool("isHalf", isHalf);
        animator.SetBool("isMoreHalf", isMoreHalf);
    }
}
