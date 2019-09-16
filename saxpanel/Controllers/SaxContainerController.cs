using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Docker.DotNet;
using Docker.DotNet.Models;
using System.Threading;
using saxpanel.Helper;

namespace saxpanel.Controllers
{
    public class SaxContainerController : Controller
    {
        // GET: SaxContainer
        public async Task<IActionResult> Index()
        {
            DockerClient client = new DockerClientConfiguration(
                new Uri("unix:///var/run/docker.sock"))
                .CreateClient();

            IList<ContainerListResponse> containers = await client.Containers.ListContainersAsync(new Docker.DotNet.Models.ContainersListParameters() { Limit = 20 });
            
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