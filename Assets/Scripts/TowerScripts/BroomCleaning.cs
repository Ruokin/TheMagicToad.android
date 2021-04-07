using UnityEngine;

public class BroomCleaning : MonoBehaviour
{
    public FirstStart firstStart;
    public GameObject TrashParticlesRight;
    public GameObject TrashParticlesLeft;

    public int TrashNumberRight = 0;
    public int TrashNumberLeft = 0;
    

    //Trash

    public void DeleteTrash1()
    {
        Destroy(GameObject.FindGameObjectWithTag("trash2"));
    }
    
    public void DeleteTrash2()
    {
        Destroy(GameObject.FindGameObjectWithTag("trash1"));
    }
    
    public void DeleteTrash3()
    {
        Destroy(GameObject.FindGameObjectWithTag("trashWeb"));
    }
    
    //Particles

    public void SpawnTrashParticlesRight()
    {
        TrashNumberRight += 1;
        
        switch (TrashNumberRight)
        {
            case 1: 
                Instantiate(TrashParticlesRight, 
                    new Vector3(firstStart.Trash[TrashNumberRight-1].transform.position.x,
                        firstStart.Trash[TrashNumberRight-1].transform.position.y),Quaternion.identity);
                break;
            case 2: 
                Instantiate(TrashParticlesRight, 
                    new Vector3(firstStart.Trash[TrashNumberRight-1].transform.position.x,
                        firstStart.Trash[TrashNumberRight-1].transform.position.y),Quaternion.identity);
                break;
            case 3: 
                Instantiate(TrashParticlesRight, 
                    new Vector3(firstStart.Trash[TrashNumberRight-1].transform.position.x,
                        firstStart.Trash[TrashNumberRight-1].transform.position.y),Quaternion.identity);
                break;
        }
    }
    
    public void SpawnTrashParticlesLeft()
    {
        TrashNumberLeft += 1;
        
        switch (TrashNumberLeft)
        {
            case 1: 
                Instantiate(TrashParticlesLeft, 
                    new Vector3(firstStart.Trash[TrashNumberLeft-1].transform.position.x,
                        firstStart.Trash[TrashNumberLeft-1].transform.position.y),Quaternion.identity);
                break;
            case 2: 
                Instantiate(TrashParticlesLeft, 
                    new Vector3(firstStart.Trash[TrashNumberLeft-1].transform.position.x,
                        firstStart.Trash[TrashNumberLeft-1].transform.position.y),Quaternion.identity);
                break;
            case 3: 
                Instantiate(TrashParticlesLeft, 
                    new Vector3(firstStart.Trash[TrashNumberLeft-1].transform.position.x,
                        firstStart.Trash[TrashNumberLeft-1].transform.position.y),Quaternion.identity);
                break;
        }
    }
    
    public void DeleteTrashParticles()
    {
        Destroy(GameObject.FindGameObjectWithTag("trashParticles"));
    }
    
    
    
    public void DeleteBroom()
    {
        firstStart.Broom.SetActive(false);
        firstStart.TutorialStep += 1;
    }
}
