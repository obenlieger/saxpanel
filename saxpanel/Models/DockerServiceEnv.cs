namespace saxpanel.Models
{
    public class DockerServiceEnv
    {
        public int DockerServiceEnvId {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}