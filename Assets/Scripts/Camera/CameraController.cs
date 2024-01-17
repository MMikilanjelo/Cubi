using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float _damping;
    public Transform target; 
    private Vector3 vel = Vector3.zero;
    void Awake()
    {
     EventManager<EventTypes.PlayerEvents , Vector3>.RegisterEvent(EventTypes.PlayerEvents.PlayerDeath , onPlayerDeath);
    }
    private void FixedUpdate()
    {

        if(!target) return;
        Vector3 targetPosition = target.position + offset;
        targetPosition.z  = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position , targetPosition , ref vel , _damping);
        
    }
    public void onPlayerDeath(Vector3 _respawnPosition)
    {
      transform.position = new Vector3(_respawnPosition.x , _respawnPosition.y , -1);
    }
    
}
