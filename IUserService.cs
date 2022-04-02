﻿using fekon_repository_datamodel.MergeModels;
using fekon_repository_datamodel.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IUserService
    {
        Task AddUserActHist(string userid, string actionDesc, string action);
        Task EditRefEmpAsync(RefEmployee re, string fileLoc, string username, IFormFile file);
        IQueryable<AspNetUser> GetAdminForPaging(string query);
        MergeAdminInfo GetAdminInfoByIdAsync(string id, int takeItem, ref bool canloadmore);
        RefEmployee GetRefEmployeeObjByUserId(string userid);
        IQueryable<AspNetUser> GetUsersForPaging(string query);
    }
}