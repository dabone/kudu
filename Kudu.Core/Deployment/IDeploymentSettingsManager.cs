﻿using System;
using System.Collections.Generic;

namespace Kudu.Core.Deployment {
    public interface IDeploymentSettingsManager {
        IEnumerable<DeploymentSetting> GetAppSettings();
        IEnumerable<DeploymentSetting> GetConnectionStrings();
        void SetConnectionString(string key, string value);
        void RemoveConnectionString(string key);
        void RemoveAppSetting(string key);
        void SetAppSetting(string key, string value);
    }
}
