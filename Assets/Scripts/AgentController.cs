using UnityEngine;
using UnityEngine.AI; //NavMeshAgent와 같은 Unity의 인공지능 요소를 사용하기 위해 필요

public class AgentController : MonoBehaviour
{
    public Transform startRoom; //시작 지점 Transform 컴포넌트
    public Transform endRoom; //끝 지점 Transform 컴포넌트

    private NavMeshAgent agent; //게임 오브젝트

    void Start()
    {
        this.transform.position = startRoom.transform.position; //에이전트의 위치 시작지점으로 설정
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(endRoom.position);
    }
}
