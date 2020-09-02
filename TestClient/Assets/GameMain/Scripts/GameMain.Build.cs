using UnityGameFramework.Runtime;

namespace TestClient
{
    public partial class GameMain
    {
        public BaseComponent Base
        {
            get;
            private set;
        }

        public ConfigComponent Config
        {
            get;
            private set;
        }

        public DataNodeComponent DataNode
        {
            get;
            private set;
        }

        public DataTableComponent DataTable
        {
            get;
            private set;
        }

        public DebuggerComponent Debugger
        {
            get;
            private set;
        }

        public DownloadComponent Download
        {
            get;
            private set;
        }

        public EntityComponent Entity
        {
            get;
            private set;
        }

        public EventComponent Event
        {
            get;
            private set;
        }

        public FsmComponent Fsm
        {
            get;
            private set;
        }

        public LocalizationComponent Localization
        {
            get;
            private set;
        }

        public NetworkComponent Network
        {
            get;
            private set;
        }

        public ObjectPoolComponent ObjectPool
        {
            get;
            private set;
        }

        public ProcedureComponent Procedure
        {
            get;
            private set;
        }

        public ResourceComponent Resource
        {
            get;
            private set;
        }

        public SceneComponent Scene
        {
            get;
            private set;
        }

        public SettingComponent Setting
        {
            get;
            private set;
        }

        public SoundComponent Sound
        {
            get;
            private set;
        }

        public UIComponent UI
        {
            get;
            private set;
        }

        public WebRequestComponent WebRequest
        {
            get;
            private set;
        }

        void InitBuildComponents()
        {
            Base = GameEntry.GetComponent<BaseComponent>();
            Config = GameEntry.GetComponent<ConfigComponent>();
            DataNode = GameEntry.GetComponent<DataNodeComponent>();
            DataTable = GameEntry.GetComponent<DataTableComponent>();
            Debugger = GameEntry.GetComponent<DebuggerComponent>();
            Download = GameEntry.GetComponent<DownloadComponent>();
            Entity = GameEntry.GetComponent<EntityComponent>();
            Event = GameEntry.GetComponent<EventComponent>();
            Fsm = GameEntry.GetComponent<FsmComponent>();
            Localization = GameEntry.GetComponent<LocalizationComponent>();
            Network = GameEntry.GetComponent<NetworkComponent>();
            ObjectPool = GameEntry.GetComponent<ObjectPoolComponent>();
            Procedure = GameEntry.GetComponent<ProcedureComponent>();
            Resource = GameEntry.GetComponent<ResourceComponent>();
            Scene = GameEntry.GetComponent<SceneComponent>();
            Setting = GameEntry.GetComponent<SettingComponent>();
            Sound = GameEntry.GetComponent<SoundComponent>();
            UI = GameEntry.GetComponent<UIComponent>();
            WebRequest = GameEntry.GetComponent<WebRequestComponent>();
        }
    }
}