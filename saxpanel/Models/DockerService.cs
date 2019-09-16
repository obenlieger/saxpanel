using System.Collections.Generic;

namespace saxpanel.Models
{
    public class DockerService
    {
        public int DockerServiceId {get;set;}
        public string name {get;set;}
        public string image {get;set;}
        public string command {get;set;}
        public string restart {get;set;}
        public string aliases {get;set;}
        public string build {get;set;}
        public string tty {get;set;}
        public string stop_grace_period {get;set;}
        public string hostname {get;set;}
        public string privileged {get;set;}
        public string network_mode {get;set;}
        public string oom_kill_disable {get;set;}
                
        public ICollection<DockerServiceEnv> DockerServiceEnvs {get;set;}
        public ICollection<DockerServiceVol> DockerServiceVols {get;set;}
        public ICollection<DockerServiceCap> DockerServiceCaps {get;set;}
        public ICollection<DockerServiceDep> DockerServiceDeps {get;set;}
        public ICollection<DockerServiceDns> DockerServiceDns {get;set;}
        public ICollection<DockerServiceExp> DockerServiceExps {get;set;}
        public ICollection<DockerServiceLabel> DockerServiceLabels {get;set;}
        public ICollection<DockerServicePort> DockerServicePorts {get;set;}
        public ICollection<DockerServiceUli> DockerServiceUlis {get;set;}
        public ICollection<DockerServiceVolFrom> DockerServiceVolFroms {get;set;}
        public ICollection<DockerUlimitsNofile> DockerUlimitsNofiles {get;set;}
    }
}