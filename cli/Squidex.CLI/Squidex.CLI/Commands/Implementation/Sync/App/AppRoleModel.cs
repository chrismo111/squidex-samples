﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Squidex.CLI.Commands.Implementation.Sync.App
{
    public sealed class AppRoleModel
    {
        [Required]
        public List<string> Permissions { get; set; }

        public Dictionary<string, object> Properties { get; set; }
    }
}
