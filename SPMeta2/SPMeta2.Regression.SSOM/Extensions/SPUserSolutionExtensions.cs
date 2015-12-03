﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace SPMeta2.Regression.SSOM.Extensions
{
  internal static  class SPUserSolutionExtensions
    {
      public static bool IsActivated(this SPUserSolution solution)
      {
          return solution.Status == SPUserSolutionStatus.Activated;
      }
    }
}
