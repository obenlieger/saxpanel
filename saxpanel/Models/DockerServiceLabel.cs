namespace saxpanel.Models
{
    public class DockerServiceLabel
    {
        public int DockerServiceLabelId {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}