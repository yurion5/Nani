using UnityEngine;

public class MapPanel : MonoBehaviour
{

    public void FindAndOffButtons()
    {
        bool exist_choose_printer = GameObject.Find("ButtonList");
        if (exist_choose_printer)
        {
            var choose_printer = GameObject.Find("ButtonList").GetComponent<Canvas>();
            if (choose_printer.enabled == true)
            {
                choose_printer.enabled = false;
            }
        }

    }
    public void FindAndOnButtons()
    {
        bool exist_choose_printer = GameObject.Find("ButtonList");
        if (exist_choose_printer)
        {
            var choose_printer = GameObject.Find("ButtonList").GetComponent<Canvas>();
            if (choose_printer.enabled == false)
            {
                choose_printer.enabled = true;
            }
        }

    }
}
