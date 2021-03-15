using UnityEngine;

public class GameScript : MonoBehaviour
{
    public TongueScript SelectedTongue { get; set; }
    public bool Tcontrole = true; // Enable/disable input
    const float MIN_RANGE = 0.1f; // Distance to starting position
    public Boundaries Bounds; // Screen bounds
    public TrajectoryRenderer TongueTrajectory; 
    public Animator animator;
    private int i = 1;

    /* Main mechanics of the tongue is used to be different
     * it should have disappeared after returning to toad
     * but I decided to keep it always on the screen
     * and still didn't deleted all those GetComponents and TongueScript.
     * Will rewrite it later
     */

    void Update()
    {
        Vector3 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // If input is enabled
        if (Tcontrole == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (SelectedTongue == null)
                {
                    Collider2D[] all = Physics2D.OverlapCircleAll(touch, 1f);

                    foreach (var item in all)
                    {
                        if (item.GetComponent<TongueScript>())
                        {
                            SelectedTongue = item.GetComponent<TongueScript>();
                            animator.SetBool("anIdle",false);
                            animator.SetBool("anGrab",true);
                            break;
                        }
                    }
                }
            } 
        }

        if (SelectedTongue != null)
        {
            Bounds.Boundary();
            
            if (i == 1)
            {
                TongueTrajectory.SpawnTrajectory();

                i = 0;
            }
            TongueTrajectory.Trajectory();
            
            // Moving tongue to finger
            SelectedTongue.transform.position = Vector3.MoveTowards
            (SelectedTongue.transform.position, 
                new Vector2 (touch.x,touch.y), 
                Time.deltaTime * 5f);

            // Angle calculation
            var dir = SelectedTongue.StartPos - new Vector2
                (SelectedTongue.transform.position.x, SelectedTongue.transform.position.y);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            SelectedTongue.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            Tcontrole = false;
            if (SelectedTongue != null)
            {
                animator.SetBool("anGrab",false);
                animator.SetBool("anBack",true);
                
                TongueTrajectory.DestroyTrajectory();
                i = 1;
                
                // Tongue strikes using the angle
                SelectedTongue.GetComponent<Rigidbody2D>().isKinematic = false;
                SelectedTongue.GetComponent<Rigidbody2D>().AddForceAtPosition
                (SelectedTongue.transform.right * Vector3.Distance
                    (SelectedTongue.transform.position,
                     SelectedTongue.StartPos) * 700,
                SelectedTongue.StartPos);
            }
            SelectedTongue = null;
        }
        
        // Reaching starting position check
        if (Vector2.Distance(TongueScript.GV.ReturnPos,GameObject.FindWithTag("Tongue").transform.position) < MIN_RANGE)
        {
            Tcontrole = true;
        } 

    }

}