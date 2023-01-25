using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject canvasInfo;
    [SerializeField] GameObject parolTr, parolEng, dolorexTr, dolorexEng;
    [SerializeField] Camera m_MainCamera;

    void Start()
    {
        canvasInfo.SetActive(false);

        parolTr.SetActive(false);
        parolEng.SetActive(false);

        dolorexTr.SetActive(false);
        dolorexEng.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray raycast = m_MainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject.tag == "ParolEng")
                {
                    canvasInfo.SetActive(true);

                    parolTr.SetActive(false);
                    parolEng.SetActive(true);

                    dolorexTr.SetActive(false);
                    dolorexEng.SetActive(false);
                }
                if (hit.collider.transform.tag == "ParolTr")
                {
                    canvasInfo.SetActive(true);

                    parolTr.SetActive(true);
                    parolEng.SetActive(false);

                    dolorexTr.SetActive(false);
                    dolorexEng.SetActive(false);
                }
                if (hit.collider.transform.tag == "DolorexTr")
                {
                    canvasInfo.SetActive(true);

                    parolTr.SetActive(false);
                    parolEng.SetActive(false);

                    dolorexTr.SetActive(true);
                    dolorexEng.SetActive(false);
                }
                if (hit.collider.transform.tag == "DolorexEng")
                {
                    canvasInfo.SetActive(true);

                    parolTr.SetActive(false);
                    parolEng.SetActive(false);

                    dolorexTr.SetActive(false);
                    dolorexEng.SetActive(true);
                }
            }
        }
    }


    public void CloseCanvas()
    {
        canvasInfo.SetActive(false);
    }

    public void QuizGame()
    {
        SceneManager.LoadScene("QuizGame");
    }
}
