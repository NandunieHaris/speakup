using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Pep5_Btn : MonoBehaviour
{
    bool sceneIsLoading=false;

    public Image imgCircle;
    private UnityEvent gVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    public UnityEvent GetGVRClick() => gVRClick;

    public void SetGVRClick(UnityEvent value)
    {
        gVRClick = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(GameObject.Find("Image"));
        imgCircle.fillAmount =0;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if (gvrTimer > totalTime && !sceneIsLoading)
        {
            //SceneManager.LoadScene(sceneIndex);
            sceneIsLoading=true;
            SceneManager.LoadScene("audi5",LoadSceneMode.Single);            
            gvrTimer=0f;
        }
    }

    // public void LoadScene(string sceneName)
    // {
    //     SceneManager.LoadScene(sceneName);
    // }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
    
}

