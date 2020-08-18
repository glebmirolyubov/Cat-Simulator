/*
 * Written by Gleb Mirolyubov in August 2020.
 */

using UnityEngine;
using UnityEngine.UI;

public class ClearReactionText : MonoBehaviour
{
    public Text reactionText;

    public void ClearText()
    {
        reactionText.text = "";
    }
}
