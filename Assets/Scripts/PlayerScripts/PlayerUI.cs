using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    private GameObject healthBar;

    void Start()
    {
        healthBar = GameObject.Find("HealthBar");
        healthBar.SetActive(false);
    }

    
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void HealthBarUpdate(float healthPoints, bool wizable, float fillSpeed)
    {
        if (wizable) 
        { 
            healthBar.gameObject.SetActive(true);
            healthBar.GetComponent<Image>().fillAmount = Mathf.Lerp(healthBar.GetComponent<Image>().fillAmount, healthPoints / 1, fillSpeed);
        }
        else
        {
            healthBar.gameObject.SetActive(false);
        }

    }
}
