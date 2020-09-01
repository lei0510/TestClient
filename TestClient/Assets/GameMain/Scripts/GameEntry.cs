using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;

namespace TestClient
{
    public class GameEntry:ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Debug.LogError("Entry");
        }
    }
}