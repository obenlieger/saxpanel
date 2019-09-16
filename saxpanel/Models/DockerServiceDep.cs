namespace saxpanel.Models
{
    public class DockerServiceDep
    {
        public int DockerServiceDepId {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}