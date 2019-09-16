using System;

namespace saxpanel.Models
{
    public class SaxService
    {
        public int SaxServiceId {get;set;}
        public string Name {get;set;}
        public string ComposeSnippet {get;set;}
        public bool installed {get;set;}

        public SaxCompose SaxCompose {get;set;}
    }
}