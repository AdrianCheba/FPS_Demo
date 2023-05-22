using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    [SerializeField]
    private TextMeshProUGUI promptHelpText;
    [SerializeField]
    private TextMeshProUGUI promptPowerUPText;
    public GameObject healthBar;

    void Start()
    {
        healthBar = GameObject.Find("HealthBar");
        healthBar.SetActive(false);
        Cursor.visible = false;
    }

    
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }   
    public void UpdateHelpText(string promptMessage)
    {
        promptHelpText.text = promptMessage;
    }  
    
    public void UpdatePowerUPText(string promptMessage)
    {
        promptPowerUPText.text = promptMessage;
    }

    public void HealthBarUpdate(float healthPoints, float maxHP, bool wizable, float fillSpeed)
    {
        if (wizable) 
        { 
            healthBar.SetActive(true);
            healthBar.GetComponent<Image>().fillAmount = Mathf.Lerp(healthBar.GetComponent<Image>().fillAmount, healthPoints / maxHP, fillSpeed);
            ColorChanger(healthPoints, maxHP);
        }
        else
        {
            healthBar.SetActive(false);
        }
    }

    private void ColorChanger(float healthPoints, float maxHP)
    {
        Color healtColor = Color.Lerp(Color.red, Color.green, (healthPoints / maxHP));
        healthBar.GetComponent<Image>().color = healtColor;
    }
}
