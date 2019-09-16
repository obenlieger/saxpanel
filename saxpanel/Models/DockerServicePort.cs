namespace saxpanel.Models
{
    public class DockerServicePort
    {
        public int DockerServicePortId {get;set;}
        public string Name {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}