namespace saxpanel.Models
{
    public class DockerServiceCap
    {
        public int DockerServiceCapId {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}