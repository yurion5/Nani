using UnityEngine;


public class QuestPanel : MonoBehaviour
{

    public void FindAndOff()
    {
            //Time.timeScale = 0;
            
            var text_printer = GameObject.Find("Dialogue").GetComponent<Canvas>();
            if (text_printer.enabled == true)
            {
                 text_printer.enabled = false;
            }

            bool exist_choose_printer = GameObject.Find("ButtonList");
            if (exist_choose_printer)
            {
                var choose_printer = GameObject.Find("ButtonList").GetComponent<Canvas>();
                if (choose_printer.enabled == true)
                {
                     choose_printer.enabled = false;
                }
            }
            bool exist_item_on_scene = GameObject.Find("Visual_Item_1");
            if (exist_item_on_scene)
            {
                var item_on_scene = GameObject.Find("Visual_Item_1").GetComponent<Canvas>();
                if (item_on_scene.enabled == true)
                {
                    item_on_scene.enabled = false;
                }
            }

    }

    public void FindAndOn()
    {
            var text_printer = GameObject.Find("Dialogue").GetComponent<Canvas>();
            if (text_printer.enabled == false)
            {
                 text_printer.enabled = true;
            }

            bool exist_choose_printer = GameObject.Find("ButtonList");
            if (exist_choose_printer)
            {
                var choose_printer = GameObject.Find("ButtonList").GetComponent<Canvas>();
                if (choose_printer.enabled == false)
                {
                    choose_printer.enabled = true;
                }
            }
            bool exist_item_on_scene = GameObject.Find("Visual_Item_1");
            if (exist_item_on_scene)
            {
                var item_on_scene = GameObject.Find("Visual_Item_1").GetComponent<Canvas>();
                if (item_on_scene.enabled == false)
                {
                    item_on_scene.enabled = true;
                }
            }

        //Time.timeScale = 1;
    }
}
