﻿/*
 * SPDX-License-Identifier: GPL-3.0-only
 * SPDX-FileCopyrightText: 2019 Copyright Corsinvest Srl
 */

using Corsinvest.ProxmoxVE.Api.Shell.Helpers;
using Corsinvest.ProxmoxVE.AutoSnap;
using Corsinvest.ProxmoxVE.AutoSnap.Api;
using Microsoft.Extensions.Logging;

var app = ConsoleHelper.CreateApp(Application.Name, "Automatic snapshot VM/CT with retention");
var loggerFactory = ConsoleHelper.CreateLoggerFactory<Program>(app.GetLogLevelFromDebug());

_ = new Commands(app, loggerFactory);
return await app.ExecuteAppAsync(args, loggerFactory.CreateLogger(typeof(Program)));