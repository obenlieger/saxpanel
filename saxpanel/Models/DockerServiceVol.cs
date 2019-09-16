namespace saxpanel.Models
{
    public class DockerServiceVol
    {
        public int DockerServiceVolId {get;set;}
        public string Name {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}