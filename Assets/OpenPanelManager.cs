using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelManager : MonoBehaviour
{
    
    public GameObject InfoPanel;
    public GameObject Panel;
    public GameObject SkillsPanel;
    public GameObject ContactPanel;
    public GameObject ConnectPanel;



    public void OpenPanelAbout()
    {
        if (InfoPanel != null && Panel !=null)
        {
            bool isActive = InfoPanel.activeSelf;

            Panel.SetActive(!isActive);
            InfoPanel.SetActive(!isActive);
            SkillsPanel.SetActive(false);
            ContactPanel.SetActive(false);
            ConnectPanel.SetActive(false);
        }

    }

    public void OpenPanelSkill()
    {

        if (SkillsPanel != null)
        {
            bool isActive = SkillsPanel.activeSelf;

            Panel.SetActive(false);
            InfoPanel.SetActive(false);
            SkillsPanel.SetActive(!isActive);
            ContactPanel.SetActive(false);
            ConnectPanel.SetActive(false);
        }

    }

    public void OpenPanelContact()
    {
        if(ContactPanel != null)
        {
            bool isActive = ContactPanel.activeSelf;

            Panel.SetActive(false);
            InfoPanel.SetActive(false);
            SkillsPanel.SetActive(false);
            ConnectPanel.SetActive(false);

            ContactPanel.SetActive(!isActive);

        }

    }

    public void OpenPanelConnect()
    {
        if(ConnectPanel != null)
        {
            bool isActive = ConnectPanel.activeSelf;

            Panel.SetActive(false);
            InfoPanel.SetActive(false);
            SkillsPanel.SetActive(false);
            ContactPanel.SetActive(false);

            ConnectPanel.SetActive(!isActive);
        }
        

    }
}
