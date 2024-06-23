using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterManger : MonoBehaviour
{
    public CharacterDatabase charcaterDatabase;
    public TextMeshProUGUI nameText;
    public SpriteRenderer artworkSprite;
    public int selectedOption;


     void Start()
    {
        UpdateCharacter(selectedOption);
        PlayerPrefs.SetInt("selectionDataBaseIndex", charcaterDatabase.characterCount);
        PlayerPrefs.SetInt("selectionIndex", 0);
    }

    public void NextOption()
    {
        /*selectedOption++;
        if (selectedOption>= charcaterDatabase.characterCount)
        {
            selectedOption = 0;
        }
        PlayerPrefs.SetInt("selectionIndex", selectedOption);*/
        selectedOption=1;
        PlayerPrefs.SetInt("selectionIndex", selectedOption);
        UpdateCharacter(selectedOption);
    }
    public void BackOption()
    {
        /*selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = charcaterDatabase.characterCount - 1;
        }
        PlayerPrefs.SetInt("selectionIndex", selectedOption);*/
        selectedOption = 0;
        PlayerPrefs.SetInt("selectionIndex", selectedOption);
        UpdateCharacter(selectedOption);
    }
    private void UpdateCharacter(int selectedOption)
    {
        Character character = charcaterDatabase.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }
}
