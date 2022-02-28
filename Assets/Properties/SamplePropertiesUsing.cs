using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePropertiesUsing : MonoBehaviour
{
    [SKC_TagSelector]
    public string TagSelector = ""; // Example usage ==>  player = GameObject.FindGameObjectWithTag(TagSelector);

    [Space]

    [SKC_ReadOnly]
    [SerializeField]
    private string textNonEditable = "Noneditable text."; 
    [SerializeField]
    private string textEditable = "Editable text.";

    [Space]

    [SKC_ReadOnly]
    [SerializeField]
    protected int nonEditableNumber = 23; // Noneditable
    
    [SerializeField]
    protected int editableNumber = 12; // Editable

    [Space]

    [SKC_ReadOnly]
    public Vector2 nonEditableVector = new Vector2(25, 13); // Noneditable

    public Vector2 editableVector = new Vector2(7, 3); // Editable

    [Space]

    public bool showTheFollowing;
    
    [SKC_ConditionalHide("showTheFollowing", true)]
    public bool ItAppearsIfTheAboveIsTrue; // If the above is true, it appears

    [SKC_ConditionalHide("showTheFollowing")]
    public bool appersButNoneditableUntilShowTheFollowingTrue; // It appears but noneditable until "showTheFollowing" = true;
}