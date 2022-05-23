using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    //public Button BiologyButton;
    //public GameObject ButttonsGroup;
    public void GetBiology()
    {
        Debug.Log("Pressed");
        //ButttonsGroup.SetActive(false);
        StartCoroutine("BiologyScene");
    }
    IEnumerator BiologyScene()
    {
        //loadingScreen.SetActive(true);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        yield return null;
    }
    public void GetSolarSystem()
    {
        Debug.Log("Pressed");
        //ButttonsGroup.SetActive(false);
        StartCoroutine("SolarSystemScene");
    }
    IEnumerator SolarSystemScene()
    {
        //loadingScreen.SetActive(true);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 2);
        yield return null;
    }
    public void GetMainMenu()
    {
        Debug.Log("Pressed");
        //ButttonsGroup.SetActive(false);
        StartCoroutine("MainMenuScene");
    }
    IEnumerator MainMenuScene()
    {
        //loadingScreen.SetActive(true);
        SceneManager.LoadSceneAsync(0);
        yield return null;
    }
}
