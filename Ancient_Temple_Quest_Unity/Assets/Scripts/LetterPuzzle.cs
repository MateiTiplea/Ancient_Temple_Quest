using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LetterPuzzle : MonoBehaviour
{
    public List<XRSocketInteractor> dropZones;
    private const string CorrectWord = "HEAD";

    public void CheckPieces()
    {
        string word = "";
        for(int i = 0; i < dropZones.Count; i++)
        {
            if (!dropZones[i].hasSelection) continue;
            IXRSelectInteractable interactable = dropZones[i].GetOldestInteractableSelected();
            GameObject piece = interactable.transform.gameObject;
            var pieceTag = piece.tag;
            // split the tag to get the letter
            var letter = pieceTag.Split('_')[1];
            word += letter;
        }
        if (word == CorrectWord) Debug.Log("Correct!");
    }
    
    
}
