using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using IPZ_Proj.Validators;

namespace IPZ_Proj.Service
{
    interface IUsersPhotosService
    {
        List<UsersPhotos> GetUsersPhotos();
        void ChangePhoto([PathValidator]string path);
    }
}
