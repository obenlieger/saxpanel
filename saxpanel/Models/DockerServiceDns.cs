namespace saxpanel.Models
{
    public class DockerServiceDns
    {
        public int DockerServiceDnsId {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
    }
}