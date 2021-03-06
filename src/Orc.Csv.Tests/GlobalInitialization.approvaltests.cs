﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalInitialization.approvaltests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using ApprovalTests.Reporters;

#if DEBUG
[assembly: UseReporter(typeof(BeyondCompareReporter))]
#else
[assembly: UseReporter(typeof(DiffReporter))]
#endif
