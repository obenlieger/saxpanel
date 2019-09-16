namespace saxpanel.Models
{
    public class DockerUlimitsNofile
    {
        public int DockerUlimitsNofileId {get;set;}
        public string Name {get;set;}
        public string Value {get;set;}
        public DockerServiceUli DockerServiceUli {get;set;}
    }
}