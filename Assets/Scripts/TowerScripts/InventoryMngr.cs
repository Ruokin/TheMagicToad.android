using UnityEngine;

public class InventoryMngr : MonoBehaviour
{
   public GameObject InvMenuUI;

   public void OpenInv()
   {
      InvMenuUI.SetActive(true);
      
   }
   
   public void Close()
   {
      InvMenuUI.SetActive(false);
   }
}
