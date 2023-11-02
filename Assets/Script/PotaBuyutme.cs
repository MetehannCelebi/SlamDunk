using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotaBuyutme : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Sure;
    [SerializeField] private int BaslangicSuresi;
    [SerializeField] private GameManager _gameManager;
    void Start()
    {
        StartCoroutine(SayacBaslasin());
    }

    IEnumerator SayacBaslasin()
    {
        Sure.text = BaslangicSuresi.ToString();
        while (true)
        {
            yield return new WaitForSeconds(1f);
            BaslangicSuresi--;
            Sure.text = BaslangicSuresi.ToString();

            if (BaslangicSuresi==0)
            {
                gameObject.SetActive(false);
                break;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _gameManager.PotaBuyut(transform.position);
        gameObject.SetActive(false);
    }
}
