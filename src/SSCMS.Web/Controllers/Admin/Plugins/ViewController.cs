﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using NSwag.Annotations;
using SSCMS.Services;
using SSCMS.Utils;

namespace SSCMS.Web.Controllers.Admin.Plugins
{
    [OpenApiIgnore]
    [Authorize(Roles = AuthTypes.Roles.Administrator)]
    [Route(Constants.ApiAdminPrefix)]
    public partial class ViewController : ControllerBase
    {
        private const string Route = "plugins/view";
        private const string RouteActionsDisable = "plugins/view/actions/disable";
        private const string RouteActionsDelete = "plugins/view/actions/delete";

        private readonly IHostApplicationLifetime _hostApplicationLifetime;
        private readonly ISettingsManager _settingsManager;
        private readonly IAuthManager _authManager;
        private readonly IPluginManager _pluginManager;

        public ViewController(IHostApplicationLifetime hostApplicationLifetime, ISettingsManager settingsManager, IAuthManager authManager, IPluginManager pluginManager)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
            _settingsManager = settingsManager;
            _authManager = authManager;
            _pluginManager = pluginManager;
        }

        public class GetResult
        {
            public bool IsNightly { get; set; }
            public string Version { get; set; }
            public IPlugin LocalPlugin { get; set; }
            public string Content { get; set; }
            public string ChangeLog { get; set; }
        }

        public class DisableRequest
        {
            public string PluginId { get; set; }
            public bool Disabled { get; set; }
        }

        public class DeleteRequest
        {
            public string PluginId { get; set; }
        }
    }
}
