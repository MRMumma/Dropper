using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DropdownChanger : MonoBehaviour
{
    public Dropdown controlsDropdown;
    void Start()
    {
        controlsDropdown.value = GlobalVariables.controls;

        controlsDropdown.onValueChanged.AddListener(delegate {
            OnDropdownChanged(controlsDropdown);
        });
    }

    void OnDropdownChanged(Dropdown dropDown)
    {
        Debug.Log("Dropdown Value: " + dropDown.value);
    }

    // Set the value of the dropdown to the global variable to set the game controls
    public void ChangeControlsValue()
    {
        if (controlsDropdown.value == 0)
        {
            GlobalVariables.controls = 0;
            Debug.Log("controls value = 0");
        }
        else if (controlsDropdown.value == 1)
        {
            GlobalVariables.controls = 1;
            Debug.Log("controls value = 1");
        }
        else if (controlsDropdown.value == 2)
        {
            GlobalVariables.controls = 2;
            Debug.Log("controls value = 2");
        }
        else if (controlsDropdown.value == 3)
        {
            GlobalVariables.controls = 3;
            Debug.Log("controls value = 3");
        }
    }

    void Update()
    {
        ChangeControlsValue();
        GlobalVariables.controls = controlsDropdown.value;
    }
}
