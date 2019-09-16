using System;
using System.Collections.Generic;

namespace saxpanel.Models
{
    public class SaxCompose
    {
        public int SaxComposeId {get;set;}
        public string Name {get;set;}
        public string DockerComposeFile {get;set;}
        public bool initialized {get;set;}

        public List<SaxService> SaxServices {get;set;}
    }
}