using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Docker.DotNet;
using Docker.DotNet.Models;
using System.Threading;
using saxpanel.ViewModels;

namespace saxpanel.Controllers
{
    public class SaxContainerController : Controller
    {
        // GET: SaxContainer
        public async Task<IActionResult> Index()
        {
            List<string> nginxnames = new List<string>();
            nginxnames.Add("mailcowdockerized_nginx-letsencrypt_1");
            nginxnames.Add("mailcowdockerized_nginx-proxy_1");

            List<string> mailcownames = new List<string>();
            mailcownames.Add("mailcowdockerized_ipv6nat-mailcow_1");
            mailcownames.Add("mailcowdockerized_rspamd-mailcow_1");
            mailcownames.Add("mailcowdockerized_acme-mailcow_1");
            mailcownames.Add("mailcowdockerized_netfilter-mailcow_1");
            mailcownames.Add("mailcowdockerized_nginx-mailcow_1");
            mailcownames.Add("mailcowdockerized_php-fpm-mailcow_1");
            mailcownames.Add("mailcowdockerized_mysql-mailcow_1");
            mailcownames.Add("mailcowdockerized_unbound-mailcow_1");
            mailcownames.Add("mailcowdockerized_dovecot-mailcow_1");
            mailcownames.Add("mailcowdockerized_clamd-mailcow_1");
            mailcownames.Add("mailcowdockerized_memcached-mailcow_1");
            mailcownames.Add("mailcowdockerized_redis-mailcow_1");
            mailcownames.Add("mailcowdockerized_olefy-mailcow_1");
            mailcownames.Add("mailcowdockerized_sogo-mailcow_1");
            mailcownames.Add("mailcowdockerized_solr-mailcow_1");
            mailcownames.Add("mailcowdockerized_dockerapi-mailcow_1");
            mailcownames.Add("mailcowdockerized_watchdog-mailcow_1");
            mailcownames.Add("mailcowdockerized_postfix-mailcow_1");

            List<string> ldapnames = new List<string>();
            ldapnames.Add("mailcowdockerized_ldap_1");
            ldapnames.Add("mailcowdockerized_phpldap_1");

            DockerClient client = new DockerClientConfiguration(
                new Uri("unix:///var/run/docker.sock"))
                .CreateClient();

            IList<ContainerListResponse> containers = await client.Containers.ListContainersAsync(new Docker.DotNet.Models.ContainersListParameters() { Limit = 50 });
            
            List<ViewContainer> nginxcontainer = new List<ViewContainer>();
            List<ViewContainer> mailcowcontainer = new List<ViewContainer>();
            List<ViewContainer> ldapcontainer = new List<ViewContainer>();

            foreach(var con in containers)
            {
                foreach(var name in con.Names)
                {
                    var cleanname = name.TrimStart('/');

                    if(nginxnames.Contains(cleanname))
                    {
                        nginxcontainer.Add(new ViewContainer { Id = con.ID, Name = cleanname, State = con.State, Status = con.Status});
                    }         

                    if(mailcownames.Contains(cleanname))
                    {
                        mailcowcontainer.Add(new ViewContainer { Id = con.ID, Name = cleanname, State = con.State, Status = con.Status});
                    }    

                    if(ldapnames.Contains(cleanname))
                    {
                        ldapcontainer.Add(new ViewContainer { Id = con.ID, Name = cleanname, State = con.State, Status = con.Status});
                    }       
                }
            }

            ViewBag.nginxcontainer = nginxcontainer;
            ViewBag.mailcowcontainer = mailcowcontainer;
            ViewBag.ldapcontainer = ldapcontainer;

            ViewBag.containers = containers;            

            return View();
        }

        public async Task<IActionResult> Start(string id)
        {
            DockerClient client = new DockerClientConfiguration(
                new Uri("unix:///var/run/docker.sock"))
                .CreateClient();
            
            await client.Containers.StartContainerAsync(id, null);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Stop(string id)
        {
            DockerClient client = new DockerClientConfiguration(
                new Uri("unix:///var/run/docker.sock"))
                .CreateClient();

            var stopped = await client.Containers.StopContainerAsync(id,
            new ContainerStopParameters
            {
                WaitBeforeKillSeconds = 30
            },
            CancellationToken.None);

            return RedirectToAction("Index");
        }

        // GET: SaxContainer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaxContainer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaxContainer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SaxContainer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaxContainer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SaxContainer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaxContainer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}