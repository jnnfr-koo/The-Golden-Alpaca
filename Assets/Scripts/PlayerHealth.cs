using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health Stats")]
    public float maxHealth;
    public float currentHealth;
    
    [Header("Heart Assets")]
    public GameObject heartStorage;
    public GameObject heartPrefab;
    [Space]
    public Sprite emptyHeart;
    public Sprite halfHeart;
    public Sprite fullHeart;

    [SerializeField]
    private ArrayList hearts = new ArrayList();
    //private float healthIncrement = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;

        for (int i = 0; i < maxHealth; i++)
        {
            hearts.Add(Instantiate(heartPrefab, heartStorage.transform));
        }
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Plus)) //Increase health by one half
        {
            currentHealth += 0.5f;
        }
        else if (Input.GetKeyDown(KeyCode.Minus)) //Decrease health by one half
        {
            currentHealth -= 0.5f;
        }
    }
}
