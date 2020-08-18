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
