using UnityEngine;

public class QuitOnEscape : MonoBehaviour
{

    // Update is called once per frame
    private void Start()
    {
        Debug.Log("Start se llamo");
    }
    void Update()
    {

       // Debug.Log("Update se llamo");
        if (Input.GetKey ("escape"))
            {
            Debug.Log("escape se llamo");
            Application.Quit();
            }
    }
}
