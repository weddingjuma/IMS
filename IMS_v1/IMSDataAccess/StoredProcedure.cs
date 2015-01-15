﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMSDataAccess
{
    public class StoredProcedure
    {
        public enum Insert 
        {
            Sp_AddNewDepartment,
            Sp_AddNewSubCategory,
            Sp_AddNewCategory,
            Sp_AddNewProductMaster,
            Sp_AddNewProduct_Detail
        }
        public enum Select 
        {
            Sp_GetDepartmentList,
            Sp_GetSubCategoryList,
            Sp_GetCategoryList,
            Sp_GetProductList,
            Sp_GetProductMaster,
            Sp_GetProductMasterById,
            Sp_GetProduct_Detail,
            Sp_GetProduct_DetailById,
            Sp_GetPro_DetailByDId
        }
        public enum Delete 
        {
            Sp_DeleteDepartment,
            Sp_DeleteSubCategory,
            Sp_DeleteCategory,
            Sp_DeleteProductMasterById,
            Sp_DeleteProduct_DetailById
        }
        public enum Update 
        {
            Sp_UpdateSelectedDepartment,
            Sp_UpdateSubCategory,
            Sp_UpdateCategory,
            Sp_UpdateProductMasterById,
            Sp_UpdateProduct_DetailById
        }
    }
}
