using System.Collections.Generic;

namespace saxpanel.Models
{
    public class DockerServiceUli
    {
        public int DockerServiceUliId {get;set;}
        public string Name {get;set;}
        public string Value {get;set;}
        public DockerService DockerService {get;set;}
        public ICollection<DockerUlimitsNofile> DockerUlimitsNofiles {get;set;}
    }
}