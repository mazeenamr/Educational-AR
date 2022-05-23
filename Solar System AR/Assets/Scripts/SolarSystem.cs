using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SolarSystem : MonoBehaviour
{
    public List<GameObject> solarSystem;
    public List<Button> solarButtons;
    private int prevIndex =-1;
    public PlanetInfo planetInfo;
    public GameObject infoPanel;

    public void ChangePlanetButton(int index )
    {
        Debug.Log("Clicked :  " + index);
        //Activate Planet
        if (prevIndex == index) return;
        if(prevIndex != -1) {
            solarSystem[prevIndex].SetActive(false);
            solarButtons[prevIndex].GetComponent<Image>().enabled = false;
        }
        solarSystem[index].SetActive(true);
        //Activate Button
        solarButtons[index].GetComponent<Image>().enabled = true;

        planetInfo.LoadTextToScrollBar(solarButtons[index].gameObject.name);
        //update previous index
        prevIndex = index;

    }

    public void InfoPanelAnim()
    {
        Animator anim = infoPanel.GetComponent<Animator>();
        if (anim != null)
        {
            bool isOpen = anim.GetBool("isOpen");
            anim.SetBool("isOpen", !isOpen);
        }
    }

}
